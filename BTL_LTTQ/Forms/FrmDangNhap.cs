using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Đăng nhập: so khớp mật khẩu băm + trạng thái tài khoản, rồi gán PhienLamViec
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        // Báo lỗi lên ErrorProvider; trả về true nếu hợp lệ
        private bool Kiem(Control c, bool loi, string thongBao)
        {
            err.SetError(c, loi ? thongBao : "");
            return !loi;
        }

        private bool KiemTenDangNhap()
        {
            return Kiem(txtTenDangNhap, txtTenDangNhap.Text.Trim() == "", "Nhập tên đăng nhập");
        }

        private bool KiemMatKhau()
        {
            return Kiem(txtMatKhau, txtMatKhau.Text == "", "Nhập mật khẩu");
        }

        private void txtTenDangNhap_Validating(object sender, CancelEventArgs e)
        {
            KiemTenDangNhap();
        }

        private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        {
            KiemMatKhau();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool a = KiemTenDangNhap();
            bool b = KiemMatKhau();
            if (!a || !b) return;

            try
            {
                DataTable bang = DbHelper.LayBang(
                    "SELECT MaNV, MatKhau, HoTen, VaiTro, TrangThai FROM NhanVien WHERE TenDangNhap = @ten",
                    DbHelper.Tham("@ten", txtTenDangNhap.Text.Trim()));

                if (bang.Rows.Count == 0 || !BaoMat.KhopMatKhau(txtMatKhau.Text, bang.Rows[0]["MatKhau"].ToString()))
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                DataRow dong = bang.Rows[0];
                if (!Convert.ToBoolean(dong["TrangThai"]))
                {
                    MessageBox.Show("Tài khoản đã bị khóa.", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gán thông tin phiên làm việc
                PhienLamViec.MaNV = Convert.ToInt32(dong["MaNV"]);
                PhienLamViec.HoTen = dong["HoTen"].ToString();
                PhienLamViec.VaiTro = dong["VaiTro"].ToString();

                // Chỉ có tối đa một ca đang mở tại một thời điểm
                object maCa = DbHelper.LayGiaTri("SELECT TOP 1 MaCa FROM CaLam WHERE TrangThai = N'Mo' ORDER BY MaCa DESC");
                PhienLamViec.MaCa = maCa == null ? (int?)null : Convert.ToInt32(maCa);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đăng nhập được: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
