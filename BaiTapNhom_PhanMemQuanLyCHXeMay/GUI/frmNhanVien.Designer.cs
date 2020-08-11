namespace GUI
{
    partial class frmNhanVien
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBoxNV = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewNV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLuongCB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuyTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.groupBoxNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnHuyTimKiem);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1128, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 81);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nhân viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(174, 33);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 30);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(6, 35);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(162, 27);
            this.txtTimKiem.TabIndex = 0;
            // 
            // groupBoxNV
            // 
            this.groupBoxNV.Controls.Add(this.cboGioiTinh);
            this.groupBoxNV.Controls.Add(this.btnLuu);
            this.groupBoxNV.Controls.Add(this.btnSua);
            this.groupBoxNV.Controls.Add(this.btnXoa);
            this.groupBoxNV.Controls.Add(this.btnThem);
            this.groupBoxNV.Controls.Add(this.txtLuongCB);
            this.groupBoxNV.Controls.Add(this.label2);
            this.groupBoxNV.Controls.Add(this.label1);
            this.groupBoxNV.Controls.Add(this.groupBox3);
            this.groupBoxNV.Controls.Add(this.txtDiaChi);
            this.groupBoxNV.Controls.Add(this.label6);
            this.groupBoxNV.Controls.Add(this.txtSoDienThoai);
            this.groupBoxNV.Controls.Add(this.label7);
            this.groupBoxNV.Controls.Add(this.txtTenNV);
            this.groupBoxNV.Controls.Add(this.label8);
            this.groupBoxNV.Controls.Add(this.txtMaNV);
            this.groupBoxNV.Controls.Add(this.label9);
            this.groupBoxNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNV.Location = new System.Drawing.Point(30, 59);
            this.groupBoxNV.Name = "groupBoxNV";
            this.groupBoxNV.Size = new System.Drawing.Size(1484, 204);
            this.groupBoxNV.TabIndex = 26;
            this.groupBoxNV.TabStop = false;
            this.groupBoxNV.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(850, 35);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 27);
            this.txtDiaChi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(711, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Địa chỉ: ";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDienThoai.Location = new System.Drawing.Point(524, 81);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(158, 27);
            this.txtSoDienThoai.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(386, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số điện thoại: ";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(162, 80);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(200, 27);
            this.txtTenNV.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên nhân viên: ";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(162, 37);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 27);
            this.txtMaNV.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã nhân viên: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // dataGridViewNV
            // 
            this.dataGridViewNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNV.Location = new System.Drawing.Point(30, 269);
            this.dataGridViewNV.Name = "dataGridViewNV";
            this.dataGridViewNV.RowHeadersWidth = 51;
            this.dataGridViewNV.RowTemplate.Height = 24;
            this.dataGridViewNV.Size = new System.Drawing.Size(1484, 345);
            this.dataGridViewNV.TabIndex = 24;
            this.dataGridViewNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNV_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Giới tính: ";
            // 
            // txtLuongCB
            // 
            this.txtLuongCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuongCB.Location = new System.Drawing.Point(850, 78);
            this.txtLuongCB.Name = "txtLuongCB";
            this.txtLuongCB.Size = new System.Drawing.Size(250, 27);
            this.txtLuongCB.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(711, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Lương cơ bản: ";
            // 
            // btnHuyTimKiem
            // 
            this.btnHuyTimKiem.Location = new System.Drawing.Point(288, 33);
            this.btnHuyTimKiem.Name = "btnHuyTimKiem";
            this.btnHuyTimKiem.Size = new System.Drawing.Size(38, 30);
            this.btnHuyTimKiem.TabIndex = 2;
            this.btnHuyTimKiem.Text = "X";
            this.btnHuyTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(470, 134);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 53);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(322, 134);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 53);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 134);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 53);
            this.btnXoa.TabIndex = 33;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 134);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 53);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(524, 36);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(158, 28);
            this.cboGioiTinh.TabIndex = 36;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1533, 652);
            this.Controls.Add(this.groupBoxNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxNV.ResumeLayout(false);
            this.groupBoxNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBoxNV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtLuongCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboGioiTinh;
    }
}