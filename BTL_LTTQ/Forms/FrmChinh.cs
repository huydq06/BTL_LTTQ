using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Form chính: sơ đồ máy, menu, thanh trạng thái
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void FrmChinh_Load(object sender, EventArgs e)
        {
            // Phân quyền: chỉ Admin thấy các mục quản trị
            bool admin = PhienLamViec.LaAdmin;
            mnuMay.Visible = admin;
            mnuDichVu.Visible = admin;
            mnuNhanVien.Visible = admin;
            mnuBaoCao.Visible = admin;

            CapNhatThanhTrangThai();
            TaiSoDoMay();
        }

        // Cập nhật thanh trạng thái (nhân viên, ca, giờ)
        private void CapNhatThanhTrangThai()
        {
            tslNhanVien.Text = "Nhân viên: " + PhienLamViec.HoTen + " (" + PhienLamViec.VaiTro + ")";
            tslCa.Text = PhienLamViec.CoCaMo ? "Ca: #" + PhienLamViec.MaCa.Value : "Ca: chưa mở";
            tslGio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        // Vẽ lại sơ đồ máy: mỗi máy một Button (Tag = MaMay)
        private void TaiSoDoMay()
        {
            DataTable bang = DbHelper.LayBang(
                "SELECT m.MaMay, m.TenMay, m.TrangThai, p.GioBatDau, p.GiaGioApDung " +
                "FROM May m LEFT JOIN PhienChoi p ON p.MaMay = m.MaMay AND p.TrangThai = N'DangChoi' " +
                "ORDER BY m.MaMay");

            flpMay.SuspendLayout();
            // Giải phóng các nút cũ
            for (int i = flpMay.Controls.Count - 1; i >= 0; i--)
            {
                Control c = flpMay.Controls[i];
                flpMay.Controls.RemoveAt(i);
                c.Dispose();
            }

            foreach (DataRow r in bang.Rows)
            {
                string trangThai = r["TrangThai"].ToString();
                var btn = new Button();
                btn.Size = new Size(180, 150);
                btn.Margin = new Padding(8);
                btn.Tag = Convert.ToInt32(r["MaMay"]);
                btn.UseVisualStyleBackColor = false;
                // Giao diện nút máy theo chủ đề Cyber
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.ImageAlign = ContentAlignment.TopCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.TextImageRelation = TextImageRelation.ImageAboveText;
                btn.Padding = new Padding(0, 8, 0, 8);

                string text = r["TenMay"].ToString() + "\r\n";
                if (trangThai == "Trong")
                {
                    btn.BackColor = Color.FromArgb(34, 197, 94);
                    btn.Image = Properties.Resources.may_trong;
                    text += "Trống";
                }
                else if (trangThai == "DangChoi")
                {
                    btn.BackColor = Color.FromArgb(245, 158, 11);
                    btn.Image = Properties.Resources.may_dangchoi;
                    text += "Đang chơi";
                    if (r["GioBatDau"] != DBNull.Value)
                    {
                        DateTime batDau = Convert.ToDateTime(r["GioBatDau"]);
                        TimeSpan ts = DateTime.Now - batDau;
                        decimal tam = TinhTien.TienGio(batDau, DateTime.Now, Convert.ToDecimal(r["GiaGioApDung"]));
                        text += "\r\n" + string.Format("{0:00}:{1:00}", (int)ts.TotalHours, ts.Minutes)
                              + "\r\n" + tam.ToString("N0") + "đ";
                    }
                }
                else
                {
                    btn.BackColor = Color.FromArgb(75, 85, 99);
                    btn.Image = Properties.Resources.may_baotri;
                    text += "Bảo trì";
                }
                btn.Text = text;
                btn.FlatAppearance.MouseOverBackColor = ControlPaint.Light(btn.BackColor, 0.25f);

                // Nút tạo bằng code nên gắn Click bằng code
                btn.Click += btnMay_Click;
                flpMay.Controls.Add(btn);
            }
            flpMay.ResumeLayout();
        }

        // Bấm vào một máy
        private void btnMay_Click(object sender, EventArgs e)
        {
            int maMay = (int)((Button)sender).Tag;
            // Đọc lại trạng thái mới nhất từ CSDL
            DataTable bang = DbHelper.LayBang("SELECT TrangThai FROM May WHERE MaMay = @m", DbHelper.Tham("@m", maMay));
            if (bang.Rows.Count == 0) { TaiSoDoMay(); return; }
            string trangThai = bang.Rows[0]["TrangThai"].ToString();

            if (trangThai == "Trong")
            {
                if (!PhienLamViec.CoCaMo)
                {
                    MessageBox.Show("Chưa có ca làm việc đang mở. Hãy mở ca trước (menu Vận hành > Ca làm việc).",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                using (var f = new FrmMoMay(maMay)) f.ShowDialog();
            }
            else if (trangThai == "DangChoi")
            {
                object maPhien = DbHelper.LayGiaTri(
                    "SELECT TOP 1 MaPhien FROM PhienChoi WHERE MaMay = @m AND TrangThai = N'DangChoi' ORDER BY MaPhien DESC",
                    DbHelper.Tham("@m", maMay));
                if (maPhien != null)
                {
                    using (var f = new FrmPhienChoi(Convert.ToInt32(maPhien))) f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Máy đang bảo trì, không thể sử dụng.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CapNhatThanhTrangThai();
            TaiSoDoMay();
        }

        private void tmrLamMoi_Tick(object sender, EventArgs e)
        {
            CapNhatThanhTrangThai();
            TaiSoDoMay();
        }

        // Mở một form dạng hộp thoại rồi làm mới sơ đồ
        private void MoHopThoai(Form f)
        {
            using (f) f.ShowDialog();
            CapNhatThanhTrangThai();
            TaiSoDoMay();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmDoiMatKhau());
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            PhienLamViec.DangXuat();
            Application.Restart();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuCaLam_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmCaLam());
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmKhachHang());
        }

        private void mnuMay_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmMay());
        }

        private void mnuDichVu_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmDichVu());
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmNhanVien());
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            MoHopThoai(new FrmThongKe());
        }
    }
}
