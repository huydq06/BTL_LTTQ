using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Quản lý nhân viên, đặt lại mật khẩu (Admin)
    public partial class FrmNhanVien : Form
    {
        private const int DoDaiMatKhauToiThieu = 6;

        public FrmNhanVien()
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

        private static string LoiSql(Exception ex)
        {
            var sql = ex as SqlException;
            if (sql != null && sql.Number == 547)
                return "Nhân viên đã có dữ liệu (ca làm, phiên chơi...) nên không thể xóa. Hãy bỏ chọn \"Đang làm việc\" để khóa tài khoản.";
            if (sql != null && (sql.Number == 2627 || sql.Number == 2601)) return "Tên đăng nhập đã tồn tại.";
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

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            TaiNhanVien();
            XoaONhap();
        }

        private void TaiNhanVien()
        {
            bsNhanVien.DataSource = DbHelper.LayBang(
                "SELECT MaNV AS [Mã NV], TenDangNhap AS [Tên đăng nhập], HoTen AS [Họ tên], " +
                "VaiTro AS [Vai trò], TrangThai AS [Đang làm] FROM NhanVien ORDER BY MaNV");
            DinhDangCot(dgvNhanVien, "Mã NV", null, false, 40);
            DinhDangCot(dgvNhanVien, "Đang làm", null, false, 50);
            LocNhanVien();
        }

        private void LocNhanVien()
        {
            string tu = ThoatLoc(txtTimNV.Text.Trim());
            bsNhanVien.Filter = tu == "" ? "" : "[Tên đăng nhập] LIKE '%" + tu + "%' OR [Họ tên] LIKE '%" + tu + "%'";
        }

        private void XoaONhap()
        {
            txtMaNV.Clear();
            txtTenDangNhap.Clear();
            txtHoTen.Clear();
            cboVaiTro.SelectedIndex = 1;   // mặc định NhanVien
            chkTrangThai.Checked = true;
            txtMatKhau.Clear();
            err.Clear();
        }

        private void txtTimNV_TextChanged(object sender, EventArgs e)
        {
            LocNhanVien();
        }

        private void bsNhanVien_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsNhanVien.Current as DataRowView;
            if (dong == null) return;
            txtMaNV.Text = dong["Mã NV"].ToString();
            txtTenDangNhap.Text = dong["Tên đăng nhập"].ToString();
            txtHoTen.Text = dong["Họ tên"].ToString();
            cboVaiTro.SelectedItem = dong["Vai trò"].ToString();
            chkTrangThai.Checked = Convert.ToBoolean(dong["Đang làm"]);
            txtMatKhau.Clear();
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsNhanVien_CurrentChanged(sender, e);
        }

        // ===== Kiểm tra nhập =====

        private bool KiemTenDangNhap()
        {
            string s = txtTenDangNhap.Text.Trim();
            if (!Kiem(txtTenDangNhap, s == "", "Nhập tên đăng nhập")) return false;
            return Kiem(txtTenDangNhap, s.Contains(" "), "Tên đăng nhập không được chứa khoảng trắng");
        }

        private bool KiemHoTen()
        {
            return Kiem(txtHoTen, txtHoTen.Text.Trim() == "", "Nhập họ tên");
        }

        private bool KiemVaiTro()
        {
            return Kiem(cboVaiTro, cboVaiTro.SelectedIndex < 0, "Chọn vai trò");
        }

        // Mật khẩu có thể để trống (khi Sửa); nếu nhập thì phải đủ độ dài
        private bool KiemMatKhau()
        {
            string s = txtMatKhau.Text;
            return Kiem(txtMatKhau, s != "" && s.Length < DoDaiMatKhauToiThieu,
                "Mật khẩu tối thiểu " + DoDaiMatKhauToiThieu + " ký tự");
        }

        private bool HopLeThongTin()
        {
            bool a = KiemTenDangNhap(), b = KiemHoTen(), c = KiemVaiTro(), d = KiemMatKhau();
            return a && b && c && d;
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e) { KiemTenDangNhap(); }
        private void txtHoTen_Validating(object sender, CancelEventArgs e) { KiemHoTen(); }
        private void cboVaiTro_Validating(object sender, CancelEventArgs e) { KiemVaiTro(); }
        private void txtMatKhau_Validating(object sender, CancelEventArgs e) { KiemMatKhau(); }

        // ===== Nút chức năng =====

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (!HopLeThongTin()) return;
            if (!Kiem(txtMatKhau, txtMatKhau.Text == "", "Nhập mật khẩu cho nhân viên mới")) return;
            try
            {
                DbHelper.ThucThi(
                    "INSERT INTO NhanVien (TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai) VALUES (@tdn, @mk, @ten, @vt, @tt)",
                    DbHelper.Tham("@tdn", txtTenDangNhap.Text.Trim()),
                    DbHelper.Tham("@mk", BaoMat.Bam(txtMatKhau.Text)),
                    DbHelper.Tham("@ten", txtHoTen.Text.Trim()),
                    DbHelper.Tham("@vt", cboVaiTro.SelectedItem.ToString()),
                    DbHelper.Tham("@tt", chkTrangThai.Checked));
                Bao("Đã thêm nhân viên.");
                TaiNhanVien();
                XoaONhap();
            }
            catch (Exception ex) { Loi(LoiSql(ex)); }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") { Bao("Chọn nhân viên cần sửa trong danh sách."); return; }
            if (!HopLeThongTin()) return;
            int maNV = int.Parse(txtMaNV.Text);

            // Không để Admin tự hạ quyền hoặc tự khóa chính mình
            if (maNV == PhienLamViec.MaNV && (cboVaiTro.SelectedItem.ToString() != "Admin" || !chkTrangThai.Checked))
            {
                Loi("Không thể tự hạ quyền hoặc tự khóa tài khoản đang đăng nhập.");
                return;
            }
            try
            {
                DbHelper.ThucThi(
                    "UPDATE NhanVien SET TenDangNhap = @tdn, HoTen = @ten, VaiTro = @vt, TrangThai = @tt WHERE MaNV = @ma",
                    DbHelper.Tham("@tdn", txtTenDangNhap.Text.Trim()),
                    DbHelper.Tham("@ten", txtHoTen.Text.Trim()),
                    DbHelper.Tham("@vt", cboVaiTro.SelectedItem.ToString()),
                    DbHelper.Tham("@tt", chkTrangThai.Checked),
                    DbHelper.Tham("@ma", maNV));
                Bao("Đã cập nhật nhân viên.");
                TaiNhanVien();
            }
            catch (Exception ex) { Loi(LoiSql(ex)); }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") { Bao("Chọn nhân viên cần xóa trong danh sách."); return; }
            int maNV = int.Parse(txtMaNV.Text);
            if (maNV == PhienLamViec.MaNV) { Loi("Không thể xóa tài khoản đang đăng nhập."); return; }
            if (MessageBox.Show("Xóa nhân viên đang chọn?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM NhanVien WHERE MaNV = @ma", DbHelper.Tham("@ma", maNV));
                TaiNhanVien();
                XoaONhap();
            }
            catch (Exception ex) { Loi(LoiSql(ex)); }
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "") { Bao("Chọn nhân viên cần đặt lại mật khẩu."); return; }
            if (!Kiem(txtMatKhau, txtMatKhau.Text.Length < DoDaiMatKhauToiThieu,
                "Nhập mật khẩu mới (tối thiểu " + DoDaiMatKhauToiThieu + " ký tự)")) return;
            try
            {
                DbHelper.ThucThi("UPDATE NhanVien SET MatKhau = @mk WHERE MaNV = @ma",
                    DbHelper.Tham("@mk", BaoMat.Bam(txtMatKhau.Text)),
                    DbHelper.Tham("@ma", int.Parse(txtMaNV.Text)));
                Bao("Đã đặt lại mật khẩu.");
                txtMatKhau.Clear();
            }
            catch (Exception ex) { Loi(LoiSql(ex)); }
        }

        private void btnLamMoiNV_Click(object sender, EventArgs e)
        {
            txtTimNV.Clear();
            TaiNhanVien();
            XoaONhap();
        }
    }
}
