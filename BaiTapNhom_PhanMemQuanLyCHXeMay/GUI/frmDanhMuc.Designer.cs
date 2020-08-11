namespace GUI
{
    partial class frmDanhMuc
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblBanHang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panelDanhMuc = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.lblBanHang);
            this.panel2.Location = new System.Drawing.Point(-12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1580, 56);
            this.panel2.TabIndex = 28;
            // 
            // lblBanHang
            // 
            this.lblBanHang.AutoSize = true;
            this.lblBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanHang.Location = new System.Drawing.Point(661, 12);
            this.lblBanHang.Name = "lblBanHang";
            this.lblBanHang.Size = new System.Drawing.Size(176, 36);
            this.lblBanHang.TabIndex = 0;
            this.lblBanHang.Text = "DANH MỤC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(-10, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 4);
            this.panel1.TabIndex = 29;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelBottom.Location = new System.Drawing.Point(-12, 116);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(236, 13);
            this.panelBottom.TabIndex = 27;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Location = new System.Drawing.Point(224, 62);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(241, 53);
            this.btnKhachHang.TabIndex = 26;
            this.btnKhachHang.Text = "KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Location = new System.Drawing.Point(-8, 62);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(234, 53);
            this.btnNhanVien.TabIndex = 25;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // panelDanhMuc
            // 
            this.panelDanhMuc.Location = new System.Drawing.Point(12, 139);
            this.panelDanhMuc.Name = "panelDanhMuc";
            this.panelDanhMuc.Size = new System.Drawing.Size(1533, 652);
            this.panelDanhMuc.TabIndex = 30;
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 803);
            this.Controls.Add(this.panelDanhMuc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhMuc";
            this.Text = "frmDanhMuc";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBanHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Panel panelDanhMuc;
    }
}