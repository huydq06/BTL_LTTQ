namespace BTL_LTTQ
{
    partial class FrmCaLam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCa = new System.Windows.Forms.DataGridView();
            this.pnlDuoi = new System.Windows.Forms.Panel();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblLichSu = new System.Windows.Forms.Label();
            this.grpCaHienTai = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTrangThaiCa = new System.Windows.Forms.Label();
            this.lblGioMo = new System.Windows.Forms.Label();
            this.lblTienDauCa = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblTienDuKien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudTienDauCa = new System.Windows.Forms.NumericUpDown();
            this.btnMoCa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudTienCuoiCa = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblChenhLech = new System.Windows.Forms.Label();
            this.btnDongCa = new System.Windows.Forms.Button();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.bsCa = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienDauCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienCuoiCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCa)).BeginInit();
            this.pnlDuoi.SuspendLayout();
            this.grpCaHienTai.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCa
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.dgvCa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCa.AllowUserToAddRows = false;
            this.dgvCa.AllowUserToDeleteRows = false;
            this.dgvCa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCa.BackgroundColor = System.Drawing.Color.White;
            this.dgvCa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCa.ColumnHeadersHeight = 38;
            this.dgvCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCa.DataSource = this.bsCa;
            this.dgvCa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCa.EnableHeadersVisualStyles = false;
            this.dgvCa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(231)))), ((int)(((byte)(235)))));
            this.dgvCa.Location = new System.Drawing.Point(0, 504);
            this.dgvCa.MultiSelect = false;
            this.dgvCa.ReadOnly = true;
            this.dgvCa.RowHeadersVisible = false;
            this.dgvCa.RowTemplate.Height = 32;
            this.dgvCa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCa.Size = new System.Drawing.Size(860, 160);
            this.dgvCa.TabIndex = 0;
            this.dgvCa.Name = "dgvCa";
            // 
            // pnlDuoi
            // 
            this.pnlDuoi.Controls.Add(this.btnDong);
            this.pnlDuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDuoi.Location = new System.Drawing.Point(0, 664);
            this.pnlDuoi.Size = new System.Drawing.Size(860, 56);
            this.pnlDuoi.TabIndex = 1;
            this.pnlDuoi.Name = "pnlDuoi";
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
            this.btnDong.Location = new System.Drawing.Point(722, 9);
            this.btnDong.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDong.Size = new System.Drawing.Size(120, 38);
            this.btnDong.Text = "Đóng";
            this.btnDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.TabIndex = 0;
            this.btnDong.Name = "btnDong";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblLichSu
            // 
            this.lblLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLichSu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichSu.Location = new System.Drawing.Point(0, 464);
            this.lblLichSu.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblLichSu.Size = new System.Drawing.Size(860, 40);
            this.lblLichSu.Text = "Lịch sử ca (50 ca gần nhất)";
            this.lblLichSu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLichSu.TabIndex = 2;
            this.lblLichSu.Name = "lblLichSu";
            // 
            // grpCaHienTai
            // 
            this.grpCaHienTai.Controls.Add(this.label1);
            this.grpCaHienTai.Controls.Add(this.label2);
            this.grpCaHienTai.Controls.Add(this.label3);
            this.grpCaHienTai.Controls.Add(this.label4);
            this.grpCaHienTai.Controls.Add(this.label5);
            this.grpCaHienTai.Controls.Add(this.lblTrangThaiCa);
            this.grpCaHienTai.Controls.Add(this.lblGioMo);
            this.grpCaHienTai.Controls.Add(this.lblTienDauCa);
            this.grpCaHienTai.Controls.Add(this.lblTongThu);
            this.grpCaHienTai.Controls.Add(this.lblTienDuKien);
            this.grpCaHienTai.Controls.Add(this.label6);
            this.grpCaHienTai.Controls.Add(this.nudTienDauCa);
            this.grpCaHienTai.Controls.Add(this.btnMoCa);
            this.grpCaHienTai.Controls.Add(this.label7);
            this.grpCaHienTai.Controls.Add(this.nudTienCuoiCa);
            this.grpCaHienTai.Controls.Add(this.label8);
            this.grpCaHienTai.Controls.Add(this.lblChenhLech);
            this.grpCaHienTai.Controls.Add(this.btnDongCa);
            this.grpCaHienTai.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCaHienTai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCaHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.grpCaHienTai.Location = new System.Drawing.Point(0, 64);
            this.grpCaHienTai.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.grpCaHienTai.Size = new System.Drawing.Size(860, 400);
            this.grpCaHienTai.TabStop = false;
            this.grpCaHienTai.Text = "Ca hiện tại";
            this.grpCaHienTai.TabIndex = 3;
            this.grpCaHienTai.Name = "grpCaHienTai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.Text = "Trạng thái";
            this.label1.TabIndex = 0;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.Text = "Giờ mở";
            this.label2.TabIndex = 1;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.Text = "Tiền đầu ca";
            this.label3.TabIndex = 2;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.Text = "Tổng thu";
            this.label4.TabIndex = 3;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(20, 182);
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.Text = "Tiền dự kiến trong két";
            this.label5.TabIndex = 4;
            this.label5.Name = "label5";
            // 
            // lblTrangThaiCa
            // 
            this.lblTrangThaiCa.AutoSize = true;
            this.lblTrangThaiCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThaiCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblTrangThaiCa.Location = new System.Drawing.Point(230, 38);
            this.lblTrangThaiCa.Size = new System.Drawing.Size(60, 19);
            this.lblTrangThaiCa.Text = "Chưa có ca mở";
            this.lblTrangThaiCa.TabIndex = 5;
            this.lblTrangThaiCa.Name = "lblTrangThaiCa";
            // 
            // lblGioMo
            // 
            this.lblGioMo.AutoSize = true;
            this.lblGioMo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioMo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblGioMo.Location = new System.Drawing.Point(230, 72);
            this.lblGioMo.Size = new System.Drawing.Size(60, 19);
            this.lblGioMo.Text = "";
            this.lblGioMo.TabIndex = 6;
            this.lblGioMo.Name = "lblGioMo";
            // 
            // lblTienDauCa
            // 
            this.lblTienDauCa.AutoSize = true;
            this.lblTienDauCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDauCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTienDauCa.Location = new System.Drawing.Point(230, 106);
            this.lblTienDauCa.Size = new System.Drawing.Size(60, 19);
            this.lblTienDauCa.Text = "";
            this.lblTienDauCa.TabIndex = 7;
            this.lblTienDauCa.Name = "lblTienDauCa";
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblTongThu.Location = new System.Drawing.Point(230, 136);
            this.lblTongThu.Size = new System.Drawing.Size(60, 19);
            this.lblTongThu.Text = "";
            this.lblTongThu.TabIndex = 8;
            this.lblTongThu.Name = "lblTongThu";
            // 
            // lblTienDuKien
            // 
            this.lblTienDuKien.AutoSize = true;
            this.lblTienDuKien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienDuKien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblTienDuKien.Location = new System.Drawing.Point(230, 174);
            this.lblTienDuKien.Size = new System.Drawing.Size(60, 19);
            this.lblTienDuKien.Text = "";
            this.lblTienDuKien.TabIndex = 9;
            this.lblTienDuKien.Name = "lblTienDuKien";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(20, 247);
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.Text = "Tiền đầu ca mới";
            this.label6.TabIndex = 10;
            this.label6.Name = "label6";
            // 
            // nudTienDauCa
            // 
            this.nudTienDauCa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTienDauCa.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTienDauCa.Location = new System.Drawing.Point(190, 243);
            this.nudTienDauCa.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudTienDauCa.Size = new System.Drawing.Size(160, 26);
            this.nudTienDauCa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTienDauCa.ThousandsSeparator = true;
            this.nudTienDauCa.TabIndex = 11;
            this.nudTienDauCa.Name = "nudTienDauCa";
            // 
            // btnMoCa
            // 
            this.btnMoCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnMoCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoCa.FlatAppearance.BorderSize = 0;
            this.btnMoCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoCa.ForeColor = System.Drawing.Color.White;
            this.btnMoCa.Image = global::BTL_LTTQ.Properties.Resources.nut_moca;
            this.btnMoCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoCa.Location = new System.Drawing.Point(190, 285);
            this.btnMoCa.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnMoCa.Size = new System.Drawing.Size(160, 42);
            this.btnMoCa.Text = "Mở ca";
            this.btnMoCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoCa.UseVisualStyleBackColor = false;
            this.btnMoCa.TabIndex = 12;
            this.btnMoCa.Name = "btnMoCa";
            this.btnMoCa.Click += new System.EventHandler(this.btnMoCa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label7.Location = new System.Drawing.Point(430, 247);
            this.label7.Size = new System.Drawing.Size(60, 19);
            this.label7.Text = "Tiền cuối ca thực tế";
            this.label7.TabIndex = 13;
            this.label7.Name = "label7";
            // 
            // nudTienCuoiCa
            // 
            this.nudTienCuoiCa.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTienCuoiCa.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTienCuoiCa.Location = new System.Drawing.Point(620, 243);
            this.nudTienCuoiCa.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTienCuoiCa.Size = new System.Drawing.Size(200, 26);
            this.nudTienCuoiCa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTienCuoiCa.ThousandsSeparator = true;
            this.nudTienCuoiCa.TabIndex = 14;
            this.nudTienCuoiCa.Name = "nudTienCuoiCa";
            this.nudTienCuoiCa.ValueChanged += new System.EventHandler(this.nudTienCuoiCa_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.label8.Location = new System.Drawing.Point(430, 292);
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.Text = "Chênh lệch";
            this.label8.TabIndex = 15;
            this.label8.Name = "label8";
            // 
            // lblChenhLech
            // 
            this.lblChenhLech.AutoSize = true;
            this.lblChenhLech.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChenhLech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblChenhLech.Location = new System.Drawing.Point(620, 285);
            this.lblChenhLech.Size = new System.Drawing.Size(60, 19);
            this.lblChenhLech.Text = "0";
            this.lblChenhLech.TabIndex = 16;
            this.lblChenhLech.Name = "lblChenhLech";
            // 
            // btnDongCa
            // 
            this.btnDongCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDongCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDongCa.FlatAppearance.BorderSize = 0;
            this.btnDongCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongCa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongCa.ForeColor = System.Drawing.Color.White;
            this.btnDongCa.Image = global::BTL_LTTQ.Properties.Resources.nut_dongca;
            this.btnDongCa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongCa.Location = new System.Drawing.Point(620, 335);
            this.btnDongCa.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDongCa.Size = new System.Drawing.Size(200, 42);
            this.btnDongCa.Text = "Đóng ca";
            this.btnDongCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDongCa.UseVisualStyleBackColor = false;
            this.btnDongCa.TabIndex = 17;
            this.btnDongCa.Name = "btnDongCa";
            this.btnDongCa.Click += new System.EventHandler(this.btnDongCa_Click);
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
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_calam;
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
            this.lblTieuDe.Text = "Ca làm việc";
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // bsCa
            // 
            // 
            // FrmCaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(860, 720);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(840, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ca làm việc";
            this.Controls.Add(this.dgvCa);
            this.Controls.Add(this.pnlDuoi);
            this.Controls.Add(this.lblLichSu);
            this.Controls.Add(this.grpCaHienTai);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmCaLam";
            this.Load += new System.EventHandler(this.FrmCaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienDauCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienCuoiCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCa)).EndInit();
            this.pnlDuoi.ResumeLayout(false);
            this.pnlDuoi.PerformLayout();
            this.grpCaHienTai.ResumeLayout(false);
            this.grpCaHienTai.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCa;
        private System.Windows.Forms.Panel pnlDuoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label lblLichSu;
        private System.Windows.Forms.GroupBox grpCaHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTrangThaiCa;
        private System.Windows.Forms.Label lblGioMo;
        private System.Windows.Forms.Label lblTienDauCa;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblTienDuKien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudTienDauCa;
        private System.Windows.Forms.Button btnMoCa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudTienCuoiCa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblChenhLech;
        private System.Windows.Forms.Button btnDongCa;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.BindingSource bsCa;
    }
}
