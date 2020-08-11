using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
	public partial class frmMain : Form
	{
		formSanPham frmSP = new formSanPham();
		public frmMain()
		{
			InitializeComponent();
		}

		private void TabMain_Click(object sender, EventArgs e)
		{
			
		}
		void addFormSanPham()
		{
			frmSP.TopLevel = false;
			tabSanPham.Controls.Add(frmSP);
			frmSP.Show();
		}
		void addFormBanHang()
		{
			frmBanHang frm = new frmBanHang();
			frm.TopLevel = false;
			tabBanHang.Controls.Add(frm);
			frm.Show();
		}
		void addFormHeThong()
		{
			frmHeThong frm = new frmHeThong();
			frm.TopLevel = false;
			tabHeThong.Controls.Add(frm);
			frm.Show();
		}
		void addFormDanhMuc()
		{
			frmDanhMuc frm = new frmDanhMuc();
			frm.TopLevel = false;
			tabKH_NV.Controls.Add(frm);
			frm.Show();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			addFormBanHang();
			addFormSanPham();
			addFormHeThong();
			addFormDanhMuc();

		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmDangNhap frm = new frmDangNhap();
			frm.Show();
		}

		private void frmMain_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Maximized)
			{
				frmSP.Size = new Size(1900,960);
			}
		}

	}
}
