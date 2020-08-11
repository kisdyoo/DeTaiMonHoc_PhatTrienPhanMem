namespace GUI
{
    partial class frmKhachHang
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
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBoxKH = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewKH = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBoxKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoaTK);
            this.groupBox3.Controls.Add(this.btnTimKiem);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(1026, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 88);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm nhân viên";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(363, 28);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(37, 34);
            this.btnXoaTK.TabIndex = 2;
            this.btnXoaTK.Text = "X";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(249, 28);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(108, 34);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(15, 32);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(217, 27);
            this.txtTimKiem.TabIndex = 0;
            // 
            // groupBoxKH
            // 
            this.groupBoxKH.Controls.Add(this.btnLuu);
            this.groupBoxKH.Controls.Add(this.btnSua);
            this.groupBoxKH.Controls.Add(this.btnXoa);
            this.groupBoxKH.Controls.Add(this.btnThem);
            this.groupBoxKH.Controls.Add(this.txtDiaChi);
            this.groupBoxKH.Controls.Add(this.label6);
            this.groupBoxKH.Controls.Add(this.txtSoDT);
            this.groupBoxKH.Controls.Add(this.label7);
            this.groupBoxKH.Controls.Add(this.groupBox3);
            this.groupBoxKH.Controls.Add(this.txtTenKH);
            this.groupBoxKH.Controls.Add(this.label8);
            this.groupBoxKH.Controls.Add(this.txtMaKH);
            this.groupBoxKH.Controls.Add(this.label9);
            this.groupBoxKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxKH.Location = new System.Drawing.Point(30, 59);
            this.groupBoxKH.Name = "groupBoxKH";
            this.groupBoxKH.Size = new System.Drawing.Size(1484, 204);
            this.groupBoxKH.TabIndex = 26;
            this.groupBoxKH.TabStop = false;
            this.groupBoxKH.Text = "Thông tin khách hàng ";
            this.groupBoxKH.Enter += new System.EventHandler(this.groupBoxKH_Enter);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(470, 134);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(119, 53);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(322, 134);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 53);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(680, 80);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(285, 27);
            this.txtDiaChi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(509, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Địa chỉ: ";
            // 
            // txtSoDT
            // 
            this.txtSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(680, 37);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(285, 27);
            this.txtSoDT.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số điện thoại: ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(193, 80);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(262, 27);
            this.txtTenKH.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên khách hàng: ";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(193, 37);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(262, 27);
            this.txtMaKH.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mã khách hàng: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(537, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(360, 32);
            this.label10.TabIndex = 25;
            this.label10.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dataGridViewKH
            // 
            this.dataGridViewKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKH.Location = new System.Drawing.Point(30, 269);
            this.dataGridViewKH.Name = "dataGridViewKH";
            this.dataGridViewKH.RowHeadersWidth = 51;
            this.dataGridViewKH.RowTemplate.Height = 24;
            this.dataGridViewKH.Size = new System.Drawing.Size(1484, 345);
            this.dataGridViewKH.TabIndex = 24;
            this.dataGridViewKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKH_CellClick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1533, 652);
            this.Controls.Add(this.groupBoxKH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewKH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxKH.ResumeLayout(false);
            this.groupBoxKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBoxKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewKH;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoaTK;
    }
}