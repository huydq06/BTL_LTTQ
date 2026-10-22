using System;
using System.ComponentModel;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Đổi mật khẩu của nhân viên đang đăng nhập
    public partial class FrmDoiMatKhau : Form
    {
        private const int DoDaiToiThieu = 6;

        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        private bool Kiem(Control c, bool loi, string thongBao)
        {
            err.SetError(c, loi ? thongBao : "");
            return !loi;
        }

        private bool KiemMatKhauCu()
        {
            return Kiem(txtMatKhauCu, txtMatKhauCu.Text == "", "Nhập mật khẩu hiện tại");
        }

        private bool KiemMatKhauMoi()
        {
            if (!Kiem(txtMatKhauMoi, txtMatKhauMoi.Text.Length < DoDaiToiThieu,
                "Mật khẩu mới tối thiểu " + DoDaiToiThieu + " ký tự")) return false;
            return Kiem(txtMatKhauMoi, txtMatKhauMoi.Text == txtMatKhauCu.Text, "Mật khẩu mới phải khác mật khẩu cũ");
        }

        private bool KiemXacNhan()
        {
            return Kiem(txtXacNhan, txtXacNhan.Text != txtMatKhauMoi.Text, "Nhập lại không khớp mật khẩu mới");
        }

        private void txtMatKhauCu_Validating(object sender, CancelEventArgs e)
        {
            KiemMatKhauCu();
        }

        private void txtMatKhauMoi_Validating(object sender, CancelEventArgs e)
        {
            KiemMatKhauMoi();
        }

        private void txtXacNhan_Validating(object sender, CancelEventArgs e)
        {
            KiemXacNhan();
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            bool a = KiemMatKhauCu();
            bool b = KiemMatKhauMoi();
            bool c = KiemXacNhan();
            if (!a || !b || !c) return;

            try
            {
                object daLuu = DbHelper.LayGiaTri("SELECT MatKhau FROM NhanVien WHERE MaNV = @ma",
                    DbHelper.Tham("@ma", PhienLamViec.MaNV));
                if (daLuu == null || !BaoMat.KhopMatKhau(txtMatKhauCu.Text, daLuu.ToString()))
                {
                    err.SetError(txtMatKhauCu, "Mật khẩu hiện tại không đúng");
                    return;
                }

                DbHelper.ThucThi("UPDATE NhanVien SET MatKhau = @mk WHERE MaNV = @ma",
                    DbHelper.Tham("@mk", BaoMat.Bam(txtMatKhauMoi.Text)),
                    DbHelper.Tham("@ma", PhienLamViec.MaNV));
                MessageBox.Show("Đổi mật khẩu thành công.", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không đổi được mật khẩu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
