namespace BTL_LTTQ
{
    partial class FrmDangNhap
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
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhu = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBanner.Image = global::BTL_LTTQ.Properties.Resources.banner_dangnhap;
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Size = new System.Drawing.Size(260, 340);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanner.TabStop = false;
            this.picBanner.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.lblTieuDe.Location = new System.Drawing.Point(296, 18);
            this.lblTieuDe.Size = new System.Drawing.Size(150, 41);
            this.lblTieuDe.Text = "Xin chào!";
            this.lblTieuDe.TabIndex = 1;
            // 
            // lblPhu
            // 
            this.lblPhu.AutoSize = true;
            this.lblPhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblPhu.Location = new System.Drawing.Point(300, 66);
            this.lblPhu.Size = new System.Drawing.Size(220, 19);
            this.lblPhu.Text = "Đăng nhập để bắt đầu làm việc";
            this.lblPhu.TabIndex = 2;
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = false;
            this.lblTenDangNhap.Location = new System.Drawing.Point(300, 104);
            this.lblTenDangNhap.Size = new System.Drawing.Size(304, 22);
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            this.lblTenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblTenDangNhap.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Location = new System.Drawing.Point(300, 128);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Size = new System.Drawing.Size(304, 26);
            this.txtTenDangNhap.TabIndex = 4;
            this.txtTenDangNhap.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenDangNhap_Validating);
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = false;
            this.lblMatKhau.Location = new System.Drawing.Point(300, 166);
            this.lblMatKhau.Size = new System.Drawing.Size(304, 22);
            this.lblMatKhau.Text = "Mật khẩu";
            this.lblMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMatKhau.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(300, 190);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Size = new System.Drawing.Size(304, 26);
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TabIndex = 6;
            this.txtMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhau_Validating);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Image = global::BTL_LTTQ.Properties.Resources.nut_dangnhap;
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(300, 240);
            this.btnDangNhap.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDangNhap.Size = new System.Drawing.Size(304, 42);
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::BTL_LTTQ.Properties.Resources.nut_huy;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(300, 290);
            this.btnThoat.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnThoat.Size = new System.Drawing.Size(304, 34);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.TabIndex = 8;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 356);
            this.AcceptButton = this.btnDangNhap;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnThoat;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblPhu);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnThoat);
            this.Name = "FrmDangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhu;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider err;
    }
}
