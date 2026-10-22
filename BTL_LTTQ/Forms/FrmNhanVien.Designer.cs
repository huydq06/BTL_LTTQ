namespace BTL_LTTQ
{
    partial class FrmNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.bsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.pnlNhapNV = new System.Windows.Forms.Panel();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkTrangThai = new System.Windows.Forms.CheckBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnDatLaiMatKhau = new System.Windows.Forms.Button();
            this.btnLamMoiNV = new System.Windows.Forms.Button();
            this.pnlTimNV = new System.Windows.Forms.Panel();
            this.lblTimNV = new System.Windows.Forms.Label();
            this.txtTimNV = new System.Windows.Forms.TextBox();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTieuDe)).BeginInit();
            this.pnlNhapNV.SuspendLayout();
            this.pnlTimNV.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsNhanVien
            // 
            this.bsNhanVien.CurrentChanged += new System.EventHandler(this.bsNhanVien_CurrentChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 38;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanVien.DataSource = this.bsNhanVien;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowTemplate.Height = 32;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // pnlNhapNV
            // 
            this.pnlNhapNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlNhapNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNhapNV.Size = new System.Drawing.Size(100, 208);
            this.pnlNhapNV.TabIndex = 1;
            this.pnlNhapNV.Controls.Add(this.lblMaNV);
            this.pnlNhapNV.Controls.Add(this.txtMaNV);
            this.pnlNhapNV.Controls.Add(this.lblTenDangNhap);
            this.pnlNhapNV.Controls.Add(this.txtTenDangNhap);
            this.pnlNhapNV.Controls.Add(this.lblHoTen);
            this.pnlNhapNV.Controls.Add(this.txtHoTen);
            this.pnlNhapNV.Controls.Add(this.lblVaiTro);
            this.pnlNhapNV.Controls.Add(this.cboVaiTro);
            this.pnlNhapNV.Controls.Add(this.lblMatKhau);
            this.pnlNhapNV.Controls.Add(this.txtMatKhau);
            this.pnlNhapNV.Controls.Add(this.chkTrangThai);
            this.pnlNhapNV.Controls.Add(this.btnThemNV);
            this.pnlNhapNV.Controls.Add(this.btnSuaNV);
            this.pnlNhapNV.Controls.Add(this.btnXoaNV);
            this.pnlNhapNV.Controls.Add(this.btnDatLaiMatKhau);
            this.pnlNhapNV.Controls.Add(this.btnLamMoiNV);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = false;
            this.lblMaNV.Location = new System.Drawing.Point(20, 18);
            this.lblMaNV.Size = new System.Drawing.Size(135, 26);
            this.lblMaNV.Text = "Mã NV";
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMaNV.TabIndex = 0;
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(160, 18);
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(230, 26);
            this.txtMaNV.TabStop = false;
            this.txtMaNV.TabIndex = 1;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = false;
            this.lblTenDangNhap.Location = new System.Drawing.Point(20, 60);
            this.lblTenDangNhap.Size = new System.Drawing.Size(135, 26);
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            this.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTenDangNhap.TabIndex = 2;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(160, 60);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Size = new System.Drawing.Size(230, 26);
            this.txtTenDangNhap.TabIndex = 3;
            this.txtTenDangNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenDangNhap_Validating);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = false;
            this.lblHoTen.Location = new System.Drawing.Point(20, 102);
            this.lblHoTen.Size = new System.Drawing.Size(135, 26);
            this.lblHoTen.Text = "Họ tên";
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblHoTen.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(160, 102);
            this.txtHoTen.MaxLength = 100;
            this.txtHoTen.Size = new System.Drawing.Size(230, 26);
            this.txtHoTen.TabIndex = 5;
            this.txtHoTen.Validating += new System.ComponentModel.CancelEventHandler(this.txtHoTen_Validating);
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = false;
            this.lblVaiTro.Location = new System.Drawing.Point(420, 18);
            this.lblVaiTro.Size = new System.Drawing.Size(150, 26);
            this.lblVaiTro.Text = "Vai trò";
            this.lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVaiTro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblVaiTro.TabIndex = 6;
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Items.AddRange(new object[] {"Admin", "NhanVien"});
            this.cboVaiTro.Location = new System.Drawing.Point(575, 18);
            this.cboVaiTro.Size = new System.Drawing.Size(230, 28);
            this.cboVaiTro.TabIndex = 7;
            this.cboVaiTro.Validating += new System.ComponentModel.CancelEventHandler(this.cboVaiTro_Validating);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = false;
            this.lblMatKhau.Location = new System.Drawing.Point(420, 60);
            this.lblMatKhau.Size = new System.Drawing.Size(150, 26);
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMatKhau.TabIndex = 8;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(575, 60);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Size = new System.Drawing.Size(230, 26);
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TabIndex = 9;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.AutoSize = true;
            this.chkTrangThai.Checked = true;
            this.chkTrangThai.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.chkTrangThai.Location = new System.Drawing.Point(575, 105);
            this.chkTrangThai.Size = new System.Drawing.Size(140, 23);
            this.chkTrangThai.Text = "Đang làm việc";
            this.chkTrangThai.UseVisualStyleBackColor = true;
            this.chkTrangThai.TabIndex = 10;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNV.FlatAppearance.BorderSize = 0;
            this.btnThemNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.ForeColor = System.Drawing.Color.White;
            this.btnThemNV.Image = global::BTL_LTTQ.Properties.Resources.nut_them;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNV.Location = new System.Drawing.Point(20, 152);
            this.btnThemNV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnThemNV.Size = new System.Drawing.Size(120, 38);
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.TabIndex = 11;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNV.FlatAppearance.BorderSize = 0;
            this.btnSuaNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNV.ForeColor = System.Drawing.Color.White;
            this.btnSuaNV.Image = global::BTL_LTTQ.Properties.Resources.nut_sua;
            this.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaNV.Location = new System.Drawing.Point(150, 152);
            this.btnSuaNV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnSuaNV.Size = new System.Drawing.Size(120, 38);
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.TabIndex = 12;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNV.FlatAppearance.BorderSize = 0;
            this.btnXoaNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.ForeColor = System.Drawing.Color.White;
            this.btnXoaNV.Image = global::BTL_LTTQ.Properties.Resources.nut_xoa;
            this.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaNV.Location = new System.Drawing.Point(280, 152);
            this.btnXoaNV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnXoaNV.Size = new System.Drawing.Size(120, 38);
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.TabIndex = 13;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnDatLaiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMatKhau.FlatAppearance.BorderSize = 0;
            this.btnDatLaiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMatKhau.ForeColor = System.Drawing.Color.White;
            this.btnDatLaiMatKhau.Image = global::BTL_LTTQ.Properties.Resources.nut_khoa;
            this.btnDatLaiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(410, 152);
            this.btnDatLaiMatKhau.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(200, 38);
            this.btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMatKhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnDatLaiMatKhau.TabIndex = 14;
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // btnLamMoiNV
            // 
            this.btnLamMoiNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnLamMoiNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNV.FlatAppearance.BorderSize = 0;
            this.btnLamMoiNV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiNV.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiNV.Image = global::BTL_LTTQ.Properties.Resources.nut_lammoi;
            this.btnLamMoiNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoiNV.Location = new System.Drawing.Point(620, 152);
            this.btnLamMoiNV.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnLamMoiNV.Size = new System.Drawing.Size(120, 38);
            this.btnLamMoiNV.Text = "Làm mới";
            this.btnLamMoiNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiNV.UseVisualStyleBackColor = false;
            this.btnLamMoiNV.TabIndex = 15;
            this.btnLamMoiNV.Click += new System.EventHandler(this.btnLamMoiNV_Click);
            // 
            // pnlTimNV
            // 
            this.pnlTimNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlTimNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimNV.Size = new System.Drawing.Size(100, 52);
            this.pnlTimNV.TabIndex = 2;
            this.pnlTimNV.Controls.Add(this.lblTimNV);
            this.pnlTimNV.Controls.Add(this.txtTimNV);
            // 
            // lblTimNV
            // 
            this.lblTimNV.AutoSize = false;
            this.lblTimNV.Location = new System.Drawing.Point(20, 13);
            this.lblTimNV.Size = new System.Drawing.Size(290, 26);
            this.lblTimNV.Text = "Tìm theo tên đăng nhập hoặc họ tên";
            this.lblTimNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTimNV.TabIndex = 0;
            // 
            // txtTimNV
            // 
            this.txtTimNV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimNV.Location = new System.Drawing.Point(320, 13);
            this.txtTimNV.Size = new System.Drawing.Size(300, 26);
            this.txtTimNV.TabIndex = 1;
            this.txtTimNV.TextChanged += new System.EventHandler(this.txtTimNV_TextChanged);
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Size = new System.Drawing.Size(100, 64);
            this.pnlTieuDe.TabIndex = 3;
            this.pnlTieuDe.Controls.Add(this.picTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            // 
            // picTieuDe
            // 
            this.picTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_nhanvien;
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
            this.lblTieuDe.Text = "Quản lý nhân viên";
            this.lblTieuDe.TabIndex = 1;
            // 
            // FrmNhanVien
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
            this.Text = "Quản lý nhân viên";
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.pnlNhapNV);
            this.Controls.Add(this.pnlTimNV);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmNhanVien";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.pnlNhapNV.ResumeLayout(false);
            this.pnlTimNV.ResumeLayout(false);
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTieuDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsNhanVien;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.Panel pnlNhapNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkTrangThai;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnDatLaiMatKhau;
        private System.Windows.Forms.Button btnLamMoiNV;
        private System.Windows.Forms.Panel pnlTimNV;
        private System.Windows.Forms.Label lblTimNV;
        private System.Windows.Forms.TextBox txtTimNV;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
