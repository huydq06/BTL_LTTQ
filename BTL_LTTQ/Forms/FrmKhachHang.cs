using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Quản lý khách hàng hội viên (+ nạp tiền) và hạng hội viên
    // Nhân viên: xem/thêm/sửa tên-SĐT/nạp tiền; Admin: thêm quyền đổi hạng và quản lý hạng
    public partial class FrmKhachHang : Form
    {
        public FrmKhachHang()
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

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            // Chỉ Admin được đổi hạng của khách và quản lý bảng hạng
            bool admin = PhienLamViec.LaAdmin;
            cboHang.Enabled = admin;
            btnThemHang.Enabled = admin;
            btnSuaHang.Enabled = admin;
            btnXoaHang.Enabled = admin;

            TaiHang();
            TaiKhachHang();
            XoaOKhach();
            XoaOHang();
        }

        // ================= TAB KHÁCH HÀNG =================

        private void TaiKhachHang()
        {
            bsKhachHang.DataSource = DbHelper.LayBang(
                "SELECT k.MaKH AS [Mã KH], k.HoTen AS [Họ tên], k.SDT AS [SĐT], k.SoDu AS [Số dư], " +
                "h.TenHang AS [Hạng], k.NgayDangKy AS [Ngày đăng ký], k.MaHang " +
                "FROM KhachHang k LEFT JOIN HangHoiVien h ON h.MaHang = k.MaHang ORDER BY k.MaKH");
            dgvKhachHang.Columns["MaHang"].Visible = false;
            DinhDangCot(dgvKhachHang, "Mã KH", null, false, 40);
            DinhDangCot(dgvKhachHang, "Số dư", "N0", true, 0);
            DinhDangCot(dgvKhachHang, "Ngày đăng ký", "dd/MM/yyyy HH:mm", false, 0);
            LocKhach();
        }

        private void LocKhach()
        {
            string tu = ThoatLoc(txtTimKH.Text.Trim());
            bsKhachHang.Filter = tu == "" ? "" : "[Họ tên] LIKE '%" + tu + "%' OR [SĐT] LIKE '%" + tu + "%'";
        }

        private void XoaOKhach()
        {
            txtMaKH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            cboHang.SelectedIndex = -1;
            txtSoDu.Clear();
            txtNgayDangKy.Clear();
            err.Clear();
        }

        private void txtTimKH_TextChanged(object sender, EventArgs e)
        {
            LocKhach();
        }

        private void bsKhachHang_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsKhachHang.Current as DataRowView;
            if (dong == null) return;
            txtMaKH.Text = dong["Mã KH"].ToString();
            txtHoTen.Text = dong["Họ tên"].ToString();
            txtSDT.Text = dong["SĐT"].ToString();
            if (dong["MaHang"] == DBNull.Value) cboHang.SelectedIndex = -1;
            else cboHang.SelectedValue = dong["MaHang"];
            txtSoDu.Text = Convert.ToDecimal(dong["Số dư"]).ToString("N0");
            txtNgayDangKy.Text = Convert.ToDateTime(dong["Ngày đăng ký"]).ToString("dd/MM/yyyy HH:mm");
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsKhachHang_CurrentChanged(sender, e);
        }

        private bool KiemHoTen()
        {
            return Kiem(txtHoTen, txtHoTen.Text.Trim() == "", "Nhập họ tên khách hàng");
        }

        // SĐT có thể để trống; nếu nhập thì phải là 8-15 chữ số
        private bool KiemSDT()
        {
            string s = txtSDT.Text.Trim();
            return Kiem(txtSDT, s != "" && !Regex.IsMatch(s, @"^[0-9]{8,15}$"), "Số điện thoại gồm 8-15 chữ số");
        }

        private bool KiemHang()
        {
            return Kiem(cboHang, false, "");
        }

        private bool HopLeKhach()
        {
            bool a = KiemHoTen(), b = KiemSDT();
            return a && b;
        }

        private void txtHoTen_Validating(object sender, CancelEventArgs e) { KiemHoTen(); }
        private void txtSDT_Validating(object sender, CancelEventArgs e) { KiemSDT(); }
        private void cboHang_Validating(object sender, CancelEventArgs e) { KiemHang(); }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            if (!HopLeKhach()) return;
            string sdt = txtSDT.Text.Trim();
            try
            {
                // Khách mới vào hạng thấp nhất; Admin có thể chọn hạng khác
                object maHang = (PhienLamViec.LaAdmin && cboHang.SelectedIndex >= 0)
                    ? cboHang.SelectedValue
                    : DbHelper.LayGiaTri("SELECT TOP 1 MaHang FROM HangHoiVien ORDER BY TongNapToiThieu");
                DbHelper.ThucThi("INSERT INTO KhachHang (HoTen, SDT, MaHang) VALUES (@ten, @sdt, @hang)",
                    DbHelper.Tham("@ten", txtHoTen.Text.Trim()),
                    DbHelper.Tham("@sdt", sdt == "" ? null : sdt),
                    DbHelper.Tham("@hang", maHang));
                Bao("Đã thêm khách hàng.");
                TaiKhachHang();
                XoaOKhach();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "khách hàng")); }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") { Bao("Chọn khách hàng cần sửa trong danh sách."); return; }
            if (!HopLeKhach()) return;
            string sdt = txtSDT.Text.Trim();
            try
            {
                if (PhienLamViec.LaAdmin && cboHang.SelectedIndex >= 0)
                {
                    DbHelper.ThucThi("UPDATE KhachHang SET HoTen = @ten, SDT = @sdt, MaHang = @hang WHERE MaKH = @ma",
                        DbHelper.Tham("@ten", txtHoTen.Text.Trim()),
                        DbHelper.Tham("@sdt", sdt == "" ? null : sdt),
                        DbHelper.Tham("@hang", cboHang.SelectedValue),
                        DbHelper.Tham("@ma", int.Parse(txtMaKH.Text)));
                }
                else
                {
                    DbHelper.ThucThi("UPDATE KhachHang SET HoTen = @ten, SDT = @sdt WHERE MaKH = @ma",
                        DbHelper.Tham("@ten", txtHoTen.Text.Trim()),
                        DbHelper.Tham("@sdt", sdt == "" ? null : sdt),
                        DbHelper.Tham("@ma", int.Parse(txtMaKH.Text)));
                }
                Bao("Đã cập nhật khách hàng.");
                TaiKhachHang();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "khách hàng")); }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") { Bao("Chọn khách hàng cần xóa trong danh sách."); return; }
            if (!XacNhanXoa("khách hàng")) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM KhachHang WHERE MaKH = @ma", DbHelper.Tham("@ma", int.Parse(txtMaKH.Text)));
                TaiKhachHang();
                XoaOKhach();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "Khách hàng")); }
        }

        private void btnLamMoiKH_Click(object sender, EventArgs e)
        {
            txtTimKH.Clear();
            TaiHang();
            TaiKhachHang();
            XoaOKhach();
        }

        // ----- Nạp tiền -----

        private bool KiemSoTienNap()
        {
            return Kiem(nudSoTienNap, nudSoTienNap.Value <= 0, "Số tiền nạp phải lớn hơn 0");
        }

        private void nudSoTienNap_Validating(object sender, CancelEventArgs e) { KiemSoTienNap(); }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "") { Bao("Chọn khách hàng cần nạp tiền."); return; }
            if (!KiemSoTienNap()) return;
            if (!PhienLamViec.CoCaMo)
            {
                MessageBox.Show("Chưa có ca đang mở. Hãy mở ca trước khi nạp tiền.", "Nạp tiền",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maKH = int.Parse(txtMaKH.Text);
            decimal soTien = nudSoTienNap.Value;
            if (MessageBox.Show("Nạp " + soTien.ToString("N0") + " đ cho khách \"" + txtHoTen.Text + "\"?", "Xác nhận nạp tiền",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                // Ghi phiếu nạp, cộng số dư, nâng hạng (không bao giờ hạ hạng) trong một giao dịch
                DbHelper.ThucThiGiaoDich(new[]
                {
                    new Lenh("INSERT INTO NapTien (MaKH, SoTien, MaNV, MaCa) VALUES (@kh, @tien, @nv, @ca)",
                        DbHelper.Tham("@kh", maKH), DbHelper.Tham("@tien", soTien),
                        DbHelper.Tham("@nv", PhienLamViec.MaNV), DbHelper.Tham("@ca", PhienLamViec.MaCa.Value)),
                    new Lenh(true, "UPDATE KhachHang SET SoDu = SoDu + @tien WHERE MaKH = @kh",
                        DbHelper.Tham("@tien", soTien), DbHelper.Tham("@kh", maKH)),
                    new Lenh("UPDATE k SET MaHang = h.MaHang " +
                        "FROM KhachHang k " +
                        "CROSS APPLY (SELECT TOP 1 MaHang, TongNapToiThieu FROM HangHoiVien " +
                        "             WHERE TongNapToiThieu <= (SELECT ISNULL(SUM(SoTien), 0) FROM NapTien WHERE MaKH = k.MaKH) " +
                        "             ORDER BY TongNapToiThieu DESC) h " +
                        "LEFT JOIN HangHoiVien cu ON cu.MaHang = k.MaHang " +
                        "WHERE k.MaKH = @kh AND (cu.MaHang IS NULL OR h.TongNapToiThieu > cu.TongNapToiThieu)",
                        DbHelper.Tham("@kh", maKH))
                });
                Bao("Đã nạp " + soTien.ToString("N0") + " đ.");
                TaiKhachHang();
            }
            catch (Exception ex) { Loi("Không nạp được tiền: " + ex.Message); }
        }

        // ================= TAB HẠNG HỘI VIÊN =================

        private void TaiHang()
        {
            bsHang.DataSource = DbHelper.LayBang(
                "SELECT MaHang AS [Mã hạng], TenHang AS [Tên hạng], TongNapToiThieu AS [Tổng nạp tối thiểu], " +
                "GiamGiaGio AS [Giảm giá giờ (%)] FROM HangHoiVien ORDER BY TongNapToiThieu");
            DinhDangCot(dgvHang, "Mã hạng", null, false, 40);
            DinhDangCot(dgvHang, "Tổng nạp tối thiểu", "N0", true, 0);
            DinhDangCot(dgvHang, "Giảm giá giờ (%)", "N2", true, 0);
            // Nguồn cho ComboBox hạng ở tab Khách hàng
            bsHangCbo.DataSource = DbHelper.LayBang("SELECT MaHang, TenHang FROM HangHoiVien ORDER BY TongNapToiThieu");
        }

        private void XoaOHang()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            nudTongNapToiThieu.Value = nudTongNapToiThieu.Minimum;
            nudGiamGiaGio.Value = nudGiamGiaGio.Minimum;
            err.Clear();
        }

        private void bsHang_CurrentChanged(object sender, EventArgs e)
        {
            var dong = bsHang.Current as DataRowView;
            if (dong == null) return;
            txtMaHang.Text = dong["Mã hạng"].ToString();
            txtTenHang.Text = dong["Tên hạng"].ToString();
            nudTongNapToiThieu.Value = Convert.ToDecimal(dong["Tổng nạp tối thiểu"]);
            nudGiamGiaGio.Value = Convert.ToDecimal(dong["Giảm giá giờ (%)"]);
            err.Clear();
        }

        // Bấm vào dòng (kể cả dòng đang chọn sẵn) thì đổ dữ liệu lên ô nhập
        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) bsHang_CurrentChanged(sender, e);
        }

        private bool KiemTenHang()
        {
            return Kiem(txtTenHang, txtTenHang.Text.Trim() == "", "Nhập tên hạng");
        }

        // Mỗi hạng có một mốc tổng nạp riêng, nếu không việc nâng hạng sẽ mơ hồ
        private bool KiemTongNap()
        {
            var bang = bsHang.DataSource as DataTable;
            if (bang == null) return true;
            string maHienTai = txtMaHang.Text == "" ? "0" : txtMaHang.Text;
            DataRow[] trung = bang.Select("[Tổng nạp tối thiểu] = " + ((long)nudTongNapToiThieu.Value) + " AND [Mã hạng] <> " + maHienTai);
            return Kiem(nudTongNapToiThieu, trung.Length > 0, "Đã có hạng khác dùng mốc tổng nạp này");
        }

        private bool KiemGiamGia()
        {
            return Kiem(nudGiamGiaGio, nudGiamGiaGio.Value < 0 || nudGiamGiaGio.Value > 100, "Giảm giá từ 0 đến 100%");
        }

        private bool HopLeHang()
        {
            bool a = KiemTenHang(), b = KiemTongNap(), c = KiemGiamGia();
            return a && b && c;
        }

        private void txtTenHang_Validating(object sender, CancelEventArgs e) { KiemTenHang(); }
        private void nudTongNapToiThieu_Validating(object sender, CancelEventArgs e) { KiemTongNap(); }
        private void nudGiamGiaGio_Validating(object sender, CancelEventArgs e) { KiemGiamGia(); }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            // Ô mã hạng có thể còn dữ liệu của dòng đang chọn; thêm mới coi như không có mã
            string maCu = txtMaHang.Text;
            txtMaHang.Clear();
            bool hopLe = HopLeHang();
            txtMaHang.Text = maCu;
            if (!hopLe) return;
            try
            {
                DbHelper.ThucThi("INSERT INTO HangHoiVien (TenHang, TongNapToiThieu, GiamGiaGio) VALUES (@ten, @nap, @gg)",
                    DbHelper.Tham("@ten", txtTenHang.Text.Trim()),
                    DbHelper.Tham("@nap", nudTongNapToiThieu.Value),
                    DbHelper.Tham("@gg", nudGiamGiaGio.Value));
                Bao("Đã thêm hạng hội viên.");
                TaiHang();
                XoaOHang();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "hạng")); }
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") { Bao("Chọn hạng cần sửa trong danh sách."); return; }
            if (!HopLeHang()) return;
            try
            {
                DbHelper.ThucThi("UPDATE HangHoiVien SET TenHang = @ten, TongNapToiThieu = @nap, GiamGiaGio = @gg WHERE MaHang = @ma",
                    DbHelper.Tham("@ten", txtTenHang.Text.Trim()),
                    DbHelper.Tham("@nap", nudTongNapToiThieu.Value),
                    DbHelper.Tham("@gg", nudGiamGiaGio.Value),
                    DbHelper.Tham("@ma", int.Parse(txtMaHang.Text)));
                Bao("Đã cập nhật hạng hội viên.");
                TaiHang();
                TaiKhachHang();   // tên hạng hiển thị ở tab Khách hàng
            }
            catch (Exception ex) { Loi(LoiSql(ex, "hạng")); }
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") { Bao("Chọn hạng cần xóa trong danh sách."); return; }
            if (!XacNhanXoa("hạng hội viên")) return;
            try
            {
                DbHelper.ThucThi("DELETE FROM HangHoiVien WHERE MaHang = @ma", DbHelper.Tham("@ma", int.Parse(txtMaHang.Text)));
                TaiHang();
                XoaOHang();
            }
            catch (Exception ex) { Loi(LoiSql(ex, "Hạng")); }
        }

        private void btnLamMoiHang_Click(object sender, EventArgs e)
        {
            TaiHang();
            XoaOHang();
        }
    }
}
