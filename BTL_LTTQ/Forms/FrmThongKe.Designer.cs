namespace BTL_LTTQ
{
    partial class FrmThongKe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabThongKe = new System.Windows.Forms.TabControl();
            this.tabDoanhThu = new System.Windows.Forms.TabPage();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.dgvDichVuBanChay = new System.Windows.Forms.DataGridView();
            this.tabHoaDon = new System.Windows.Forms.TabPage();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.pnlLocHoaDon = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboHinhThuc = new System.Windows.Forms.ComboBox();
            this.pnlTong = new System.Windows.Forms.Panel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblSoHoaDon = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.pnlLoc = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.bsDoanhThu = new System.Windows.Forms.BindingSource(this.components);
            this.bsDichVuBanChay = new System.Windows.Forms.BindingSource(this.components);
            this.bsHoaDon = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVuBanChay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHoaDon)).BeginInit();
            this.tabThongKe.SuspendLayout();
            this.tabDoanhThu.SuspendLayout();
            this.tabDichVu.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            this.pnlLocHoaDon.SuspendLayout();
            this.pnlTong.SuspendLayout();
            this.pnlLoc.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.tabDoanhThu);
            this.tabThongKe.Controls.Add(this.tabDichVu);
            this.tabThongKe.Controls.Add(this.tabHoaDon);
            this.tabThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabThongKe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabThongKe.Location = new System.Drawing.Point(0, 124);
            this.tabThongKe.Padding = new System.Drawing.Point(14, 6);
            this.tabThongKe.SelectedIndex = 0;
            this.tabThongKe.Size = new System.Drawing.Size(1000, 476);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Name = "tabThongKe";
            // 
            // tabDoanhThu
            // 
            this.tabDoanhThu.Controls.Add(this.dgvDoanhThu);
            this.tabDoanhThu.BackColor = System.Drawing.Color.White;
            this.tabDoanhThu.Location = new System.Drawing.Point(4, 40);
            this.tabDoanhThu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDoanhThu.Size = new System.Drawing.Size(992, 484);
            this.tabDoanhThu.TabIndex = 0;
            this.tabDoanhThu.Text = "Doanh thu theo ngày";
            this.tabDoanhThu.Name = "tabDoanhThu";
            // 
            // dgvDoanhThu
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvDoanhThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AllowUserToDeleteRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDoanhThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersHeight = 38;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoanhThu.DataSource = this.bsDoanhThu;
            this.dgvDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoanhThu.EnableHeadersVisualStyles = false;
            this.dgvDoanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvDoanhThu.Location = new System.Drawing.Point(3, 3);
            this.dgvDoanhThu.MultiSelect = false;
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersVisible = false;
            this.dgvDoanhThu.RowTemplate.Height = 32;
            this.dgvDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu.Size = new System.Drawing.Size(986, 478);
            this.dgvDoanhThu.TabIndex = 0;
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.dgvDichVuBanChay);
            this.tabDichVu.BackColor = System.Drawing.Color.White;
            this.tabDichVu.Location = new System.Drawing.Point(4, 40);
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabDichVu.Size = new System.Drawing.Size(992, 484);
            this.tabDichVu.TabIndex = 1;
            this.tabDichVu.Text = "Dịch vụ bán chạy";
            this.tabDichVu.Name = "tabDichVu";
            // 
            // dgvDichVuBanChay
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVuBanChay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvDichVuBanChay.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVuBanChay.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDichVuBanChay.AllowUserToAddRows = false;
            this.dgvDichVuBanChay.AllowUserToDeleteRows = false;
            this.dgvDichVuBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVuBanChay.BackgroundColor = System.Drawing.Color.White;
            this.dgvDichVuBanChay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVuBanChay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVuBanChay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDichVuBanChay.ColumnHeadersHeight = 38;
            this.dgvDichVuBanChay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDichVuBanChay.DataSource = this.bsDichVuBanChay;
            this.dgvDichVuBanChay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVuBanChay.EnableHeadersVisualStyles = false;
            this.dgvDichVuBanChay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvDichVuBanChay.Location = new System.Drawing.Point(3, 3);
            this.dgvDichVuBanChay.MultiSelect = false;
            this.dgvDichVuBanChay.ReadOnly = true;
            this.dgvDichVuBanChay.RowHeadersVisible = false;
            this.dgvDichVuBanChay.RowTemplate.Height = 32;
            this.dgvDichVuBanChay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVuBanChay.Size = new System.Drawing.Size(986, 478);
            this.dgvDichVuBanChay.TabIndex = 0;
            this.dgvDichVuBanChay.Name = "dgvDichVuBanChay";
            // 
            // tabHoaDon
            // 
            this.tabHoaDon.Controls.Add(this.dgvHoaDon);
            this.tabHoaDon.Controls.Add(this.pnlLocHoaDon);
            this.tabHoaDon.BackColor = System.Drawing.Color.White;
            this.tabHoaDon.Location = new System.Drawing.Point(4, 40);
            this.tabHoaDon.Size = new System.Drawing.Size(992, 484);
            this.tabHoaDon.TabIndex = 2;
            this.tabHoaDon.Text = "Hóa đơn";
            this.tabHoaDon.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabHoaDon.Name = "tabHoaDon";
            // 
            // dgvHoaDon
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeight = 38;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHoaDon.DataSource = this.bsHoaDon;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 57);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowTemplate.Height = 32;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(986, 424);
            this.dgvHoaDon.TabIndex = 0;
            this.dgvHoaDon.Name = "dgvHoaDon";
            // 
            // pnlLocHoaDon
            // 
            this.pnlLocHoaDon.Controls.Add(this.label3);
            this.pnlLocHoaDon.Controls.Add(this.txtTimHoaDon);
            this.pnlLocHoaDon.Controls.Add(this.label4);
            this.pnlLocHoaDon.Controls.Add(this.cboHinhThuc);
            this.pnlLocHoaDon.BackColor = System.Drawing.Color.White;
            this.pnlLocHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLocHoaDon.Location = new System.Drawing.Point(3, 3);
            this.pnlLocHoaDon.Size = new System.Drawing.Size(986, 54);
            this.pnlLocHoaDon.TabIndex = 1;
            this.pnlLocHoaDon.Name = "pnlLocHoaDon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.Text = "Tên máy";
            this.label3.TabIndex = 0;
            this.label3.Name = "label3";
            // 
            // txtTimHoaDon
            // 
            this.txtTimHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimHoaDon.Location = new System.Drawing.Point(86, 12);
            this.txtTimHoaDon.Size = new System.Drawing.Size(190, 27);
            this.txtTimHoaDon.TabIndex = 1;
            this.txtTimHoaDon.Name = "txtTimHoaDon";
            this.txtTimHoaDon.TextChanged += new System.EventHandler(this.txtTimHoaDon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(310, 16);
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.Text = "Hình thức";
            this.label4.TabIndex = 2;
            this.label4.Name = "label4";
            // 
            // cboHinhThuc
            // 
            this.cboHinhThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHinhThuc.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHinhThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cboHinhThuc.FormattingEnabled = true;
            this.cboHinhThuc.Items.AddRange(new object[] {
            "Tất cả",
            "Tiền mặt",
            "Tài khoản"});
            this.cboHinhThuc.Location = new System.Drawing.Point(396, 12);
            this.cboHinhThuc.Size = new System.Drawing.Size(160, 27);
            this.cboHinhThuc.TabIndex = 3;
            this.cboHinhThuc.Name = "cboHinhThuc";
            this.cboHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cboHinhThuc_SelectedIndexChanged);
            // 
            // pnlTong
            // 
            this.pnlTong.Controls.Add(this.lblTongDoanhThu);
            this.pnlTong.Controls.Add(this.lblSoHoaDon);
            this.pnlTong.Controls.Add(this.btnDong);
            this.pnlTong.BackColor = System.Drawing.Color.White;
            this.pnlTong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTong.Location = new System.Drawing.Point(0, 600);
            this.pnlTong.Size = new System.Drawing.Size(1000, 60);
            this.pnlTong.TabIndex = 1;
            this.pnlTong.Name = "pnlTong";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(20, 12);
            this.lblTongDoanhThu.Size = new System.Drawing.Size(60, 19);
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0";
            this.lblTongDoanhThu.TabIndex = 0;
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            // 
            // lblSoHoaDon
            // 
            this.lblSoHoaDon.AutoSize = true;
            this.lblSoHoaDon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSoHoaDon.Location = new System.Drawing.Point(560, 20);
            this.lblSoHoaDon.Size = new System.Drawing.Size(60, 19);
            this.lblSoHoaDon.Text = "Số hóa đơn: 0";
            this.lblSoHoaDon.TabIndex = 1;
            this.lblSoHoaDon.Name = "lblSoHoaDon";
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
            this.btnDong.Location = new System.Drawing.Point(860, 10);
            this.btnDong.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.TabIndex = 2;
            this.btnDong.Name = "btnDong";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // pnlLoc
            // 
            this.pnlLoc.Controls.Add(this.label1);
            this.pnlLoc.Controls.Add(this.dtpTuNgay);
            this.pnlLoc.Controls.Add(this.label2);
            this.pnlLoc.Controls.Add(this.dtpDenNgay);
            this.pnlLoc.Controls.Add(this.btnXem);
            this.pnlLoc.BackColor = System.Drawing.Color.White;
            this.pnlLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLoc.Location = new System.Drawing.Point(0, 64);
            this.pnlLoc.Size = new System.Drawing.Size(1000, 60);
            this.pnlLoc.TabIndex = 2;
            this.pnlLoc.Name = "pnlLoc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.Text = "Từ ngày";
            this.label1.TabIndex = 0;
            this.label1.Name = "label1";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(90, 16);
            this.dtpTuNgay.Size = new System.Drawing.Size(130, 27);
            this.dtpTuNgay.TabIndex = 1;
            this.dtpTuNgay.Name = "dtpTuNgay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(240, 20);
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.Text = "Đến ngày";
            this.label2.TabIndex = 2;
            this.label2.Name = "label2";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(320, 16);
            this.dtpDenNgay.Size = new System.Drawing.Size(130, 27);
            this.dtpDenNgay.TabIndex = 3;
            this.dtpDenNgay.Name = "dtpDenNgay";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Image = global::BTL_LTTQ.Properties.Resources.nut_xem;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(480, 10);
            this.btnXem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnXem.Size = new System.Drawing.Size(180, 40);
            this.btnXem.Text = "Xem thống kê";
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.TabIndex = 4;
            this.btnXem.Name = "btnXem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.Controls.Add(this.picTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Size = new System.Drawing.Size(100, 64);
            this.pnlTieuDe.TabIndex = 3;
            this.pnlTieuDe.Name = "pnlTieuDe";
            // 
            // picTieuDe
            // 
            this.picTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_thongke;
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
            this.lblTieuDe.Text = "Thống kê doanh thu";
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // bsDoanhThu
            // 
            // 
            // bsDichVuBanChay
            // 
            // 
            // bsHoaDon
            // 
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thống kê doanh thu";
            this.Controls.Add(this.tabThongKe);
            this.Controls.Add(this.pnlTong);
            this.Controls.Add(this.pnlLoc);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmThongKe";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVuBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDichVuBanChay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHoaDon)).EndInit();
            this.tabThongKe.ResumeLayout(false);
            this.tabDoanhThu.ResumeLayout(false);
            this.tabDichVu.ResumeLayout(false);
            this.tabHoaDon.ResumeLayout(false);
            this.pnlLocHoaDon.ResumeLayout(false);
            this.pnlLocHoaDon.PerformLayout();
            this.pnlTong.ResumeLayout(false);
            this.pnlTong.PerformLayout();
            this.pnlLoc.ResumeLayout(false);
            this.pnlLoc.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabThongKe;
        private System.Windows.Forms.TabPage tabDoanhThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.DataGridView dgvDichVuBanChay;
        private System.Windows.Forms.TabPage tabHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel pnlLocHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboHinhThuc;
        private System.Windows.Forms.Panel pnlTong;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblSoHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel pnlLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.BindingSource bsDoanhThu;
        private System.Windows.Forms.BindingSource bsDichVuBanChay;
        private System.Windows.Forms.BindingSource bsHoaDon;
    }
}
