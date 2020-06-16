using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaiTapNhom_PhanMemQuanLyCHXeMay
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			frmDangNhap frm = new frmDangNhap();
			frm.Show();
		}

		private void btnMuaXe_Click(object sender, EventArgs e)
		{
			frmMuaXe frm_muaxe = new frmMuaXe();
			frm_muaxe.TopLevel = false;
			panelMain.Controls.Clear();
			panelMain.Controls.Add(frm_muaxe);
			frm_muaxe.Show();
			panelMain.Show();


		}

		private void TabTong_SelectedIndexChanged(object sender, EventArgs e)
		{
			frmSanPham frm_SanPham = new frmSanPham();
			panelSanPham.Controls.Clear();
			panelSanPham.Controls.Add(frm_SanPham);
			frm_SanPham.Show();
			panelSanPham.Show();

			frmKhachHang frm = new frmKhachHang();
			frm.TopLevel = false;
			tabKhachHang.Controls.Clear();
			tabKhachHang.Controls.Add(frm);
			frm.Show();
		}
	}
}
