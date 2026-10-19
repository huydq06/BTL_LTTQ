-- Script tạo CSDL quán Cyber Game (SQL Server). Chạy lại nhiều lần được:
-- mỗi lần chạy sẽ xóa các bảng cũ rồi tạo lại cùng dữ liệu mẫu.
IF DB_ID(N'CyberGameDB') IS NULL
    CREATE DATABASE CyberGameDB;
GO
USE CyberGameDB;
GO

-- Xóa bảng theo thứ tự ngược của khóa ngoại
IF OBJECT_ID(N'HoaDon')        IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID(N'ChiTietDichVu') IS NOT NULL DROP TABLE ChiTietDichVu;
IF OBJECT_ID(N'PhienChoi')     IS NOT NULL DROP TABLE PhienChoi;
IF OBJECT_ID(N'NapTien')       IS NOT NULL DROP TABLE NapTien;
IF OBJECT_ID(N'NhapKho')       IS NOT NULL DROP TABLE NhapKho;
IF OBJECT_ID(N'CaLam')         IS NOT NULL DROP TABLE CaLam;
IF OBJECT_ID(N'KhachHang')     IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID(N'May')           IS NOT NULL DROP TABLE May;
IF OBJECT_ID(N'DichVu')        IS NOT NULL DROP TABLE DichVu;
IF OBJECT_ID(N'HangHoiVien')   IS NOT NULL DROP TABLE HangHoiVien;
IF OBJECT_ID(N'KhungGio')      IS NOT NULL DROP TABLE KhungGio;
IF OBJECT_ID(N'LoaiMay')       IS NOT NULL DROP TABLE LoaiMay;
IF OBJECT_ID(N'NhanVien')      IS NOT NULL DROP TABLE NhanVien;
GO

-- 1. Nhân viên (MatKhau = SHA256 hex HOA, 64 ký tự)
CREATE TABLE NhanVien (
    MaNV        INT IDENTITY(1,1) PRIMARY KEY,
    TenDangNhap NVARCHAR(50)  NOT NULL UNIQUE,
    MatKhau     NVARCHAR(64)  NOT NULL,
    HoTen       NVARCHAR(100) NOT NULL,
    VaiTro      NVARCHAR(20)  NOT NULL CHECK (VaiTro IN (N'Admin', N'NhanVien')),
    TrangThai   BIT           NOT NULL DEFAULT 1      -- 1 = đang làm, 0 = đã khóa
);

-- 2. Loại máy và giá giờ
CREATE TABLE LoaiMay (
    MaLoai  INT IDENTITY(1,1) PRIMARY KEY,
    TenLoai NVARCHAR(50)  NOT NULL UNIQUE,
    GiaGio  DECIMAL(18,0) NOT NULL CHECK (GiaGio >= 0)
);

-- 3. Khung giờ có hệ số giá (TuGio > DenGio nghĩa là qua đêm)
CREATE TABLE KhungGio (
    MaKhung  INT IDENTITY(1,1) PRIMARY KEY,
    TenKhung NVARCHAR(50)  NOT NULL,
    TuGio    TIME(0)       NOT NULL,
    DenGio   TIME(0)       NOT NULL,
    HeSo     DECIMAL(4,2)  NOT NULL CHECK (HeSo > 0)
);

-- 4. Máy trạm
CREATE TABLE May (
    MaMay     INT IDENTITY(1,1) PRIMARY KEY,
    TenMay    NVARCHAR(50) NOT NULL UNIQUE,
    MaLoai    INT          NOT NULL REFERENCES LoaiMay(MaLoai),
    TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Trong'
              CHECK (TrangThai IN (N'Trong', N'DangChoi', N'BaoTri'))
);

-- 5. Hạng hội viên (GiamGiaGio tính theo %)
CREATE TABLE HangHoiVien (
    MaHang          INT IDENTITY(1,1) PRIMARY KEY,
    TenHang         NVARCHAR(50)  NOT NULL UNIQUE,
    TongNapToiThieu DECIMAL(18,0) NOT NULL CHECK (TongNapToiThieu >= 0),
    GiamGiaGio      DECIMAL(5,2)  NOT NULL CHECK (GiamGiaGio BETWEEN 0 AND 100)
);

-- 6. Khách hàng hội viên
CREATE TABLE KhachHang (
    MaKH        INT IDENTITY(1,1) PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    SDT         NVARCHAR(15)  NULL,
    SoDu        DECIMAL(18,0) NOT NULL DEFAULT 0 CHECK (SoDu >= 0),
    MaHang      INT           NULL REFERENCES HangHoiVien(MaHang),
    NgayDangKy  DATETIME      NOT NULL DEFAULT GETDATE()
);

-- 7. Dịch vụ (đồ ăn, nước uống)
CREATE TABLE DichVu (
    MaDV       INT IDENTITY(1,1) PRIMARY KEY,
    TenDV      NVARCHAR(100) NOT NULL UNIQUE,
    DonGia     DECIMAL(18,0) NOT NULL CHECK (DonGia >= 0),
    SoLuongTon INT           NOT NULL DEFAULT 0 CHECK (SoLuongTon >= 0)
);

-- 8. Ca làm việc
CREATE TABLE CaLam (
    MaCa       INT IDENTITY(1,1) PRIMARY KEY,
    MaNV       INT           NOT NULL REFERENCES NhanVien(MaNV),
    GioMo      DATETIME      NOT NULL DEFAULT GETDATE(),
    GioDong    DATETIME      NULL,
    TienDauCa  DECIMAL(18,0) NOT NULL DEFAULT 0 CHECK (TienDauCa >= 0),
    TienCuoiCa DECIMAL(18,0) NULL,
    TrangThai  NVARCHAR(10)  NOT NULL DEFAULT N'Mo' CHECK (TrangThai IN (N'Mo', N'Dong'))
);

