using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Thống kê doanh thu theo khoảng ngày (doanh thu = tổng HoaDon.TongTien)
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            DateTime homNay = DateTime.Today;
            dtpTuNgay.Value = new DateTime(homNay.Year, homNay.Month, 1);
            dtpDenNgay.Value = homNay;
            cboHinhThuc.SelectedIndex = 0;
            TaiThongKe();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            TaiThongKe();
        }

        private void TaiThongKe()
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime tu = dtpTuNgay.Value.Date;
            DateTime den = dtpDenNgay.Value.Date.AddDays(1);   // đến hết ngày kết thúc

            // Doanh thu theo ngày
            bsDoanhThu.DataSource = DbHelper.LayBang(
                "SELECT CONVERT(DATE, NgayLap) AS [Ngày], COUNT(*) AS [Số hóa đơn], SUM(TongTien) AS [Doanh thu] " +
                "FROM HoaDon WHERE NgayLap >= @tu AND NgayLap < @den GROUP BY CONVERT(DATE, NgayLap) ORDER BY 1",
                DbHelper.Tham("@tu", tu), DbHelper.Tham("@den", den));
            dgvDoanhThu.Columns["Ngày"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvDoanhThu.Columns["Doanh thu"].DefaultCellStyle.Format = "N0";
            dgvDoanhThu.Columns["Số hóa đơn"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDoanhThu.Columns["Doanh thu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Dịch vụ bán chạy (tính trên các phiên đã có hóa đơn)
            bsDichVuBanChay.DataSource = DbHelper.LayBang(
                "SELECT d.TenDV AS [Dịch vụ], SUM(c.SoLuong) AS [Số lượng bán], SUM(c.SoLuong * c.DonGia) AS [Doanh thu] " +
                "FROM HoaDon h JOIN ChiTietDichVu c ON c.MaPhien = h.MaPhien JOIN DichVu d ON d.MaDV = c.MaDV " +
                "WHERE h.NgayLap >= @tu AND h.NgayLap < @den GROUP BY d.TenDV ORDER BY SUM(c.SoLuong) DESC",
                DbHelper.Tham("@tu", tu), DbHelper.Tham("@den", den));
            dgvDichVuBanChay.Columns["Doanh thu"].DefaultCellStyle.Format = "N0";
            dgvDichVuBanChay.Columns["Số lượng bán"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvDichVuBanChay.Columns["Doanh thu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Danh sách hóa đơn
            bsHoaDon.DataSource = DbHelper.LayBang(
                "SELECT h.MaHD AS [Mã HD], m.TenMay AS [Tên máy], h.TienGio AS [Tiền giờ], h.TienDV AS [Tiền dịch vụ], " +
                "h.GiamGia AS [Giảm giá], h.TongTien AS [Tổng tiền], " +
                "CASE h.HinhThucTT WHEN N'TienMat' THEN N'Tiền mặt' ELSE N'Tài khoản' END AS [Hình thức], " +
                "h.NgayLap AS [Ngày lập] FROM HoaDon h JOIN PhienChoi p ON p.MaPhien = h.MaPhien " +
                "JOIN May m ON m.MaMay = p.MaMay WHERE h.NgayLap >= @tu AND h.NgayLap < @den ORDER BY h.NgayLap DESC",
                DbHelper.Tham("@tu", tu), DbHelper.Tham("@den", den));
            foreach (string cot in new[] { "Tiền giờ", "Tiền dịch vụ", "Giảm giá", "Tổng tiền" })
            {
                dgvHoaDon.Columns[cot].DefaultCellStyle.Format = "N0";
                dgvHoaDon.Columns[cot].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            dgvHoaDon.Columns["Ngày lập"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            LocHoaDon();

            // Tổng doanh thu và số hóa đơn
            DataTable tong = DbHelper.LayBang(
                "SELECT COUNT(*) AS SoHD, ISNULL(SUM(TongTien), 0) AS TongTien FROM HoaDon WHERE NgayLap >= @tu AND NgayLap < @den",
                DbHelper.Tham("@tu", tu), DbHelper.Tham("@den", den));
            lblTongDoanhThu.Text = "Tổng doanh thu: " + Convert.ToDecimal(tong.Rows[0]["TongTien"]).ToString("N0") + "đ";
            lblSoHoaDon.Text = "Số hóa đơn: " + tong.Rows[0]["SoHD"];
        }

        // Escape ký tự đặc biệt cho giá trị trong BindingSource.Filter (LIKE)
        private static string ThoatLike(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c == '\'') sb.Append("''");
                else if (c == '[' || c == ']' || c == '*' || c == '%') sb.Append('[').Append(c).Append(']');
                else sb.Append(c);
            }
            return sb.ToString();
        }

        // Lọc nhanh danh sách hóa đơn theo tên máy và hình thức
        private void LocHoaDon()
        {
            if (bsHoaDon.DataSource == null) return;
            var dieuKien = new List<string>();
            string tim = txtTimHoaDon.Text.Trim();
            if (tim.Length > 0)
                dieuKien.Add("[Tên máy] LIKE '%" + ThoatLike(tim) + "%'");
            if (cboHinhThuc.SelectedIndex == 1)
                dieuKien.Add("[Hình thức] = 'Tiền mặt'");
            else if (cboHinhThuc.SelectedIndex == 2)
                dieuKien.Add("[Hình thức] = 'Tài khoản'");
            bsHoaDon.Filter = string.Join(" AND ", dieuKien);
        }

        private void txtTimHoaDon_TextChanged(object sender, EventArgs e)
        {
            LocHoaDon();
        }

        private void cboHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocHoaDon();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
