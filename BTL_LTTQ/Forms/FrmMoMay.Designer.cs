namespace BTL_LTTQ
{
    partial class FrmMoMay
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
            this.lblTenMay = new System.Windows.Forms.Label();
            this.lblGiaGio = new System.Windows.Forms.Label();
            this.grpKhach = new System.Windows.Forms.GroupBox();
            this.rdoVangLai = new System.Windows.Forms.RadioButton();
            this.rdoHoiVien = new System.Windows.Forms.RadioButton();
            this.cboHoiVien = new System.Windows.Forms.ComboBox();
            this.lblSoDu = new System.Windows.Forms.Label();
            this.btnMo = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.pnlTieuDe = new System.Windows.Forms.Panel();
            this.picTieuDe = new System.Windows.Forms.PictureBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.bsKhach = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsKhach)).BeginInit();
            this.grpKhach.SuspendLayout();
            this.pnlTieuDe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTenMay
            // 
            this.lblTenMay.AutoSize = true;
            this.lblTenMay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.lblTenMay.Location = new System.Drawing.Point(24, 82);
            this.lblTenMay.Size = new System.Drawing.Size(60, 19);
            this.lblTenMay.Text = "";
            this.lblTenMay.TabIndex = 0;
            this.lblTenMay.Name = "lblTenMay";
            // 
            // lblGiaGio
            // 
            this.lblGiaGio.AutoSize = true;
            this.lblGiaGio.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaGio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblGiaGio.Location = new System.Drawing.Point(26, 126);
            this.lblGiaGio.Size = new System.Drawing.Size(60, 19);
            this.lblGiaGio.Text = "";
            this.lblGiaGio.TabIndex = 1;
            this.lblGiaGio.Name = "lblGiaGio";
            // 
            // grpKhach
            // 
            this.grpKhach.Controls.Add(this.rdoVangLai);
            this.grpKhach.Controls.Add(this.rdoHoiVien);
            this.grpKhach.Controls.Add(this.cboHoiVien);
            this.grpKhach.Controls.Add(this.lblSoDu);
            this.grpKhach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKhach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.grpKhach.Location = new System.Drawing.Point(24, 168);
            this.grpKhach.Size = new System.Drawing.Size(412, 196);
            this.grpKhach.TabStop = false;
            this.grpKhach.Text = "Khách hàng";
            this.grpKhach.TabIndex = 2;
            this.grpKhach.Name = "grpKhach";
            // 
            // rdoVangLai
            // 
            this.rdoVangLai.AutoSize = true;
            this.rdoVangLai.Checked = true;
            this.rdoVangLai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVangLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.rdoVangLai.Location = new System.Drawing.Point(20, 38);
            this.rdoVangLai.Size = new System.Drawing.Size(210, 23);
            this.rdoVangLai.TabStop = true;
            this.rdoVangLai.Text = "Khách vãng lai (trả tiền sau)";
            this.rdoVangLai.UseVisualStyleBackColor = true;
            this.rdoVangLai.TabIndex = 0;
            this.rdoVangLai.Name = "rdoVangLai";
            // 
            // rdoHoiVien
            // 
            this.rdoHoiVien.AutoSize = true;
            this.rdoHoiVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHoiVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.rdoHoiVien.Location = new System.Drawing.Point(20, 74);
            this.rdoHoiVien.Size = new System.Drawing.Size(85, 23);
            this.rdoHoiVien.Text = "Hội viên";
            this.rdoHoiVien.UseVisualStyleBackColor = true;
            this.rdoHoiVien.TabIndex = 1;
            this.rdoHoiVien.Name = "rdoHoiVien";
            this.rdoHoiVien.CheckedChanged += new System.EventHandler(this.rdoHoiVien_CheckedChanged);
            // 
            // cboHoiVien
            // 
            this.cboHoiVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoiVien.Enabled = false;
            this.cboHoiVien.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoiVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.cboHoiVien.FormattingEnabled = true;
            this.cboHoiVien.Location = new System.Drawing.Point(40, 108);
            this.cboHoiVien.Size = new System.Drawing.Size(350, 27);
            this.cboHoiVien.TabIndex = 2;
            this.cboHoiVien.Name = "cboHoiVien";
            this.cboHoiVien.SelectedIndexChanged += new System.EventHandler(this.cboHoiVien_SelectedIndexChanged);
            // 
            // lblSoDu
            // 
            this.lblSoDu.AutoSize = true;
            this.lblSoDu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.lblSoDu.Location = new System.Drawing.Point(40, 152);
            this.lblSoDu.Size = new System.Drawing.Size(60, 19);
            this.lblSoDu.Text = "Số dư: –";
            this.lblSoDu.TabIndex = 3;
            this.lblSoDu.Name = "lblSoDu";
            // 
            // btnMo
            // 
            this.btnMo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnMo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMo.FlatAppearance.BorderSize = 0;
            this.btnMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMo.ForeColor = System.Drawing.Color.White;
            this.btnMo.Image = global::BTL_LTTQ.Properties.Resources.nut_momay;
            this.btnMo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMo.Location = new System.Drawing.Point(190, 396);
            this.btnMo.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnMo.Size = new System.Drawing.Size(130, 42);
            this.btnMo.Text = "Mở máy";
            this.btnMo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMo.UseVisualStyleBackColor = false;
            this.btnMo.TabIndex = 3;
            this.btnMo.Name = "btnMo";
            this.btnMo.Click += new System.EventHandler(this.btnMo_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::BTL_LTTQ.Properties.Resources.nut_huy;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(336, 396);
            this.btnHuy.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btnHuy.Size = new System.Drawing.Size(100, 42);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Name = "btnHuy";
            // 
            // pnlTieuDe
            // 
            this.pnlTieuDe.Controls.Add(this.picTieuDe);
            this.pnlTieuDe.Controls.Add(this.lblTieuDe);
            this.pnlTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.pnlTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTieuDe.Location = new System.Drawing.Point(0, 0);
            this.pnlTieuDe.Size = new System.Drawing.Size(100, 64);
            this.pnlTieuDe.TabIndex = 5;
            this.pnlTieuDe.Name = "pnlTieuDe";
            // 
            // picTieuDe
            // 
            this.picTieuDe.BackColor = System.Drawing.Color.Transparent;
            this.picTieuDe.Image = global::BTL_LTTQ.Properties.Resources.tieude_may;
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
            this.lblTieuDe.Text = "Mở máy";
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Name = "lblTieuDe";
            // 
            // bsKhach
            // 
            // 
            // FrmMoMay
            // 
            this.AcceptButton = this.btnMo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(460, 462);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.Icon = global::BTL_LTTQ.Properties.Resources.app;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mở máy";
            this.Controls.Add(this.lblTenMay);
            this.Controls.Add(this.lblGiaGio);
            this.Controls.Add(this.grpKhach);
            this.Controls.Add(this.btnMo);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.pnlTieuDe);
            this.Name = "FrmMoMay";
            this.Load += new System.EventHandler(this.FrmMoMay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsKhach)).EndInit();
            this.grpKhach.ResumeLayout(false);
            this.grpKhach.PerformLayout();
            this.pnlTieuDe.ResumeLayout(false);
            this.pnlTieuDe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenMay;
        private System.Windows.Forms.Label lblGiaGio;
        private System.Windows.Forms.GroupBox grpKhach;
        private System.Windows.Forms.RadioButton rdoVangLai;
        private System.Windows.Forms.RadioButton rdoHoiVien;
        private System.Windows.Forms.ComboBox cboHoiVien;
        private System.Windows.Forms.Label lblSoDu;
        private System.Windows.Forms.Button btnMo;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlTieuDe;
        private System.Windows.Forms.PictureBox picTieuDe;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.BindingSource bsKhach;
    }
}
