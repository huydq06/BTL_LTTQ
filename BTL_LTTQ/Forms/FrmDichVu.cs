using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Quản lý dịch vụ (đồ ăn, nước uống) và nhập kho (Admin)
    public partial class FrmDichVu : Form
    {
        public FrmDichVu()
        {
            InitializeComponent();
        }

        // ===== Hàm dùng chung =====

        // Định dạng cột lưới: dinhDang (N0, dd/MM/yyyy HH:mm...), canPhai, trongSo (độ rộng tương đối, 0 = giữ nguyên)
        private static void DinhDangCot(DataGridView dgv, string ten, string dinhDang, bool canPhai, int trongSo)
        {
            if (!dgv.Columns.Contains(ten)) return;
            DataGridViewColumn cot = dgv.Columns[ten];
            if (dinhDang != null) cot.DefaultCellStyle.Format = dinhDang;
            if (canPhai)
            {
                cot.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                cot.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (trongSo > 0) cot.FillWeight = trongSo;
        }

        private bool Kiem(Control c, bool loi, string thongBao)
        {
            err.SetError(c, loi ? thongBao : "");
            return !loi;
        }

        // Escape chuỗi để dùng trong BindingSource.Filter (LIKE)
        private static string ThoatLoc(string s)
        {
            return s.Replace("[", "[[]").Replace("%", "[%]").Replace("*", "[*]").Replace("'", "''");
        }

        private static string LoiSql(Exception ex, string doiTuong)
        {
            var sql = ex as SqlException;
            if (sql != null && sql.Number == 547) return doiTuong + " đang được sử dụng, không thể xóa.";
            if (sql != null && (sql.Number == 2627 || sql.Number == 2601)) return "Tên " + doiTuong + " đã tồn tại.";
            return "Thao tác thất bại: " + ex.Message;
        }

        private static void Loi(string noiDung)
        {
            MessageBox.Show(noiDung, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Bao(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            TaiDichVu();
            TaiNhapKho();
            XoaODichVu();
            XoaONhapKho();
        }

        // ================= TAB DỊCH VỤ =================

        private void TaiDichVu()
        {
            bsDichVu.DataSource = DbHelper.LayBang(
                "SELECT MaDV AS [Mã DV], TenDV AS [Tên dịch vụ], DonGia AS [Đơn giá], SoLuongTon AS [Tồn kho] " +
                "FROM DichVu ORDER BY MaDV");
            DinhDangCot(dgvDichVu, "Mã DV", null, false, 40);
            DinhDangCot(dgvDichVu, "Đơn giá", "N0", true, 0);
            DinhDangCot(dgvDichVu, "Tồn kho", "N0", true, 60);
            LocDichVu();
            // Nguồn cho ComboBox ở tab Nhập kho
            bsDichVuNhap.DataSource = DbHelper.LayBang("SELECT MaDV, TenDV FROM DichVu ORDER BY TenDV");
        }

        private void LocDichVu()
        {
            string tu = txtTimDV.Text.Trim();
            bsDichVu.Filter = tu == "" ? "" : "[Tên dịch vụ] LIKE '%" + ThoatLoc(tu) + "%'";
        }

        private void XoaODichVu()
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            nudDonGia.Value = nudDonGia.Minimum;
            txtSoLuongTon.Clear();
            err.Clear();
        }

        private void txtTimDV_TextChanged(object sender, EventArgs e)
        {
            LocDichVu();
        }

        private void bsDichVu_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsDichVu.Current as DataRowView;
            if (dong == null) return;
            txtMaDV.Text = dong["Mã DV"].ToString();
            txtTenDV.Text = dong["Tên dịch vụ"].ToString();
            nudDonGia.Value = Convert.ToDecimal(dong["Đơn giá"]);
            txtSoLuongTon.Text = dong["Tồn kho"].ToString();
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsDichVu_CurrentChanged(sender, e);
        }

        private bool KiemTenDV()
        {
            return Kiem(txtTenDV, txtTenDV.Text.Trim() == "", "Nhập tên dịch vụ");
        }

        private bool KiemDonGia()
        {
            return Kiem(nudDonGia, nudDonGia.Value <= 0, "Đơn giá phải lớn hơn 0");
        }

        private bool HopLeDV()
        {
            bool a = KiemTenDV(), b = KiemDonGia();
            return a && b;
        }

        private void txtTenDV_Validating(object sender, CancelEventArgs e) { KiemTenDV(); }
        private void nudDonGia_Validating(object sender, CancelEventArgs e) { KiemDonGia(); }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (!HopLeDV()) return;
            try
            {
                DbHelper.ThucThi("INSERT INTO DichVu (TenDV, DonGia, SoLuongTon) VALUES (@ten, @gia, 0)",
                    DbHelper.Tham("@ten", txtTenDV.Text.Trim()), DbHelper.Tham("@gia", nudDonGia.Value));
                Bao("Đã thêm dịch vụ. Dùng tab Nhập kho để nhập số lượng.");
                TaiDichVu();
                XoaODichVu();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "dịch vụ")); }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "") { Bao("Chọn dịch vụ cần sửa trong danh sách."); return; }
            if (!HopLeDV()) return;
            try
            {
                DbHelper.ThucThi("UPDATE DichVu SET TenDV = @ten, DonGia = @gia WHERE MaDV = @ma",
                    DbHelper.Tham("@ten", txtTenDV.Text.Trim()), DbHelper.Tham("@gia", nudDonGia.Value),
                    DbHelper.Tham("@ma", int.Parse(txtMaDV.Text)));
                Bao("Đã cập nhật dịch vụ.");
                TaiDichVu();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "dịch vụ")); }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text == "") { Bao("Chọn dịch vụ cần xóa trong danh sách."); return; }
            if (MessageBox.Show("Xóa dịch vụ đang chọn?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM DichVu WHERE MaDV = @ma", DbHelper.Tham("@ma", int.Parse(txtMaDV.Text)));
                TaiDichVu();
                XoaODichVu();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "Dịch vụ")); }
        }

        private void btnLamMoiDV_Click(object sender, EventArgs e)
        {
            txtTimDV.Clear();
            TaiDichVu();
            XoaODichVu();
        }

        // ================= TAB NHẬP KHO =================

        private void TaiNhapKho()
        {
            bsNhapKho.DataSource = DbHelper.LayBang(
                "SELECT n.MaNhap AS [Mã nhập], d.TenDV AS [Dịch vụ], n.SoLuong AS [Số lượng], " +
                "n.DonGiaNhap AS [Đơn giá nhập], n.NgayNhap AS [Ngày nhập], v.HoTen AS [Nhân viên] " +
                "FROM NhapKho n JOIN DichVu d ON d.MaDV = n.MaDV JOIN NhanVien v ON v.MaNV = n.MaNV " +
                "ORDER BY n.NgayNhap DESC, n.MaNhap DESC");
            DinhDangCot(dgvNhapKho, "Mã nhập", null, false, 40);
            DinhDangCot(dgvNhapKho, "Số lượng", "N0", true, 50);
            DinhDangCot(dgvNhapKho, "Đơn giá nhập", "N0", true, 0);
            DinhDangCot(dgvNhapKho, "Ngày nhập", "dd/MM/yyyy HH:mm", false, 80);
        }

        private void XoaONhapKho()
        {
            cboDichVuNhap.SelectedIndex = -1;
            nudSoLuongNhap.Value = 1;
            nudDonGiaNhap.Value = nudDonGiaNhap.Minimum;
            err.Clear();
        }

        private bool KiemDichVuNhap()
        {
            return Kiem(cboDichVuNhap, cboDichVuNhap.SelectedIndex < 0, "Chọn dịch vụ cần nhập");
        }

        private bool KiemSoLuongNhap()
        {
            return Kiem(nudSoLuongNhap, nudSoLuongNhap.Value < 1, "Số lượng phải từ 1 trở lên");
        }

        private bool KiemDonGiaNhap()
        {
            return Kiem(nudDonGiaNhap, nudDonGiaNhap.Value <= 0, "Đơn giá nhập phải lớn hơn 0");
        }

        private void cboDichVuNhap_Validating(object sender, CancelEventArgs e) { KiemDichVuNhap(); }
        private void nudSoLuongNhap_Validating(object sender, CancelEventArgs e) { KiemSoLuongNhap(); }
        private void nudDonGiaNhap_Validating(object sender, CancelEventArgs e) { KiemDonGiaNhap(); }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            bool a = KiemDichVuNhap(), b = KiemSoLuongNhap(), c = KiemDonGiaNhap();
            if (!a || !b || !c) return;

            int maDV = Convert.ToInt32(cboDichVuNhap.SelectedValue);
            int soLuong = (int)nudSoLuongNhap.Value;
            try
            {
                // Ghi phiếu nhập và cộng tồn kho trong một giao dịch
                DbHelper.ThucThiGiaoDich(new[]
                {
                    new Lenh("INSERT INTO NhapKho (MaDV, SoLuong, DonGiaNhap, MaNV) VALUES (@dv, @sl, @gia, @nv)",
                        DbHelper.Tham("@dv", maDV), DbHelper.Tham("@sl", soLuong),
                        DbHelper.Tham("@gia", nudDonGiaNhap.Value), DbHelper.Tham("@nv", PhienLamViec.MaNV)),
                    new Lenh(true, "UPDATE DichVu SET SoLuongTon = SoLuongTon + @sl WHERE MaDV = @dv",
                        DbHelper.Tham("@sl", soLuong), DbHelper.Tham("@dv", maDV))
                });
                Bao("Đã nhập kho.");
                TaiDichVu();
                TaiNhapKho();
                XoaONhapKho();
                XoaODichVu();
            }
            catch (Exception ex) { Loi("Không nhập kho được: " + ex.Message); }
        }
    }
}
