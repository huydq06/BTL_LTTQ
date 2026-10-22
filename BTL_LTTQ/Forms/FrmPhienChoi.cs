using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BTL_LTTQ.Common;
using BTL_LTTQ.Data;

namespace BTL_LTTQ
{
    // Phiên chơi đang diễn ra: đồng hồ, tạm tính, gọi/hủy dịch vụ
    public partial class FrmPhienChoi : Form
    {
        private readonly int _maPhien;
        private DateTime _batDau;
        private decimal _giaGio;
        private bool _daTai;

        public FrmPhienChoi(int maPhien)
        {
            InitializeComponent();
            _maPhien = maPhien;
        }

        private void FrmPhienChoi_Load(object sender, EventArgs e)
        {
            DataTable bang = DbHelper.LayBang(
                "SELECT m.TenMay, k.HoTen, p.GioBatDau, p.GiaGioApDung, p.TrangThai " +
                "FROM PhienChoi p JOIN May m ON m.MaMay = p.MaMay LEFT JOIN KhachHang k ON k.MaKH = p.MaKH " +
                "WHERE p.MaPhien = @p", DbHelper.Tham("@p", _maPhien));
            if (bang.Rows.Count == 0 || bang.Rows[0]["TrangThai"].ToString() != "DangChoi")
            {
                MessageBox.Show("Phiên chơi không còn hoạt động.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tmrDongHo.Enabled = false;
                btnThemDV.Enabled = false;
                btnHuyDV.Enabled = false;
                btnKetThuc.Enabled = false;
                return;
            }
            DataRow r = bang.Rows[0];
            lblTenMay.Text = r["TenMay"].ToString();
            lblKhach.Text = r["HoTen"] == DBNull.Value ? "Vãng lai" : r["HoTen"].ToString();
            _batDau = Convert.ToDateTime(r["GioBatDau"]);
            _giaGio = Convert.ToDecimal(r["GiaGioApDung"]);
            lblBatDau.Text = _batDau.ToString("dd/MM/yyyy HH:mm:ss");
            _daTai = true;

            TaiDanhSachDichVu();
            TaiDichVuDaGoi();
            CapNhatDongHo();
        }

        // Danh sách dịch vụ để chọn (kèm giá và tồn kho)
        private void TaiDanhSachDichVu()
        {
            object daChon = cboDichVu.SelectedValue;
            cboDichVu.DataSource = DbHelper.LayBang(
                "SELECT MaDV, TenDV + N' - ' + CONVERT(NVARCHAR(20), CONVERT(INT, DonGia)) + N'đ (còn ' + " +
                "CONVERT(NVARCHAR(10), SoLuongTon) + N')' AS HienThi FROM DichVu ORDER BY TenDV");
            cboDichVu.DisplayMember = "HienThi";
            cboDichVu.ValueMember = "MaDV";
            if (daChon != null) cboDichVu.SelectedValue = daChon;
        }

        // Dịch vụ đã gọi của phiên
        private void TaiDichVuDaGoi()
        {
            bsDichVu.DataSource = DbHelper.LayBang(
                "SELECT c.MaDV, d.TenDV AS [Dịch vụ], c.SoLuong AS [Số lượng], c.DonGia AS [Đơn giá], " +
                "c.SoLuong * c.DonGia AS [Thành tiền] FROM ChiTietDichVu c JOIN DichVu d ON d.MaDV = c.MaDV " +
                "WHERE c.MaPhien = @p ORDER BY d.TenDV", DbHelper.Tham("@p", _maPhien));
            dgvDichVu.Columns["MaDV"].Visible = false;
            dgvDichVu.Columns["Đơn giá"].DefaultCellStyle.Format = "N0";
            dgvDichVu.Columns["Thành tiền"].DefaultCellStyle.Format = "N0";
            foreach (string cot in new[] { "Số lượng", "Đơn giá", "Thành tiền" })
                dgvDichVu.Columns[cot].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void CapNhatDongHo()
        {
            TimeSpan ts = DateTime.Now - _batDau;
            if (ts < TimeSpan.Zero) ts = TimeSpan.Zero;
            lblThoiGian.Text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
            lblTamTinh.Text = TinhTien.TienGio(_batDau, DateTime.Now, _giaGio).ToString("N0") + "đ";
        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            if (_daTai) CapNhatDongHo();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (cboDichVu.SelectedValue == null)
            {
                MessageBox.Show("Hãy chọn dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maDV = Convert.ToInt32(cboDichVu.SelectedValue);
            int soLuong = (int)nudSoLuong.Value;

            // Kiểm tra tồn kho
            int ton = Convert.ToInt32(DbHelper.LayGiaTri("SELECT SoLuongTon FROM DichVu WHERE MaDV = @dv", DbHelper.Tham("@dv", maDV)));
            if (ton < soLuong)
            {
                MessageBox.Show("Không đủ hàng trong kho (còn " + ton + ").", "Hết hàng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trừ kho và thêm/cộng dòng chi tiết trong một giao dịch
            var cacLenh = new List<Lenh>
            {
                new Lenh(true, "UPDATE DichVu SET SoLuongTon = SoLuongTon - @sl WHERE MaDV = @dv AND SoLuongTon >= @sl",
                    DbHelper.Tham("@sl", soLuong), DbHelper.Tham("@dv", maDV)),
                new Lenh("UPDATE ChiTietDichVu SET SoLuong = SoLuong + @sl WHERE MaPhien = @p AND MaDV = @dv; " +
                    "IF @@ROWCOUNT = 0 INSERT INTO ChiTietDichVu (MaPhien, MaDV, SoLuong, DonGia) " +
                    "SELECT @p, @dv, @sl, DonGia FROM DichVu WHERE MaDV = @dv",
                    DbHelper.Tham("@sl", soLuong), DbHelper.Tham("@p", _maPhien), DbHelper.Tham("@dv", maDV))
            };
            try
            {
                DbHelper.ThucThiGiaoDich(cacLenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không gọi được dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            nudSoLuong.Value = 1;
            TaiDanhSachDichVu();
            TaiDichVuDaGoi();
        }

        private void btnHuyDV_Click(object sender, EventArgs e)
        {
            var dong = bsDichVu.Current as DataRowView;
            if (dong == null)
            {
                MessageBox.Show("Hãy chọn dòng dịch vụ cần hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maDV = Convert.ToInt32(dong["MaDV"]);
            int daGoi = Convert.ToInt32(dong["Số lượng"]);
            int soLuong = (int)nudSoLuong.Value;
            if (soLuong > daGoi)
            {
                MessageBox.Show("Chỉ đã gọi " + daGoi + " phần, không thể hủy " + soLuong + ".", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Hủy " + soLuong + " x " + dong["Dịch vụ"] + "?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            // Hủy hết thì xóa dòng (SoLuong phải > 0), không thì giảm số lượng; hoàn kho trong cùng giao dịch
            var cacLenh = new List<Lenh>();
            if (soLuong == daGoi)
                cacLenh.Add(new Lenh(true, "DELETE FROM ChiTietDichVu WHERE MaPhien = @p AND MaDV = @dv AND SoLuong = @sl",
                    DbHelper.Tham("@p", _maPhien), DbHelper.Tham("@dv", maDV), DbHelper.Tham("@sl", soLuong)));
            else
                cacLenh.Add(new Lenh(true, "UPDATE ChiTietDichVu SET SoLuong = SoLuong - @sl WHERE MaPhien = @p AND MaDV = @dv AND SoLuong > @sl",
                    DbHelper.Tham("@sl", soLuong), DbHelper.Tham("@p", _maPhien), DbHelper.Tham("@dv", maDV)));
            cacLenh.Add(new Lenh("UPDATE DichVu SET SoLuongTon = SoLuongTon + @sl WHERE MaDV = @dv",
                DbHelper.Tham("@sl", soLuong), DbHelper.Tham("@dv", maDV)));
            try
            {
                DbHelper.ThucThiGiaoDich(cacLenh);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không hủy được dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            nudSoLuong.Value = 1;
            TaiDanhSachDichVu();
            TaiDichVuDaGoi();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            using (var f = new FrmThanhToan(_maPhien))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    tmrDongHo.Enabled = false;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
