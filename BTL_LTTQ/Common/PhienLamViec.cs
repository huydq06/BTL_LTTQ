namespace BTL_LTTQ.Common
{
    // Thông tin nhân viên đang đăng nhập và ca đang mở (dùng chung toàn ứng dụng)
    public static class PhienLamViec
    {
        public static int MaNV;
        public static string HoTen;
        public static string VaiTro;     // "Admin" hoặc "NhanVien"
        public static int? MaCa;         // null = chưa có ca đang mở

        public static bool LaAdmin { get { return VaiTro == "Admin"; } }
        public static bool CoCaMo { get { return MaCa.HasValue; } }

        // Xóa thông tin khi đăng xuất
        public static void DangXuat()
        {
            MaNV = 0;
            HoTen = null;
            VaiTro = null;
            MaCa = null;
        }
    }
}
