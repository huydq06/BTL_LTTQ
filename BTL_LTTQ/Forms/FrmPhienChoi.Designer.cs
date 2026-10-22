namespace BTL_LTTQ
{
    partial class FrmPhienChoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.pnlGoiDV = new System.Windows.Forms.Panel();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnHuyDV = new System.Windows.Forms.Button();
            this.pnlDuoi = new System.Windows.Forms.Panel();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.tlpThongTin = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenMay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKhach = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.bsDichVu = new System.Windows.Forms.BindingSource(this.components);
            this.tmrDongHo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVu)).BeginInit();
            this.pnlGoiDV.SuspendLayout();
            this.pnlDuoi.SuspendLayout();
            this.tlpThongTin.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDichVu.ColumnHeadersHeight = 38;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDichVu.DataSource = this.bsDichVu;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.EnableHeadersVisualStyles = false;
            this.dgvDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvDichVu.Location = new System.Drawing.Point(0, 290);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowTemplate.Height = 32;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Size = new System.Drawing.Size(780, 200);
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.Name = "dgvDichVu";
            // 
            // pnlGoiDV
            // 
            this.pnlGoiDV.Controls.Add(this.cboDichVu);
            this.pnlGoiDV.Controls.Add(this.nudSoLuong);
            this.pnlGoiDV.Controls.Add(this.btnThemDV);
            this.pnlGoiDV.Controls.Add(this.btnHuyDV);
            this.pnlGoiDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlGoiDV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlGoiDV.Location = new System.Drawing.Point(0, 490);
            this.pnlGoiDV.Size = new System.Drawing.Size(780, 64);
            this.pnlGoiDV.TabIndex = 1;
            this.pnlGoiDV.Name = "pnlGoiDV";
            // 
            // cboDichVu
            // 
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(16, 18);
            this.cboDichVu.Size = new System.Drawing.Size(280, 27);
            this.cboDichVu.TabIndex = 0;
            this.cboDichVu.Name = "cboDichVu";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(306, 18);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Size = new System.Drawing.Size(70, 26);
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.Name = "nudSoLuong";
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnThemDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Image = global::BTL_LTTQ.Properties.Resources.nut_dichvu;
            this.btnThemDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDV.Location = new System.Drawing.Point(386, 12);
            this.btnThemDV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnThemDV.Size = new System.Drawing.Size(150, 40);
            this.btnThemDV.Text = "Gọi dịch vụ";
            this.btnThemDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.TabIndex = 2;
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnHuyDV
            // 
            this.btnHuyDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnHuyDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyDV.FlatAppearance.BorderSize = 0;
            this.btnHuyDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDV.ForeColor = System.Drawing.Color.White;
            this.btnHuyDV.Image = global::BTL_LTTQ.Properties.Resources.nut_xoa;
            this.btnHuyDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyDV.Location = new System.Drawing.Point(546, 12);
            this.btnHuyDV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnHuyDV.Size = new System.Drawing.Size(218, 40);
            this.btnHuyDV.Text = "Hủy dịch vụ đã chọn";
            this.btnHuyDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyDV.UseVisualStyleBackColor = false;
            this.btnHuyDV.TabIndex = 3;
            this.btnHuyDV.Name = "btnHuyDV";
            this.btnHuyDV.Click += new System.EventHandler(this.btnHuyDV_Click);
            // 
            // pnlDuoi
            // 
            this.pnlDuoi.Controls.Add(this.btnKetThuc);
            this.pnlDuoi.Controls.Add(this.btnDong);
            this.pnlDuoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.pnlDuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDuoi.Location = new System.Drawing.Point(0, 554);
            this.pnlDuoi.Size = new System.Drawing.Size(780, 60);
            this.pnlDuoi.TabIndex = 2;
            this.pnlDuoi.Name = "pnlDuoi";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnKetThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKetThuc.FlatAppearance.BorderSize = 0;
            this.btnKetThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.ForeColor = System.Drawing.Color.White;
            this.btnKetThuc.Image = global::BTL_LTTQ.Properties.Resources.nut_ketthuc;
            this.btnKetThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKetThuc.Location = new System.Drawing.Point(16, 10);
            this.btnKetThuc.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnKetThuc.Size = new System.Drawing.Size(270, 42);
            this.btnKetThuc.Text = "Kết thúc và thanh toán";
            this.btnKetThuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKetThuc.UseVisualStyleBackColor = false;
            this.btnKetThuc.TabIndex = 0;
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.FlatAppearance.BorderSize = 0;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Image = global::BTL_LTTQ.Properties.Resources.nut_dong;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(644, 10);
            this.btnDong.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDong.Size = new System.Drawing.Size(120, 42);
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.TabIndex = 1;
            this.btnDong.Name = "btnDong";
            // 
            // tlpThongTin
            // 
            this.tlpThongTin.Controls.Add(this.label1, 0, 0);
            this.tlpThongTin.Controls.Add(this.lblTenMay, 1, 0);
            this.tlpThongTin.Controls.Add(this.label2, 0, 1);
            this.tlpThongTin.Controls.Add(this.lblKhach, 1, 1);
            this.tlpThongTin.Controls.Add(this.label3, 0, 2);
            this.tlpThongTin.Controls.Add(this.lblBatDau, 1, 2);
            this.tlpThongTin.Controls.Add(this.label4, 0, 3);
            this.tlpThongTin.Controls.Add(this.lblThoiGian, 1, 3);
            this.tlpThongTin.Controls.Add(this.label5, 0, 4);
            this.tlpThongTin.Controls.Add(this.lblTamTinh, 1, 4);
            this.tlpThongTin.BackColor = System.Drawing.Color.White;
            this.tlpThongTin.ColumnCount = 2;
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpThongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpThongTin.Location = new System.Drawing.Point(0, 64);
            this.tlpThongTin.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.tlpThongTin.RowCount = 5;
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpThongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpThongTin.Size = new System.Drawing.Size(780, 226);
            this.tlpThongTin.TabIndex = 3;
            this.tlpThongTin.Name = "tlpThongTin";
            // 
            // label1
            // 
            this.label1.AutoSize = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Text = "Máy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.TabIndex = 0;
            this.label1.Name = "label1";
            // 
            // lblTenMay
            // 
            this.lblTenMay.AutoSize = false;
            this.lblTenMay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.lblTenMay.Text = "";
            this.lblTenMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenMay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenMay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblTenMay.TabIndex = 1;
            this.lblTenMay.Name = "lblTenMay";
            // 
            // label2
            // 
            this.label2.AutoSize = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label2.Text = "Khách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label2.TabIndex = 2;
            this.label2.Name = "label2";
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = false;
            this.lblKhach.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblKhach.Text = "";
            this.lblKhach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhach.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblKhach.TabIndex = 3;
            this.lblKhach.Name = "lblKhach";
            // 
            // label3
            // 
            this.label3.AutoSize = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label3.Text = "Bắt đầu lúc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label3.TabIndex = 4;
            this.label3.Name = "label3";
            // 
            // lblBatDau
            // 
            this.lblBatDau.AutoSize = false;
            this.lblBatDau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblBatDau.Text = "";
            this.lblBatDau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBatDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBatDau.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblBatDau.TabIndex = 5;
            this.lblBatDau.Name = "lblBatDau";
            // 
            // label4
            // 
            this.label4.AutoSize = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Text = "Thời gian chơi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label4.TabIndex = 6;
            this.label4.Name = "label4";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = false;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblThoiGian.Text = "00:00:00";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblThoiGian.TabIndex = 7;
            this.lblThoiGian.Name = "lblThoiGian";
            // 
            // label5
            // 
            this.label5.AutoSize = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Text = "Tạm tính tiền giờ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label5.TabIndex = 8;
            this.label5.Name = "label5";
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.AutoSize = false;
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblTamTinh.Text = "0";
            this.lblTamTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTamTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTamTinh.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lblTamTinh.TabIndex = 9;
            this.lblTamTinh.Name = "lblTamTinh";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.Controls.Add(this.picTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Size = new System.Drawing.Size(100, 64);
            this.pnlTieuDe.TabIndex = 4;
            this.pnlTieuDe.Name = "pnlTieuDe";
            // 
            // picTieuDe
            // 
            this.picTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_phienchoi;
            this.picTieuDe.Location = new System.Drawing.Point(16, 12);
            this.picTieuDe.Size = new System.Drawing.Size(40, 40);
            this.picTieuDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTieuDe.TabStop = false;
            this.picTieuDe.TabIndex = 0;
            this.picTieuDe.Name = "picTieuDe";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(68, 16);
            this.lblTieuDe.Size = new System.Drawing.Size(160, 28);
            this.lblTieuDe.Text = "Phiên chơi";
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // bsDichVu
            // 
            // 
            // tmrDongHo
            // 
            this.tmrDongHo.Enabled = true;
            this.tmrDongHo.Interval = 1000;
            this.tmrDongHo.Tick += new System.EventHandler(this.tmrDongHo_Tick);
            // 
            // FrmPhienChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(780, 680);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 640);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phiên chơi";
            this.Controls.Add(this.dgvDichVu);
            this.Controls.Add(this.pnlGoiDV);
            this.Controls.Add(this.pnlDuoi);
            this.Controls.Add(this.tlpThongTin);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmPhienChoi";
            this.Load += new System.EventHandler(this.FrmPhienChoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVu)).EndInit();
            this.pnlGoiDV.ResumeLayout(false);
            this.pnlGoiDV.PerformLayout();
            this.pnlDuoi.ResumeLayout(false);
            this.pnlDuoi.PerformLayout();
            this.tlpThongTin.ResumeLayout(false);
            this.tlpThongTin.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel pnlGoiDV;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnHuyDV;
        private System.Windows.Forms.Panel pnlDuoi;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TableLayoutPanel tlpThongTin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.BindingSource bsDichVu;
        private System.Windows.Forms.Timer tmrDongHo;
    }
}
