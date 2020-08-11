using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL_DAL;

namespace GUI
{
	public partial class frmBanHang : Form
	{
		BLL_BanHang bllBanHang = new BLL_BanHang();
		public frmBanHang()
		{
			InitializeComponent();
		}

		private void frmBanHang_Load(object sender, EventArgs e)
		{
			loadDatagridviewBanHang();
		}										
		void loadDatagridviewBanHang()
		{
			dataGridViewHDBanHang.DataSource = bllBanHang.loadDsHoaDonBan();
		}

		private void dataGridViewHDBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				string mahd = dataGridViewHDBanHang.CurrentRow.Cells[0].Value.ToString();
				dataGridViewChiTietBanHang.DataSource = bllBanHang.loadCTHoaDon(mahd);
			}
			catch (Exception)
			{
				
			
			}
			
		}




		private void dataGridViewHDBanHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void groupBan_Enter(object sender, EventArgs e)
		{

		}

        private void btnBanHang_Click_1(object sender, EventArgs e)
        {
			panelBottom.Width = btnBanHang.Width;
			panelBottom.Left = btnBanHang.Left;
			loadDatagridviewBanHang();

		}

        private void btnBanLeXe_Click_1(object sender, EventArgs e)
        {
			panelBottom.Width = btnBanLeXe.Width;
			panelBottom.Left = btnBanLeXe.Left;
		}

        private void btnBanLePhuTung_Click(object sender, EventArgs e)
        {
			panelBottom.Width = btnBanLePhuTung.Width;
			panelBottom.Left = btnBanLePhuTung.Left;
			dataGridViewHDBanHang.DataSource = bllBanHang.BanSiPT();
		}

        private void btnBanSiPhuTung_Click(object sender, EventArgs e)
        {
			panelBottom.Width = btnBanSiPhuTung.Width;
			panelBottom.Left = btnBanSiPhuTung.Left;
		}

        private void btnBanSiXeMay_Click_1(object sender, EventArgs e)
        {
			panelBottom.Width = btnBanSiXeMay.Width;
			panelBottom.Left = btnBanSiXeMay.Left;

		}
    }
}
