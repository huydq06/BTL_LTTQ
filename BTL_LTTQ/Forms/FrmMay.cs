using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Quản lý máy, loại máy & giá giờ, khung giờ (Admin)
    public partial class FrmMay : Form
    {
        public FrmMay()
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

        // Dịch lỗi SQL thường gặp thành thông báo dễ hiểu
        private static string LoiSql(Exception ex, string doiTuong)
        {
            var sql = ex as SqlException;
            if (sql != null && sql.Number == 547) return doiTuong + " đang được sử dụng, không thể xóa.";
            if (sql != null && (sql.Number == 2627 || sql.Number == 2601)) return "Tên " + doiTuong + " đã tồn tại.";
            return "Thao tác thất bại: " + ex.Message;
        }

        private static bool XacNhanXoa(string doiTuong)
        {
            return MessageBox.Show("Xóa " + doiTuong + " đang chọn?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private static void Loi(string noiDung)
        {
            MessageBox.Show(noiDung, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void Bao(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmMay_Load(object sender, EventArgs e)
        {
            TaiLoaiMay();   // nạp loại máy trước vì ComboBox của tab Máy dùng
            TaiMay();
            TaiKhungGio();
            XoaOMay();
            XoaOLoai();
            XoaOKhung();
        }

        // ================= TAB MÁY =================

        private void TaiMay()
        {
            bsMay.DataSource = DbHelper.LayBang(
                "SELECT m.MaMay AS [Mã máy], m.TenMay AS [Tên máy], l.TenLoai AS [Loại máy], " +
                "m.TrangThai AS [Trạng thái], m.MaLoai FROM May m JOIN LoaiMay l ON l.MaLoai = m.MaLoai ORDER BY m.MaMay");
            dgvMay.Columns["MaLoai"].Visible = false;
            DinhDangCot(dgvMay, "Mã máy", null, false, 40);
            LocMay();
        }

        private void LocMay()
        {
            string tu = txtTimMay.Text.Trim();
            bsMay.Filter = tu == "" ? "" : "[Tên máy] LIKE '%" + ThoatLoc(tu) + "%'";
        }

        private void XoaOMay()
        {
            txtMaMay.Clear();
            txtTenMay.Clear();
            cboLoaiMay.SelectedIndex = -1;
            cboTrangThaiMay.SelectedIndex = 0;
            err.Clear();
        }

        private void txtTimMay_TextChanged(object sender, EventArgs e)
        {
            LocMay();
        }

        private void bsMay_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsMay.Current as DataRowView;
            if (dong == null) return;
            txtMaMay.Text = dong["Mã máy"].ToString();
            txtTenMay.Text = dong["Tên máy"].ToString();
            cboLoaiMay.SelectedValue = dong["MaLoai"];
            cboTrangThaiMay.SelectedItem = dong["Trạng thái"].ToString();
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsMay_CurrentChanged(sender, e);
        }

        private bool KiemTenMay()
        {
            return Kiem(txtTenMay, txtTenMay.Text.Trim() == "", "Nhập tên máy");
        }

        private bool KiemLoaiMay()
        {
            return Kiem(cboLoaiMay, cboLoaiMay.SelectedIndex < 0, "Chọn loại máy");
        }

        private bool KiemTrangThaiMay()
        {
            return Kiem(cboTrangThaiMay, cboTrangThaiMay.SelectedIndex < 0, "Chọn trạng thái");
        }

        private bool HopLeMay()
        {
            bool a = KiemTenMay(), b = KiemLoaiMay(), c = KiemTrangThaiMay();
            return a && b && c;
        }

        private void txtTenMay_Validating(object sender, CancelEventArgs e) { KiemTenMay(); }
        private void cboLoaiMay_Validating(object sender, CancelEventArgs e) { KiemLoaiMay(); }
        private void cboTrangThaiMay_Validating(object sender, CancelEventArgs e) { KiemTrangThaiMay(); }

        private void btnThemMay_Click(object sender, EventArgs e)
        {
            if (!HopLeMay()) return;
            if (cboTrangThaiMay.SelectedItem.ToString() == "DangChoi")
            {
                Loi("Máy mới chỉ được ở trạng thái Trong hoặc BaoTri.");
                return;
            }
            try
            {
                DbHelper.ThucThi("INSERT INTO May (TenMay, MaLoai, TrangThai) VALUES (@ten, @loai, @tt)",
                    DbHelper.Tham("@ten", txtTenMay.Text.Trim()),
                    DbHelper.Tham("@loai", cboLoaiMay.SelectedValue),
                    DbHelper.Tham("@tt", cboTrangThaiMay.SelectedItem.ToString()));
                Bao("Đã thêm máy.");
                TaiMay();
                XoaOMay();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "máy")); }
        }

        private void btnSuaMay_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text == "") { Bao("Chọn máy cần sửa trong danh sách."); return; }
            if (!HopLeMay()) return;
            try
            {
                // Trạng thái "DangChoi" chỉ do mở máy / thanh toán thay đổi, không sửa tay
                string ttCu = Convert.ToString(DbHelper.LayGiaTri("SELECT TrangThai FROM May WHERE MaMay = @ma",
                    DbHelper.Tham("@ma", int.Parse(txtMaMay.Text))));
                string ttMoi = cboTrangThaiMay.SelectedItem.ToString();
                if (ttCu != ttMoi && (ttCu == "DangChoi" || ttMoi == "DangChoi"))
                {
                    Loi("Không thể đổi trạng thái \"DangChoi\" bằng tay. Hãy mở máy hoặc thanh toán ở sơ đồ máy.");
                    return;
                }
                DbHelper.ThucThi("UPDATE May SET TenMay = @ten, MaLoai = @loai, TrangThai = @tt WHERE MaMay = @ma",
                    DbHelper.Tham("@ten", txtTenMay.Text.Trim()),
                    DbHelper.Tham("@loai", cboLoaiMay.SelectedValue),
                    DbHelper.Tham("@tt", cboTrangThaiMay.SelectedItem.ToString()),
                    DbHelper.Tham("@ma", int.Parse(txtMaMay.Text)));
                Bao("Đã cập nhật máy.");
                TaiMay();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "máy")); }
        }

        private void btnXoaMay_Click(object sender, EventArgs e)
        {
            if (txtMaMay.Text == "") { Bao("Chọn máy cần xóa trong danh sách."); return; }
            if (!XacNhanXoa("máy")) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM May WHERE MaMay = @ma", DbHelper.Tham("@ma", int.Parse(txtMaMay.Text)));
                TaiMay();
                XoaOMay();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "Máy")); }
        }

        private void btnLamMoiMay_Click(object sender, EventArgs e)
        {
            txtTimMay.Clear();
            TaiLoaiMay();
            TaiMay();
            XoaOMay();
        }

        // ================= TAB LOẠI MÁY =================

        private void TaiLoaiMay()
        {
            DataTable bang = DbHelper.LayBang(
                "SELECT MaLoai AS [Mã loại], TenLoai AS [Tên loại], GiaGio AS [Giá giờ] FROM LoaiMay ORDER BY MaLoai");
            bsLoaiMay.DataSource = bang;
            DinhDangCot(dgvLoaiMay, "Mã loại", null, false, 40);
            DinhDangCot(dgvLoaiMay, "Giá giờ", "N0", true, 0);
            // Nguồn riêng cho ComboBox loại máy ở tab Máy
            bsLoaiMayCbo.DataSource = DbHelper.LayBang("SELECT MaLoai, TenLoai FROM LoaiMay ORDER BY MaLoai");
        }

        private void XoaOLoai()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            nudGiaGio.Value = nudGiaGio.Minimum;
            err.Clear();
        }

        private void bsLoaiMay_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsLoaiMay.Current as DataRowView;
            if (dong == null) return;
            txtMaLoai.Text = dong["Mã loại"].ToString();
            txtTenLoai.Text = dong["Tên loại"].ToString();
            nudGiaGio.Value = Convert.ToDecimal(dong["Giá giờ"]);
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvLoaiMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsLoaiMay_CurrentChanged(sender, e);
        }

        private bool KiemTenLoai()
        {
            return Kiem(txtTenLoai, txtTenLoai.Text.Trim() == "", "Nhập tên loại máy");
        }

        private bool KiemGiaGio()
        {
            return Kiem(nudGiaGio, nudGiaGio.Value <= 0, "Giá giờ phải lớn hơn 0");
        }

        private bool HopLeLoai()
        {
            bool a = KiemTenLoai(), b = KiemGiaGio();
            return a && b;
        }

        private void txtTenLoai_Validating(object sender, CancelEventArgs e) { KiemTenLoai(); }
        private void nudGiaGio_Validating(object sender, CancelEventArgs e) { KiemGiaGio(); }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            if (!HopLeLoai()) return;
            try
            {
                DbHelper.ThucThi("INSERT INTO LoaiMay (TenLoai, GiaGio) VALUES (@ten, @gia)",
                    DbHelper.Tham("@ten", txtTenLoai.Text.Trim()), DbHelper.Tham("@gia", nudGiaGio.Value));
                Bao("Đã thêm loại máy.");
                TaiLoaiMay();
                XoaOLoai();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "loại máy")); }
        }

        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "") { Bao("Chọn loại máy cần sửa trong danh sách."); return; }
            if (!HopLeLoai()) return;
            try
            {
                DbHelper.ThucThi("UPDATE LoaiMay SET TenLoai = @ten, GiaGio = @gia WHERE MaLoai = @ma",
                    DbHelper.Tham("@ten", txtTenLoai.Text.Trim()), DbHelper.Tham("@gia", nudGiaGio.Value),
                    DbHelper.Tham("@ma", int.Parse(txtMaLoai.Text)));
                Bao("Đã cập nhật loại máy.");
                TaiLoaiMay();
                TaiMay();   // tên loại hiển thị ở tab Máy
            }
            catch (Exception ex) { Loi(LoiSql(ex, "loại máy")); }
        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == "") { Bao("Chọn loại máy cần xóa trong danh sách."); return; }
            if (!XacNhanXoa("loại máy")) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM LoaiMay WHERE MaLoai = @ma", DbHelper.Tham("@ma", int.Parse(txtMaLoai.Text)));
                TaiLoaiMay();
                XoaOLoai();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "Loại máy")); }
        }

        private void btnLamMoiLoai_Click(object sender, EventArgs e)
        {
            TaiLoaiMay();
            XoaOLoai();
        }

        // ================= TAB KHUNG GIỜ =================

        private void TaiKhungGio()
        {
            bsKhungGio.DataSource = DbHelper.LayBang(
                "SELECT MaKhung AS [Mã khung], TenKhung AS [Tên khung], " +
                "CONVERT(VARCHAR(5), TuGio, 108) AS [Từ giờ], CONVERT(VARCHAR(5), DenGio, 108) AS [Đến giờ], " +
                "HeSo AS [Hệ số] FROM KhungGio ORDER BY MaKhung");
            DinhDangCot(dgvKhungGio, "Mã khung", null, false, 40);
            DinhDangCot(dgvKhungGio, "Hệ số", "N2", true, 50);
        }

        private void XoaOKhung()
        {
            txtMaKhung.Clear();
            txtTenKhung.Clear();
            dtpTuGio.Value = DateTime.Today;
            dtpDenGio.Value = DateTime.Today;
            nudHeSo.Value = 1;
            err.Clear();
        }

        // Chuỗi "HH:mm" -> DateTime của hôm nay (để gán cho DateTimePicker)
        private static DateTime GioSangNgay(string hhmm)
        {
            return DateTime.Today.Add(TimeSpan.Parse(hhmm));
        }

        private void bsKhungGio_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsKhungGio.Current as DataRowView;
            if (dong == null) return;
            txtMaKhung.Text = dong["Mã khung"].ToString();
            txtTenKhung.Text = dong["Tên khung"].ToString();
            dtpTuGio.Value = GioSangNgay(dong["Từ giờ"].ToString());
            dtpDenGio.Value = GioSangNgay(dong["Đến giờ"].ToString());
            nudHeSo.Value = Convert.ToDecimal(dong["Hệ số"]);
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvKhungGio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsKhungGio_CurrentChanged(sender, e);
        }

        private bool KiemTenKhung()
        {
            return Kiem(txtTenKhung, txtTenKhung.Text.Trim() == "", "Nhập tên khung giờ");
        }

        // Khung qua đêm (Từ > Đến) được phép; chỉ cấm Từ = Đến
        private bool KiemDenGio()
        {
            return Kiem(dtpDenGio, dtpTuGio.Value.TimeOfDay == dtpDenGio.Value.TimeOfDay, "Giờ bắt đầu và kết thúc không được trùng nhau");
        }

        private bool HopLeKhung()
        {
            bool a = KiemTenKhung(), b = KiemDenGio();
            return a && b;
        }

        private void txtTenKhung_Validating(object sender, CancelEventArgs e) { KiemTenKhung(); }
        private void dtpDenGio_Validating(object sender, CancelEventArgs e) { KiemDenGio(); }

        private void btnThemKhung_Click(object sender, EventArgs e)
        {
            if (!HopLeKhung()) return;
            try
            {
                DbHelper.ThucThi("INSERT INTO KhungGio (TenKhung, TuGio, DenGio, HeSo) VALUES (@ten, @tu, @den, @hs)",
                    DbHelper.Tham("@ten", txtTenKhung.Text.Trim()),
                    DbHelper.Tham("@tu", dtpTuGio.Value.TimeOfDay),
                    DbHelper.Tham("@den", dtpDenGio.Value.TimeOfDay),
                    DbHelper.Tham("@hs", nudHeSo.Value));
                Bao("Đã thêm khung giờ.");
                TaiKhungGio();
                XoaOKhung();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "khung giờ")); }
        }

        private void btnSuaKhung_Click(object sender, EventArgs e)
        {
            if (txtMaKhung.Text == "") { Bao("Chọn khung giờ cần sửa trong danh sách."); return; }
            if (!HopLeKhung()) return;
            try
            {
                DbHelper.ThucThi("UPDATE KhungGio SET TenKhung = @ten, TuGio = @tu, DenGio = @den, HeSo = @hs WHERE MaKhung = @ma",
                    DbHelper.Tham("@ten", txtTenKhung.Text.Trim()),
                    DbHelper.Tham("@tu", dtpTuGio.Value.TimeOfDay),
                    DbHelper.Tham("@den", dtpDenGio.Value.TimeOfDay),
                    DbHelper.Tham("@hs", nudHeSo.Value),
                    DbHelper.Tham("@ma", int.Parse(txtMaKhung.Text)));
                Bao("Đã cập nhật khung giờ.");
                TaiKhungGio();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "khung giờ")); }
        }

        private void btnXoaKhung_Click(object sender, EventArgs e)
        {
            if (txtMaKhung.Text == "") { Bao("Chọn khung giờ cần xóa trong danh sách."); return; }
            if (!XacNhanXoa("khung giờ")) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM KhungGio WHERE MaKhung = @ma", DbHelper.Tham("@ma", int.Parse(txtMaKhung.Text)));
                TaiKhungGio();
                XoaOKhung();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "Khung giờ")); }
        }

        private void btnLamMoiKhung_Click(object sender, EventArgs e)
        {
            TaiKhungGio();
            XoaOKhung();
        }
    }
}