-- 9. Nạp tiền vào tài khoản hội viên
CREATE TABLE NapTien (
    MaNap   INT IDENTITY(1,1) PRIMARY KEY,
    MaKH    INT           NOT NULL REFERENCES KhachHang(MaKH),
    SoTien  DECIMAL(18,0) NOT NULL CHECK (SoTien > 0),
    NgayNap DATETIME      NOT NULL DEFAULT GETDATE(),
    MaNV    INT           NOT NULL REFERENCES NhanVien(MaNV),
    MaCa    INT           NOT NULL REFERENCES CaLam(MaCa)
);

-- 10. Nhập kho dịch vụ
CREATE TABLE NhapKho (
    MaNhap     INT IDENTITY(1,1) PRIMARY KEY,
    MaDV       INT           NOT NULL REFERENCES DichVu(MaDV),
    SoLuong    INT           NOT NULL CHECK (SoLuong > 0),
    DonGiaNhap DECIMAL(18,0) NOT NULL CHECK (DonGiaNhap >= 0),
    NgayNhap   DATETIME      NOT NULL DEFAULT GETDATE(),
    MaNV       INT           NOT NULL REFERENCES NhanVien(MaNV)
);

-- 11. Phiên chơi (MaKH NULL = khách vãng lai; GiaGioApDung chốt giá lúc mở máy)
CREATE TABLE PhienChoi (
    MaPhien       INT IDENTITY(1,1) PRIMARY KEY,
    MaMay         INT           NOT NULL REFERENCES May(MaMay),
    MaKH          INT           NULL REFERENCES KhachHang(MaKH),
    MaNV          INT           NOT NULL REFERENCES NhanVien(MaNV),
    MaCa          INT           NOT NULL REFERENCES CaLam(MaCa),
    GioBatDau     DATETIME      NOT NULL DEFAULT GETDATE(),
    GioKetThuc    DATETIME      NULL,
    GiaGioApDung  DECIMAL(18,0) NOT NULL CHECK (GiaGioApDung >= 0),
    TrangThai     NVARCHAR(20)  NOT NULL DEFAULT N'DangChoi'
                  CHECK (TrangThai IN (N'DangChoi', N'DaThanhToan'))
);

-- 12. Chi tiết dịch vụ của phiên (mỗi dịch vụ một dòng, gọi thêm thì cộng SoLuong)
CREATE TABLE ChiTietDichVu (
    MaPhien  INT           NOT NULL REFERENCES PhienChoi(MaPhien),
    MaDV     INT           NOT NULL REFERENCES DichVu(MaDV),
    SoLuong  INT           NOT NULL CHECK (SoLuong > 0),
    DonGia   DECIMAL(18,0) NOT NULL CHECK (DonGia >= 0),
    PRIMARY KEY (MaPhien, MaDV)
);

-- 13. Hóa đơn (mỗi phiên tối đa một hóa đơn)
CREATE TABLE HoaDon (
    MaHD        INT IDENTITY(1,1) PRIMARY KEY,
    MaPhien     INT           NOT NULL UNIQUE REFERENCES PhienChoi(MaPhien),
    TienGio     DECIMAL(18,0) NOT NULL,
    TienDV      DECIMAL(18,0) NOT NULL,
    GiamGia     DECIMAL(18,0) NOT NULL DEFAULT 0,
    TongTien    DECIMAL(18,0) NOT NULL,
    HinhThucTT  NVARCHAR(20)  NOT NULL CHECK (HinhThucTT IN (N'TienMat', N'TaiKhoan')),
    NgayLap     DATETIME      NOT NULL DEFAULT GETDATE(),
    MaCa        INT           NOT NULL REFERENCES CaLam(MaCa)
);
GO

-- ===== Dữ liệu mẫu =====
-- Mật khẩu 123456 băm SHA256, hex HOA (trùng BaoMat.Bam)
INSERT INTO NhanVien (TenDangNhap, MatKhau, HoTen, VaiTro) VALUES
    (N'admin',     CONVERT(NVARCHAR(64), HASHBYTES('SHA2_256', '123456'), 2), N'Quản trị viên',  N'Admin'),
    (N'nhanvien1', CONVERT(NVARCHAR(64), HASHBYTES('SHA2_256', '123456'), 2), N'Nhân viên mẫu', N'NhanVien');

INSERT INTO LoaiMay (TenLoai, GiaGio) VALUES (N'Thường', 10000), (N'VIP', 15000);

INSERT INTO KhungGio (TenKhung, TuGio, DenGio, HeSo) VALUES (N'Đêm', '22:00', '06:00', 0.80);

INSERT INTO May (TenMay, MaLoai) VALUES
    (N'May 01', 1), (N'May 02', 1), (N'May 03', 1), (N'May 04', 1), (N'May 05', 1), (N'May 06', 1),
    (N'May VIP 01', 2), (N'May VIP 02', 2), (N'May VIP 03', 2), (N'May VIP 04', 2);

INSERT INTO HangHoiVien (TenHang, TongNapToiThieu, GiamGiaGio) VALUES
    (N'Đồng', 0, 0), (N'Bạc', 500000, 5), (N'Vàng', 2000000, 10);

INSERT INTO DichVu (TenDV, DonGia, SoLuongTon) VALUES
    (N'Nước suối', 5000, 50),
    (N'Coca Cola', 10000, 50),
    (N'Mì tôm trứng', 15000, 30),
    (N'Cà phê', 12000, 30),
    (N'Snack', 8000, 40);
GO
