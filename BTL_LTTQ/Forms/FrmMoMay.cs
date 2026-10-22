using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Mở máy cho khách vãng lai hoặc hội viên
    public partial class FrmMoMay : Form
    {
        private readonly int _maMay;
        private decimal _giaGioApDung;

        public FrmMoMay(int maMay)
        {
            InitializeComponent();
            _maMay = maMay;
        }

        private void FrmMoMay_Load(object sender, EventArgs e)
        {
            // Thông tin máy và giá giờ của loại máy
            DataTable may = DbHelper.LayBang(
                "SELECT m.TenMay, m.TrangThai, l.GiaGio FROM May m JOIN LoaiMay l ON l.MaLoai = m.MaLoai WHERE m.MaMay = @m",
                DbHelper.Tham("@m", _maMay));
            if (may.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy máy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMo.Enabled = false;
                return;
            }
            lblTenMay.Text = may.Rows[0]["TenMay"].ToString();

            // Giá giờ áp dụng = giá loại máy x hệ số khung giờ hiện tại
            DataTable khungGio = DbHelper.LayBang("SELECT TuGio, DenGio, HeSo FROM KhungGio");
            decimal heSo = TinhTien.HeSoKhungGio(DateTime.Now.TimeOfDay, khungGio);
            _giaGioApDung = TinhTien.GiaGioApDung(Convert.ToDecimal(may.Rows[0]["GiaGio"]), heSo);
            lblGiaGio.Text = "Giá giờ áp dụng: " + _giaGioApDung.ToString("N0") + "đ/giờ (hệ số " + heSo.ToString("0.##") + ")";

            // Danh sách hội viên
            bsKhach.DataSource = DbHelper.LayBang(
                "SELECT MaKH, HoTen + ISNULL(N' - ' + SDT, N'') AS HienThi, SoDu FROM KhachHang ORDER BY HoTen");
            cboHoiVien.DataSource = bsKhach;
            cboHoiVien.DisplayMember = "HienThi";
            cboHoiVien.ValueMember = "MaKH";
            CapNhatSoDu();

            if (may.Rows[0]["TrangThai"].ToString() != "Trong")
            {
                MessageBox.Show("Máy này không ở trạng thái trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnMo.Enabled = false;
            }
        }

        private void CapNhatSoDu()
        {
            var dong = bsKhach.Current as DataRowView;
            if (rdoHoiVien.Checked && dong != null)
                lblSoDu.Text = "Số dư: " + Convert.ToDecimal(dong["SoDu"]).ToString("N0") + "đ";
            else
                lblSoDu.Text = "Số dư: –";
        }

        private void rdoHoiVien_CheckedChanged(object sender, EventArgs e)
        {
            cboHoiVien.Enabled = rdoHoiVien.Checked;
            CapNhatSoDu();
        }

        private void cboHoiVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatSoDu();
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            if (!PhienLamViec.CoCaMo)
            {
                MessageBox.Show("Chưa có ca làm việc đang mở. Hãy mở ca trước.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object maKH = null;
            if (rdoHoiVien.Checked)
            {
                if (cboHoiVien.SelectedValue == null)
                {
                    MessageBox.Show("Hãy chọn hội viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                maKH = Convert.ToInt32(cboHoiVien.SelectedValue);
                // Mỗi hội viên chỉ chơi một máy tại một thời điểm
                int dangChoi = Convert.ToInt32(DbHelper.LayGiaTri(
                    "SELECT COUNT(*) FROM PhienChoi WHERE MaKH = @kh AND TrangThai = N'DangChoi'",
                    DbHelper.Tham("@kh", maKH)));
                if (dangChoi > 0)
                {
                    MessageBox.Show("Hội viên này đang chơi ở một máy khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Một giao dịch: đổi trạng thái máy (chỉ khi còn Trống) và tạo phiên chơi
            var cacLenh = new List<Lenh>
            {
                new Lenh(true, "UPDATE May SET TrangThai = N'DangChoi' WHERE MaMay = @m AND TrangThai = N'Trong'",
                    DbHelper.Tham("@m", _maMay)),
                new Lenh("INSERT INTO PhienChoi (MaMay, MaKH, MaNV, MaCa, GioBatDau, GiaGioApDung, TrangThai) " +
                    "VALUES (@m, @kh, @nv, @ca, GETDATE(), @gia, N'DangChoi')",
                    DbHelper.Tham("@m", _maMay), DbHelper.Tham("@kh", maKH), DbHelper.Tham("@nv", PhienLamViec.MaNV),
                    DbHelper.Tham("@ca", PhienLamViec.MaCa), DbHelper.Tham("@gia", _giaGioApDung))
            };
            try
            {
                DbHelper.ThucThiGiaoDich(cacLenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không mở được máy: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
