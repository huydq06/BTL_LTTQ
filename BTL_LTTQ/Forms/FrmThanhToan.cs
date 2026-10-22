using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Thanh toán một phiên chơi (tiền mặt hoặc trừ tài khoản hội viên)
    public partial class FrmThanhToan : Form
    {
        private readonly int _maPhien;
        private int _maMay;
        private int? _maKH;
        private decimal _soDu;
        private DateTime _ketThuc;
        private decimal _tienGio, _tienDV, _giamGia, _tong;
        private bool _daTai;

        public FrmThanhToan(int maPhien)
        {
            InitializeComponent();
            _maPhien = maPhien;
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            DataTable bang = DbHelper.LayBang(
                "SELECT p.MaMay, m.TenMay, p.MaKH, k.HoTen, ISNULL(k.SoDu, 0) AS SoDu, p.GioBatDau, " +
                "p.GiaGioApDung, p.TrangThai, ISNULL(h.GiamGiaGio, 0) AS GiamGiaGio " +
                "FROM PhienChoi p JOIN May m ON m.MaMay = p.MaMay " +
                "LEFT JOIN KhachHang k ON k.MaKH = p.MaKH LEFT JOIN HangHoiVien h ON h.MaHang = k.MaHang " +
                "WHERE p.MaPhien = @p", DbHelper.Tham("@p", _maPhien));
            if (bang.Rows.Count == 0 || bang.Rows[0]["TrangThai"].ToString() != "DangChoi")
            {
                MessageBox.Show("Phiên chơi không còn hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnXacNhan.Enabled = false;
                rdoTaiKhoan.Enabled = false;
                return;
            }
            DataRow r = bang.Rows[0];
            _maMay = Convert.ToInt32(r["MaMay"]);
            _maKH = r["MaKH"] == DBNull.Value ? (int?)null : Convert.ToInt32(r["MaKH"]);
            _soDu = Convert.ToDecimal(r["SoDu"]);
            lblTenMay.Text = r["TenMay"].ToString();
            lblKhach.Text = _maKH.HasValue ? "Hội viên: " + r["HoTen"] : "Khách vãng lai";

            // Chốt giờ kết thúc để số tiền hiển thị trùng số tiền ghi hóa đơn
            DateTime batDau = Convert.ToDateTime(r["GioBatDau"]);
            _ketThuc = DateTime.Now;
            int soPhut = TinhTien.SoPhut(batDau, _ketThuc);
            lblThoiGian.Text = "Thời gian chơi: " + (soPhut / 60) + " giờ " + (soPhut % 60) + " phút (bắt đầu "
                             + batDau.ToString("HH:mm dd/MM") + ")";

            _tienGio = TinhTien.TienGio(soPhut, Convert.ToDecimal(r["GiaGioApDung"]));
            object dv = DbHelper.LayGiaTri("SELECT SUM(SoLuong * DonGia) FROM ChiTietDichVu WHERE MaPhien = @p",
                DbHelper.Tham("@p", _maPhien));
            _tienDV = dv == null ? 0 : Convert.ToDecimal(dv);
            _giamGia = _maKH.HasValue ? TinhTien.GiamGia(_tienGio, Convert.ToDecimal(r["GiamGiaGio"])) : 0;
            _tong = TinhTien.TongTien(_tienGio, _giamGia, _tienDV);

            lblTienGio.Text = _tienGio.ToString("N0") + "đ";
            lblTienDV.Text = _tienDV.ToString("N0") + "đ";
            lblGiamGia.Text = "-" + _giamGia.ToString("N0") + "đ";
            lblTong.Text = _tong.ToString("N0") + "đ";

            // Chỉ hội viên đủ số dư mới được trừ tài khoản
            rdoTaiKhoan.Enabled = _maKH.HasValue && _soDu >= _tong;
            _daTai = true;
            CapNhatSoDu();
        }

        private void CapNhatSoDu()
        {
            if (!_maKH.HasValue)
                lblSoDu.Text = "Số dư: – (khách vãng lai)";
            else if (rdoTaiKhoan.Checked)
                lblSoDu.Text = "Số dư: " + _soDu.ToString("N0") + "đ, còn lại sau thanh toán: " + (_soDu - _tong).ToString("N0") + "đ";
            else
                lblSoDu.Text = "Số dư: " + _soDu.ToString("N0") + (_soDu >= _tong ? "đ" : "đ (không đủ để trừ tài khoản)");
        }

        private void rdoTaiKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (_daTai) CapNhatSoDu();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!PhienLamViec.CoCaMo)
            {
                MessageBox.Show("Chưa có ca làm việc đang mở, không thể lập hóa đơn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool taiKhoan = rdoTaiKhoan.Checked;
            string hinhThuc = taiKhoan ? "TaiKhoan" : "TienMat";
            string hoi = "Thanh toán " + _tong.ToString("N0") + "đ bằng " + (taiKhoan ? "tài khoản hội viên" : "tiền mặt") + "?";
            if (MessageBox.Show(hoi, "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // Một giao dịch: đóng phiên, máy về Trống, ghi hóa đơn, trừ số dư (nếu trả bằng tài khoản)
            var cacLenh = new List<Lenh>
            {
                new Lenh(true, "UPDATE PhienChoi SET GioKetThuc = @kt, TrangThai = N'DaThanhToan' " +
                    "WHERE MaPhien = @p AND TrangThai = N'DangChoi'",
                    DbHelper.Tham("@kt", _ketThuc), DbHelper.Tham("@p", _maPhien)),
                new Lenh(true, "UPDATE May SET TrangThai = N'Trong' WHERE MaMay = @m",
                    DbHelper.Tham("@m", _maMay)),
                new Lenh("INSERT INTO HoaDon (MaPhien, TienGio, TienDV, GiamGia, TongTien, HinhThucTT, NgayLap, MaCa) " +
                    "VALUES (@p, @tg, @dv, @gg, @tong, @ht, GETDATE(), @ca)",
                    DbHelper.Tham("@p", _maPhien), DbHelper.Tham("@tg", _tienGio), DbHelper.Tham("@dv", _tienDV),
                    DbHelper.Tham("@gg", _giamGia), DbHelper.Tham("@tong", _tong), DbHelper.Tham("@ht", hinhThuc),
                    DbHelper.Tham("@ca", PhienLamViec.MaCa))
            };
            if (taiKhoan)
            {
                cacLenh.Add(new Lenh(true, "UPDATE KhachHang SET SoDu = SoDu - @tong WHERE MaKH = @kh AND SoDu >= @tong",
                    DbHelper.Tham("@tong", _tong), DbHelper.Tham("@kh", _maKH)));
            }
            try
            {
                DbHelper.ThucThiGiaoDich(cacLenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thanh toán thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Thanh toán thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
