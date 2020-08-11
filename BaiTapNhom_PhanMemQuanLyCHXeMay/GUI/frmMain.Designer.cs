namespace GUI
{
	partial class frmMain
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
			this.TabMain = new System.Windows.Forms.TabControl();
			this.tabBanHang = new System.Windows.Forms.TabPage();
			this.tabMuaHang = new System.Windows.Forms.TabPage();
			this.tabSanPham = new System.Windows.Forms.TabPage();
			this.tabKho = new System.Windows.Forms.TabPage();
			this.tabKH_NV = new System.Windows.Forms.TabPage();
			this.tabBaoCao = new System.Windows.Forms.TabPage();
			this.tabHeThong = new System.Windows.Forms.TabPage();
			this.TabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// TabMain
			// 
			this.TabMain.Controls.Add(this.tabBanHang);
			this.TabMain.Controls.Add(this.tabMuaHang);
			this.TabMain.Controls.Add(this.tabSanPham);
			this.TabMain.Controls.Add(this.tabKho);
			this.TabMain.Controls.Add(this.tabKH_NV);
			this.TabMain.Controls.Add(this.tabBaoCao);
			this.TabMain.Controls.Add(this.tabHeThong);
			this.TabMain.Location = new System.Drawing.Point(0, 0);
			this.TabMain.Name = "TabMain";
			this.TabMain.Padding = new System.Drawing.Point(45, 15);
			this.TabMain.SelectedIndex = 0;
			this.TabMain.Size = new System.Drawing.Size(1581, 851);
			this.TabMain.TabIndex = 0;
			this.TabMain.Click += new System.EventHandler(this.TabMain_Click);
			// 
			// tabBanHang
			// 
			this.tabBanHang.Location = new System.Drawing.Point(4, 49);
			this.tabBanHang.Name = "tabBanHang";
			this.tabBanHang.Padding = new System.Windows.Forms.Padding(3);
			this.tabBanHang.Size = new System.Drawing.Size(1573, 798);
			this.tabBanHang.TabIndex = 0;
			this.tabBanHang.Text = "BÁN HÀNG";
			this.tabBanHang.UseVisualStyleBackColor = true;
			// 
			// tabMuaHang
			// 
			this.tabMuaHang.Location = new System.Drawing.Point(4, 49);
			this.tabMuaHang.Name = "tabMuaHang";
			this.tabMuaHang.Padding = new System.Windows.Forms.Padding(3);
			this.tabMuaHang.Size = new System.Drawing.Size(1573, 798);
			this.tabMuaHang.TabIndex = 1;
			this.tabMuaHang.Text = "MUA HÀNG";
			this.tabMuaHang.UseVisualStyleBackColor = true;
			// 
			// tabSanPham
			// 
			this.tabSanPham.Location = new System.Drawing.Point(4, 49);
			this.tabSanPham.Name = "tabSanPham";
			this.tabSanPham.Padding = new System.Windows.Forms.Padding(3);
			this.tabSanPham.Size = new System.Drawing.Size(1573, 798);
			this.tabSanPham.TabIndex = 2;
			this.tabSanPham.Text = "SẢN PHẨM";
			this.tabSanPham.UseVisualStyleBackColor = true;
			// 
			// tabKho
			// 
			this.tabKho.Location = new System.Drawing.Point(4, 49);
			this.tabKho.Name = "tabKho";
			this.tabKho.Padding = new System.Windows.Forms.Padding(3);
			this.tabKho.Size = new System.Drawing.Size(1573, 798);
			this.tabKho.TabIndex = 3;
			this.tabKho.Text = "KHO";
			this.tabKho.UseVisualStyleBackColor = true;
			// 
			// tabKH_NV
			// 
			this.tabKH_NV.Location = new System.Drawing.Point(4, 49);
			this.tabKH_NV.Name = "tabKH_NV";
			this.tabKH_NV.Padding = new System.Windows.Forms.Padding(3);
			this.tabKH_NV.Size = new System.Drawing.Size(1573, 798);
			this.tabKH_NV.TabIndex = 4;
			this.tabKH_NV.Text = "DANH MỤC";
			this.tabKH_NV.UseVisualStyleBackColor = true;
			// 
			// tabBaoCao
			// 
			this.tabBaoCao.Location = new System.Drawing.Point(4, 49);
			this.tabBaoCao.Name = "tabBaoCao";
			this.tabBaoCao.Padding = new System.Windows.Forms.Padding(3);
			this.tabBaoCao.Size = new System.Drawing.Size(1573, 798);
			this.tabBaoCao.TabIndex = 5;
			this.tabBaoCao.Text = "BÁO CÁO";
			this.tabBaoCao.UseVisualStyleBackColor = true;
			// 
			// tabHeThong
			// 
			this.tabHeThong.Location = new System.Drawing.Point(4, 49);
			this.tabHeThong.Name = "tabHeThong";
			this.tabHeThong.Padding = new System.Windows.Forms.Padding(3);
			this.tabHeThong.Size = new System.Drawing.Size(1573, 798);
			this.tabHeThong.TabIndex = 6;
			this.tabHeThong.Text = "HỆ THỐNG";
			this.tabHeThong.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1582, 853);
			this.Controls.Add(this.TabMain);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.TabMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl TabMain;
		private System.Windows.Forms.TabPage tabBanHang;
		private System.Windows.Forms.TabPage tabMuaHang;
		private System.Windows.Forms.TabPage tabSanPham;
		private System.Windows.Forms.TabPage tabKho;
		private System.Windows.Forms.TabPage tabKH_NV;
		private System.Windows.Forms.TabPage tabBaoCao;
		private System.Windows.Forms.TabPage tabHeThong;
	}
}

