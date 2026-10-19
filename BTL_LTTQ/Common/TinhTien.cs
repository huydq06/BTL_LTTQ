using System;
using System.Data;

namespace BTL_LTTQ.Common
{
    // Quy tắc tính tiền: toàn hàm thuần (không đụng CSDL), dễ kiểm tra
    public static class TinhTien
    {
        public const int PhutToiThieu = 15;       // tính tối thiểu 15 phút
        public const decimal BuocLamTron = 1000;  // làm tròn lên 1.000đ

        // Giờ có nằm trong khung [tu, den) không; tu > den là khung qua đêm
        public static bool TrongKhung(TimeSpan gio, TimeSpan tu, TimeSpan den)
        {
            if (tu <= den) return gio >= tu && gio < den;
            return gio >= tu || gio < den;
        }

        // Hệ số của khung giờ đầu tiên khớp; bảng cần cột TuGio, DenGio (TIME), HeSo. Không khớp khung nào = 1
        public static decimal HeSoKhungGio(TimeSpan gio, DataTable khungGio)
        {
            foreach (DataRow r in khungGio.Rows)
            {
                if (TrongKhung(gio, (TimeSpan)r["TuGio"], (TimeSpan)r["DenGio"]))
                    return Convert.ToDecimal(r["HeSo"]);
            }
            return 1m;
        }

        // Giá giờ áp dụng = giá giờ của loại máy x hệ số (làm tròn đến đồng)
        public static decimal GiaGioApDung(decimal giaGio, decimal heSo)
        {
            return Math.Round(giaGio * heSo, 0, MidpointRounding.AwayFromZero);
        }

        // Số phút đã chơi, làm tròn lên
        public static int SoPhut(DateTime batDau, DateTime ketThuc)
        {
            double phut = (ketThuc - batDau).TotalMinutes;
            return phut <= 0 ? 0 : (int)Math.Ceiling(phut);
        }

        // Tiền giờ = phút (tối thiểu 15) x giá / 60, làm tròn lên 1.000đ
        public static decimal TienGio(int soPhut, decimal giaGioApDung)
        {
            int phut = Math.Max(soPhut, PhutToiThieu);
            decimal tien = phut * giaGioApDung / 60m;
            return Math.Ceiling(tien / BuocLamTron) * BuocLamTron;
        }

        public static decimal TienGio(DateTime batDau, DateTime ketThuc, decimal giaGioApDung)
        {
            return TienGio(SoPhut(batDau, ketThuc), giaGioApDung);
        }

        // Giảm giá hội viên trên tiền giờ (phanTram = 0 nếu vãng lai)
        public static decimal GiamGia(decimal tienGio, decimal phanTram)
        {
            return Math.Round(tienGio * phanTram / 100m, 0, MidpointRounding.AwayFromZero);
        }

        // Tổng thanh toán = tiền giờ - giảm giá + tiền dịch vụ
        public static decimal TongTien(decimal tienGio, decimal giamGia, decimal tienDV)
        {
            return tienGio - giamGia + tienDV;
        }
    }
}
