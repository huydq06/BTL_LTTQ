namespace BTL_LTTQ
{
    partial class FrmDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.components = new System.ComponentModel.Container();
            this.tabChinh = new System.Windows.Forms.TabControl();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.tabNhapKho = new System.Windows.Forms.TabPage();
            this.bsDichVu = new System.Windows.Forms.BindingSource(this.components);
            this.bsDichVuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.bsNhapKho = new System.Windows.Forms.BindingSource(this.components);
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.pnlNhapDV = new System.Windows.Forms.Panel();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.btnSuaDV = new System.Windows.Forms.Button();
            this.btnXoaDV = new System.Windows.Forms.Button();
            this.btnLamMoiDV = new System.Windows.Forms.Button();
            this.pnlTimDV = new System.Windows.Forms.Panel();
            this.lblTimDV = new System.Windows.Forms.Label();
            this.txtTimDV = new System.Windows.Forms.TextBox();
            this.dgvNhapKho = new System.Windows.Forms.DataGridView();
            this.pnlNhapKho = new System.Windows.Forms.Panel();
            this.lblDichVuNhap = new System.Windows.Forms.Label();
            this.cboDichVuNhap = new System.Windows.Forms.ComboBox();
            this.lblSoLuongNhap = new System.Windows.Forms.Label();
            this.nudSoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.nudDonGiaNhap = new System.Windows.Forms.NumericUpDown();
            this.btnNhapKho = new System.Windows.Forms.Button();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTieuDe)).BeginInit();
            this.tabChinh.SuspendLayout();
            this.tabDichVu.SuspendLayout();
            this.tabNhapKho.SuspendLayout();
            this.pnlNhapDV.SuspendLayout();
            this.pnlTimDV.SuspendLayout();
            this.pnlNhapKho.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabChinh
            // 
            this.tabChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabChinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabChinh.Location = new System.Drawing.Point(0, 64);
            this.tabChinh.Padding = new System.Drawing.Point(14, 6);
            this.tabChinh.SelectedIndex = 0;
            this.tabChinh.Size = new System.Drawing.Size(944, 557);
            this.tabChinh.TabIndex = 0;
            this.tabChinh.Controls.Add(this.tabDichVu);
            this.tabChinh.Controls.Add(this.tabNhapKho);
            // 
            // tabDichVu
            // 
            this.tabDichVu.BackColor = System.Drawing.Color.White;
            this.tabDichVu.Location = new System.Drawing.Point(4, 34);
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tabDichVu.Size = new System.Drawing.Size(936, 519);
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.TabIndex = 0;
            this.tabDichVu.Controls.Add(this.dgvDichVu);
            this.tabDichVu.Controls.Add(this.pnlNhapDV);
            this.tabDichVu.Controls.Add(this.pnlTimDV);
            // 
            // tabNhapKho
            // 
            this.tabNhapKho.BackColor = System.Drawing.Color.White;
            this.tabNhapKho.Location = new System.Drawing.Point(4, 34);
            this.tabNhapKho.Padding = new System.Windows.Forms.Padding(3);
            this.tabNhapKho.Size = new System.Drawing.Size(936, 519);
            this.tabNhapKho.Text = "Nhập kho";
            this.tabNhapKho.TabIndex = 1;
            this.tabNhapKho.Controls.Add(this.dgvNhapKho);
            this.tabNhapKho.Controls.Add(this.pnlNhapKho);
            // 
            // bsDichVu
            // 
            this.bsDichVu.CurrentChanged += new System.EventHandler(this.bsDichVu_CurrentChanged);
            // 
            // bsDichVuNhap
            // 
            // 
            // bsNhapKho
            // 
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDichVu.ColumnHeadersHeight = 38;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDichVu.DataSource = this.bsDichVu;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvDichVu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu.EnableHeadersVisualStyles = false;
            this.dgvDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowTemplate.Height = 32;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.TabIndex = 0;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // pnlNhapDV
            // 
            this.pnlNhapDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNhapDV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNhapDV.Size = new System.Drawing.Size(100, 166);
            this.pnlNhapDV.TabIndex = 1;
            this.pnlNhapDV.Controls.Add(this.lblMaDV);
            this.pnlNhapDV.Controls.Add(this.txtMaDV);
            this.pnlNhapDV.Controls.Add(this.lblTenDV);
            this.pnlNhapDV.Controls.Add(this.txtTenDV);
            this.pnlNhapDV.Controls.Add(this.lblDonGia);
            this.pnlNhapDV.Controls.Add(this.nudDonGia);
            this.pnlNhapDV.Controls.Add(this.lblSoLuongTon);
            this.pnlNhapDV.Controls.Add(this.txtSoLuongTon);
            this.pnlNhapDV.Controls.Add(this.btnThemDV);
            this.pnlNhapDV.Controls.Add(this.btnSuaDV);
            this.pnlNhapDV.Controls.Add(this.btnXoaDV);
            this.pnlNhapDV.Controls.Add(this.btnLamMoiDV);
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = false;
            this.lblMaDV.Location = new System.Drawing.Point(20, 18);
            this.lblMaDV.Size = new System.Drawing.Size(135, 26);
            this.lblMaDV.Text = "Mã DV";
            this.lblMaDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaDV.TabIndex = 0;
            // 
            // txtMaDV
            // 
            this.txtMaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtMaDV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(160, 18);
            this.txtMaDV.ReadOnly = true;
            this.txtMaDV.Size = new System.Drawing.Size(230, 26);
            this.txtMaDV.TabStop = false;
            this.txtMaDV.TabIndex = 1;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = false;
            this.lblTenDV.Location = new System.Drawing.Point(20, 60);
            this.lblTenDV.Size = new System.Drawing.Size(135, 26);
            this.lblTenDV.Text = "Tên dịch vụ";
            this.lblTenDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTenDV.TabIndex = 2;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(160, 60);
            this.txtTenDV.MaxLength = 100;
            this.txtTenDV.Size = new System.Drawing.Size(230, 26);
            this.txtTenDV.TabIndex = 3;
            this.txtTenDV.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenDV_Validating);
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = false;
            this.lblDonGia.Location = new System.Drawing.Point(420, 18);
            this.lblDonGia.Size = new System.Drawing.Size(150, 26);
            this.lblDonGia.Text = "Đơn giá (đ)";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDonGia.TabIndex = 4;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.nudDonGia.Location = new System.Drawing.Point(575, 18);
            this.nudDonGia.Size = new System.Drawing.Size(230, 26);
            this.nudDonGia.Increment = new decimal(new int[] {1000, 0, 0, 0});
            this.nudDonGia.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.nudDonGia.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDonGia.ThousandsSeparator = true;
            this.nudDonGia.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudDonGia.TabIndex = 5;
            this.nudDonGia.Validating += new System.ComponentModel.CancelEventHandler(this.nudDonGia_Validating);
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = false;
            this.lblSoLuongTon.Location = new System.Drawing.Point(420, 60);
            this.lblSoLuongTon.Size = new System.Drawing.Size(150, 26);
            this.lblSoLuongTon.Text = "Tồn kho";
            this.lblSoLuongTon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoLuongTon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSoLuongTon.TabIndex = 6;
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(575, 60);
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(230, 26);
            this.txtSoLuongTon.TabStop = false;
            this.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSoLuongTon.TabIndex = 7;
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThemDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Image = global::BTL_LTTQ.Properties.Resources.nut_them;
            this.btnThemDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDV.Location = new System.Drawing.Point(20, 110);
            this.btnThemDV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnThemDV.Size = new System.Drawing.Size(120, 38);
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.TabIndex = 8;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnSuaDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDV.FlatAppearance.BorderSize = 0;
            this.btnSuaDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDV.ForeColor = System.Drawing.Color.White;
            this.btnSuaDV.Image = global::BTL_LTTQ.Properties.Resources.nut_sua;
            this.btnSuaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaDV.Location = new System.Drawing.Point(150, 110);
            this.btnSuaDV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSuaDV.Size = new System.Drawing.Size(120, 38);
            this.btnSuaDV.Text = "Sửa";
            this.btnSuaDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaDV.UseVisualStyleBackColor = false;
            this.btnSuaDV.TabIndex = 9;
            this.btnSuaDV.Click += new System.EventHandler(this.btnSuaDV_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoaDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.FlatAppearance.BorderSize = 0;
            this.btnXoaDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Image = global::BTL_LTTQ.Properties.Resources.nut_xoa;
            this.btnXoaDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDV.Location = new System.Drawing.Point(280, 110);
            this.btnXoaDV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnXoaDV.Size = new System.Drawing.Size(120, 38);
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.TabIndex = 10;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // btnLamMoiDV
            // 
            this.btnLamMoiDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoiDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiDV.FlatAppearance.BorderSize = 0;
            this.btnLamMoiDV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiDV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiDV.Image = global::BTL_LTTQ.Properties.Resources.nut_lammoi;
            this.btnLamMoiDV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiDV.Location = new System.Drawing.Point(410, 110);
            this.btnLamMoiDV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnLamMoiDV.Size = new System.Drawing.Size(120, 38);
            this.btnLamMoiDV.Text = "Làm mới";
            this.btnLamMoiDV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiDV.UseVisualStyleBackColor = false;
            this.btnLamMoiDV.TabIndex = 11;
            this.btnLamMoiDV.Click += new System.EventHandler(this.btnLamMoiDV_Click);
            // 
            // pnlTimDV
            // 
            this.pnlTimDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTimDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimDV.Size = new System.Drawing.Size(100, 52);
            this.pnlTimDV.TabIndex = 2;
            this.pnlTimDV.Controls.Add(this.lblTimDV);
            this.pnlTimDV.Controls.Add(this.txtTimDV);
            // 
            // lblTimDV
            // 
            this.lblTimDV.AutoSize = false;
            this.lblTimDV.Location = new System.Drawing.Point(20, 13);
            this.lblTimDV.Size = new System.Drawing.Size(200, 26);
            this.lblTimDV.Text = "Tìm theo tên dịch vụ";
            this.lblTimDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimDV.TabIndex = 0;
            // 
            // txtTimDV
            // 
            this.txtTimDV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDV.Location = new System.Drawing.Point(230, 13);
            this.txtTimDV.Size = new System.Drawing.Size(300, 26);
            this.txtTimDV.TabIndex = 1;
            this.txtTimDV.TextChanged += new System.EventHandler(this.txtTimDV_TextChanged);
            // 
            // dgvNhapKho
            // 
            this.dgvNhapKho.AllowUserToAddRows = false;
            this.dgvNhapKho.AllowUserToDeleteRows = false;
            this.dgvNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhapKho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhapKho.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhapKho.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhapKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNhapKho.ColumnHeadersHeight = 38;
            this.dgvNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhapKho.DataSource = this.bsNhapKho;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhapKho.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvNhapKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhapKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhapKho.EnableHeadersVisualStyles = false;
            this.dgvNhapKho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvNhapKho.MultiSelect = false;
            this.dgvNhapKho.ReadOnly = true;
            this.dgvNhapKho.RowHeadersVisible = false;
            this.dgvNhapKho.RowTemplate.Height = 32;
            this.dgvNhapKho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhapKho.TabIndex = 0;
            // 
            // pnlNhapKho
            // 
            this.pnlNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNhapKho.Size = new System.Drawing.Size(100, 166);
            this.pnlNhapKho.TabIndex = 1;
            this.pnlNhapKho.Controls.Add(this.lblDichVuNhap);
            this.pnlNhapKho.Controls.Add(this.cboDichVuNhap);
            this.pnlNhapKho.Controls.Add(this.lblSoLuongNhap);
            this.pnlNhapKho.Controls.Add(this.nudSoLuongNhap);
            this.pnlNhapKho.Controls.Add(this.lblDonGiaNhap);
            this.pnlNhapKho.Controls.Add(this.nudDonGiaNhap);
            this.pnlNhapKho.Controls.Add(this.btnNhapKho);
            // 
            // lblDichVuNhap
            // 
            this.lblDichVuNhap.AutoSize = false;
            this.lblDichVuNhap.Location = new System.Drawing.Point(20, 18);
            this.lblDichVuNhap.Size = new System.Drawing.Size(135, 26);
            this.lblDichVuNhap.Text = "Dịch vụ";
            this.lblDichVuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDichVuNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDichVuNhap.TabIndex = 0;
            // 
            // cboDichVuNhap
            // 
            this.cboDichVuNhap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVuNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDichVuNhap.FormattingEnabled = true;
            this.cboDichVuNhap.Location = new System.Drawing.Point(160, 18);
            this.cboDichVuNhap.Size = new System.Drawing.Size(230, 28);
            this.cboDichVuNhap.DataSource = this.bsDichVuNhap;
            this.cboDichVuNhap.DisplayMember = "TenDV";
            this.cboDichVuNhap.ValueMember = "MaDV";
            this.cboDichVuNhap.TabIndex = 1;
            this.cboDichVuNhap.Validating += new System.ComponentModel.CancelEventHandler(this.cboDichVuNhap_Validating);
            // 
            // lblSoLuongNhap
            // 
            this.lblSoLuongNhap.AutoSize = false;
            this.lblSoLuongNhap.Location = new System.Drawing.Point(20, 60);
            this.lblSoLuongNhap.Size = new System.Drawing.Size(135, 26);
            this.lblSoLuongNhap.Text = "Số lượng nhập";
            this.lblSoLuongNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoLuongNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSoLuongNhap.TabIndex = 2;
            // 
            // nudSoLuongNhap
            // 
            this.nudSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuongNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.nudSoLuongNhap.Location = new System.Drawing.Point(160, 60);
            this.nudSoLuongNhap.Size = new System.Drawing.Size(230, 26);
            this.nudSoLuongNhap.Increment = new decimal(new int[] {1, 0, 0, 0});
            this.nudSoLuongNhap.Maximum = new decimal(new int[] {100000, 0, 0, 0});
            this.nudSoLuongNhap.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudSoLuongNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuongNhap.ThousandsSeparator = true;
            this.nudSoLuongNhap.Value = new decimal(new int[] {1, 0, 0, 0});
            this.nudSoLuongNhap.TabIndex = 3;
            this.nudSoLuongNhap.Validating += new System.ComponentModel.CancelEventHandler(this.nudSoLuongNhap_Validating);
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = false;
            this.lblDonGiaNhap.Location = new System.Drawing.Point(420, 60);
            this.lblDonGiaNhap.Size = new System.Drawing.Size(150, 26);
            this.lblDonGiaNhap.Text = "Đơn giá nhập (đ)";
            this.lblDonGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDonGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblDonGiaNhap.TabIndex = 4;
            // 
            // nudDonGiaNhap
            // 
            this.nudDonGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDonGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.nudDonGiaNhap.Location = new System.Drawing.Point(575, 60);
            this.nudDonGiaNhap.Size = new System.Drawing.Size(230, 26);
            this.nudDonGiaNhap.Increment = new decimal(new int[] {1000, 0, 0, 0});
            this.nudDonGiaNhap.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.nudDonGiaNhap.Minimum = new decimal(new int[] {0, 0, 0, 0});
            this.nudDonGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDonGiaNhap.ThousandsSeparator = true;
            this.nudDonGiaNhap.Value = new decimal(new int[] {0, 0, 0, 0});
            this.nudDonGiaNhap.TabIndex = 5;
            this.nudDonGiaNhap.Validating += new System.ComponentModel.CancelEventHandler(this.nudDonGiaNhap_Validating);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnNhapKho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapKho.ForeColor = System.Drawing.Color.White;
            this.btnNhapKho.Image = global::BTL_LTTQ.Properties.Resources.nut_nhapkho;
            this.btnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Location = new System.Drawing.Point(20, 110);
            this.btnNhapKho.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnNhapKho.Size = new System.Drawing.Size(150, 38);
            this.btnNhapKho.Text = "Nhập kho";
            this.btnNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapKho.UseVisualStyleBackColor = false;
            this.btnNhapKho.TabIndex = 6;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Size = new System.Drawing.Size(100, 64);
            this.pnlTieuDe.TabIndex = 1;
            this.pnlTieuDe.Controls.Add(this.picTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            // 
            // picTieuDe
            // 
            this.picTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_dichvu;
            this.picTieuDe.Location = new System.Drawing.Point(16, 12);
            this.picTieuDe.Size = new System.Drawing.Size(40, 40);
            this.picTieuDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTieuDe.TabStop = false;
            this.picTieuDe.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(68, 16);
            this.lblTieuDe.Size = new System.Drawing.Size(100, 28);
            this.lblTieuDe.Text = "Quản lý dịch vụ && kho";
            this.lblTieuDe.TabIndex = 1;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 621);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.MinimumSize = new System.Drawing.Size(860, 580);
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý dịch vụ & kho";
            this.Controls.Add(this.tabChinh);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmDichVu";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            this.tabChinh.ResumeLayout(false);
            this.tabDichVu.ResumeLayout(false);
            this.tabNhapKho.ResumeLayout(false);
            this.pnlNhapDV.ResumeLayout(false);
            this.pnlTimDV.ResumeLayout(false);
            this.pnlNhapKho.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTieuDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabChinh;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.TabPage tabNhapKho;
        private System.Windows.Forms.BindingSource bsDichVu;
        private System.Windows.Forms.BindingSource bsDichVuNhap;
        private System.Windows.Forms.BindingSource bsNhapKho;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.Panel pnlNhapDV;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnSuaDV;
        private System.Windows.Forms.Button btnXoaDV;
        private System.Windows.Forms.Button btnLamMoiDV;
        private System.Windows.Forms.Panel pnlTimDV;
        private System.Windows.Forms.Label lblTimDV;
        private System.Windows.Forms.TextBox txtTimDV;
        private System.Windows.Forms.DataGridView dgvNhapKho;
        private System.Windows.Forms.Panel pnlNhapKho;
        private System.Windows.Forms.Label lblDichVuNhap;
        private System.Windows.Forms.ComboBox cboDichVuNhap;
        private System.Windows.Forms.Label lblSoLuongNhap;
        private System.Windows.Forms.NumericUpDown nudSoLuongNhap;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.NumericUpDown nudDonGiaNhap;
        private System.Windows.Forms.Button btnNhapKho;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
