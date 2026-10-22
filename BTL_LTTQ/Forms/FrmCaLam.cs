using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Mở ca / đóng ca và xem lịch sử ca
    public partial class FrmCaLam : Form
    {
        private decimal _tienDuKien;   // tiền đầu ca + tổng thu của ca đang mở

        public FrmCaLam()
        {
            InitializeComponent();
        }

        private void FrmCaLam_Load(object sender, EventArgs e)
        {
            TaiCa();
        }

        // Nạp trạng thái ca hiện tại và lịch sử
        private void TaiCa()
        {
            DataTable ca = DbHelper.LayBang(
                "SELECT TOP 1 MaCa, GioMo, TienDauCa FROM CaLam WHERE TrangThai = N'Mo' ORDER BY MaCa DESC");

            if (ca.Rows.Count > 0)
            {
                int maCa = Convert.ToInt32(ca.Rows[0]["MaCa"]);
                decimal dauCa = Convert.ToDecimal(ca.Rows[0]["TienDauCa"]);
                PhienLamViec.MaCa = maCa;

                // Tổng thu = hóa đơn tiền mặt + nạp tiền trong ca
                decimal tienMat = Convert.ToDecimal(DbHelper.LayGiaTri(
                    "SELECT ISNULL(SUM(TongTien), 0) FROM HoaDon WHERE MaCa = @ca AND HinhThucTT = N'TienMat'",
                    DbHelper.Tham("@ca", maCa)));
                decimal napTien = Convert.ToDecimal(DbHelper.LayGiaTri(
                    "SELECT ISNULL(SUM(SoTien), 0) FROM NapTien WHERE MaCa = @ca",
                    DbHelper.Tham("@ca", maCa)));
                decimal tongThu = tienMat + napTien;
                _tienDuKien = dauCa + tongThu;

                lblTrangThaiCa.Text = "Ca #" + maCa + " đang mở";
                lblGioMo.Text = Convert.ToDateTime(ca.Rows[0]["GioMo"]).ToString("dd/MM/yyyy HH:mm");
                lblTienDauCa.Text = dauCa.ToString("N0") + "đ";
                lblTongThu.Text = tongThu.ToString("N0") + "đ (tiền mặt " + tienMat.ToString("N0") + "đ + nạp tiền " + napTien.ToString("N0") + "đ)";
                lblTienDuKien.Text = _tienDuKien.ToString("N0") + "đ";
                nudTienCuoiCa.Value = Math.Min(_tienDuKien, nudTienCuoiCa.Maximum);
            }
            else
            {
                PhienLamViec.MaCa = null;
                _tienDuKien = 0;
                lblTrangThaiCa.Text = "Chưa có ca mở";
                lblGioMo.Text = "";
                lblTienDauCa.Text = "";
                lblTongThu.Text = "";
                lblTienDuKien.Text = "";
                nudTienCuoiCa.Value = 0;
            }

            // Bật/tắt khối mở ca, đóng ca theo trạng thái
            bool coCa = PhienLamViec.CoCaMo;
            nudTienDauCa.Enabled = !coCa;
            btnMoCa.Enabled = !coCa;
            nudTienCuoiCa.Enabled = coCa;
            btnDongCa.Enabled = coCa;
            CapNhatChenhLech();

            bsCa.DataSource = DbHelper.LayBang(
                "SELECT TOP 50 c.MaCa AS [Mã ca], n.HoTen AS [Nhân viên], c.GioMo AS [Giờ mở], " +
                "c.GioDong AS [Giờ đóng], c.TienDauCa AS [Tiền đầu ca], c.TienCuoiCa AS [Tiền cuối ca], " +
                "CASE c.TrangThai WHEN N'Mo' THEN N'Đang mở' ELSE N'Đã đóng' END AS [Trạng thái] " +
                "FROM CaLam c JOIN NhanVien n ON n.MaNV = c.MaNV ORDER BY c.MaCa DESC");
            dgvCa.Columns["Tiền đầu ca"].DefaultCellStyle.Format = "N0";
            dgvCa.Columns["Tiền cuối ca"].DefaultCellStyle.Format = "N0";
            dgvCa.Columns["Tiền đầu ca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCa.Columns["Tiền cuối ca"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvCa.Columns["Giờ mở"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvCa.Columns["Giờ đóng"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvCa.Columns["Mã ca"].FillWeight = 50;
            dgvCa.Columns["Giờ mở"].FillWeight = 130;
            dgvCa.Columns["Giờ đóng"].FillWeight = 130;
        }

        private void CapNhatChenhLech()
        {
            if (!PhienLamViec.CoCaMo)
            {
                lblChenhLech.Text = "0";
                lblChenhLech.ForeColor = Color.FromArgb(124, 58, 237);
                return;
            }
            decimal chenh = nudTienCuoiCa.Value - _tienDuKien;
            lblChenhLech.Text = chenh.ToString("N0") + "đ";
            lblChenhLech.ForeColor = chenh < 0 ? Color.Red : (chenh > 0 ? Color.Blue : Color.FromArgb(124, 58, 237));
        }

        private void btnMoCa_Click(object sender, EventArgs e)
        {
            if (PhienLamViec.CoCaMo) return;
            // Chỉ chèn khi chưa có ca nào đang mở
            object ma = DbHelper.LayGiaTri(
                "INSERT INTO CaLam (MaNV, GioMo, TienDauCa, TrangThai) " +
                "SELECT @nv, GETDATE(), @tien, N'Mo' WHERE NOT EXISTS (SELECT 1 FROM CaLam WHERE TrangThai = N'Mo'); " +
                "SELECT SCOPE_IDENTITY();",
                DbHelper.Tham("@nv", PhienLamViec.MaNV), DbHelper.Tham("@tien", nudTienDauCa.Value));
            if (ma == null)
            {
                MessageBox.Show("Đã có một ca khác đang mở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Đã mở ca làm việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TaiCa();
        }

        private void nudTienCuoiCa_ValueChanged(object sender, EventArgs e)
        {
            CapNhatChenhLech();
        }

        private void btnDongCa_Click(object sender, EventArgs e)
        {
            if (!PhienLamViec.CoCaMo) return;

            // Không đóng ca khi còn máy đang chơi
            int dangChoi = Convert.ToInt32(DbHelper.LayGiaTri("SELECT COUNT(*) FROM May WHERE TrangThai = N'DangChoi'"));
            if (dangChoi > 0)
            {
                MessageBox.Show("Còn " + dangChoi + " máy đang chơi, hãy thanh toán trước khi đóng ca.",
                    "Không thể đóng ca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal chenh = nudTienCuoiCa.Value - _tienDuKien;
            string hoi = "Đóng ca với tiền cuối ca " + nudTienCuoiCa.Value.ToString("N0") + "đ (chênh lệch "
                       + chenh.ToString("N0") + "đ)?";
            if (MessageBox.Show(hoi, "Xác nhận đóng ca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            DbHelper.ThucThi(
                "UPDATE CaLam SET GioDong = GETDATE(), TienCuoiCa = @tien, TrangThai = N'Dong' " +
                "WHERE MaCa = @ca AND TrangThai = N'Mo'",
                DbHelper.Tham("@tien", nudTienCuoiCa.Value), DbHelper.Tham("@ca", PhienLamViec.MaCa));
            PhienLamViec.MaCa = null;
            MessageBox.Show("Đã đóng ca.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TaiCa();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
