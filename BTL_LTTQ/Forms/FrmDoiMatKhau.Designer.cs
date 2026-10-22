namespace BTL_LTTQ
{
    partial class FrmDoiMatKhau
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
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.btnDoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTieuDe)).BeginInit();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = false;
            this.lblMatKhauCu.Location = new System.Drawing.Point(20, 92);
            this.lblMatKhauCu.Size = new System.Drawing.Size(175, 26);
            this.lblMatKhauCu.Text = "Mật khẩu hiện tại";
            this.lblMatKhauCu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMatKhauCu.TabIndex = 0;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(205, 92);
            this.txtMatKhauCu.MaxLength = 50;
            this.txtMatKhauCu.Size = new System.Drawing.Size(290, 26);
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            this.txtMatKhauCu.TabIndex = 1;
            this.txtMatKhauCu.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhauCu_Validating);
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = false;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(20, 142);
            this.lblMatKhauMoi.Size = new System.Drawing.Size(175, 26);
            this.lblMatKhauMoi.Text = "Mật khẩu mới";
            this.lblMatKhauMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMatKhauMoi.TabIndex = 2;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(205, 142);
            this.txtMatKhauMoi.MaxLength = 50;
            this.txtMatKhauMoi.Size = new System.Drawing.Size(290, 26);
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            this.txtMatKhauMoi.TabIndex = 3;
            this.txtMatKhauMoi.Validating += new System.ComponentModel.CancelEventHandler(this.txtMatKhauMoi_Validating);
            // 
            // lblXacNhan
            // 
            this.lblXacNhan.AutoSize = false;
            this.lblXacNhan.Location = new System.Drawing.Point(20, 192);
            this.lblXacNhan.Size = new System.Drawing.Size(175, 26);
            this.lblXacNhan.Text = "Nhập lại mật khẩu mới";
            this.lblXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblXacNhan.TabIndex = 4;
            // 
            // txtXacNhan
            // 
            this.txtXacNhan.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhan.Location = new System.Drawing.Point(205, 192);
            this.txtXacNhan.MaxLength = 50;
            this.txtXacNhan.Size = new System.Drawing.Size(290, 26);
            this.txtXacNhan.UseSystemPasswordChar = true;
            this.txtXacNhan.TabIndex = 5;
            this.txtXacNhan.Validating += new System.ComponentModel.CancelEventHandler(this.txtXacNhan_Validating);
            // 
            // btnDoi
            // 
            this.btnDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnDoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoi.FlatAppearance.BorderSize = 0;
            this.btnDoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoi.ForeColor = System.Drawing.Color.White;
            this.btnDoi.Image = global::BTL_LTTQ.Properties.Resources.nut_luu;
            this.btnDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoi.Location = new System.Drawing.Point(205, 254);
            this.btnDoi.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnDoi.Size = new System.Drawing.Size(170, 40);
            this.btnDoi.Text = "Đổi mật khẩu";
            this.btnDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoi.UseVisualStyleBackColor = false;
            this.btnDoi.TabIndex = 6;
            this.btnDoi.Click += new System.EventHandler(this.btnDoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::BTL_LTTQ.Properties.Resources.nut_huy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(385, 254);
            this.btnHuy.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnHuy.Size = new System.Drawing.Size(110, 40);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.TabIndex = 7;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Size = new System.Drawing.Size(100, 64);
            this.pnlTieuDe.TabIndex = 8;
            this.pnlTieuDe.Controls.Add(this.picTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            // 
            // picTieuDe
            // 
            this.picTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_doimatkhau;
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
            this.lblTieuDe.Text = "Đổi mật khẩu";
            this.lblTieuDe.TabIndex = 1;
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 316);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.AcceptButton = this.btnDoi;
            this.CancelButton = this.btnHuy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ShowInTaskbar = false;
            this.Controls.Add(this.lblMatKhauCu);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblXacNhan);
            this.Controls.Add(this.txtXacNhan);
            this.Controls.Add(this.btnDoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmDoiMatKhau";
            this.pnlTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTieuDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtXacNhan;
        private System.Windows.Forms.Button btnDoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
    }
}
