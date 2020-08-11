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
    public partial class frmMain1 : Form
    {
        public frmMain1()
        {
            InitializeComponent();
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            frmBanHang frmBanHang = new frmBanHang();
            frmBanHang.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmBanHang);
            frmBanHang.Show();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
                Button btn = sender as Button;
            changecolorButtonMenu(btn);
            frmBanHang frmBanHang = new frmBanHang();
            frmBanHang.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(frmBanHang);
            frmBanHang.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Button btn = sender as Button;
            changecolorButtonMenu(btn);
            formSanPham frmSP = new formSanPham();
            frmSP.TopLevel = false;
            panelMain.Controls.Add(frmSP);
            frmSP.Show();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Button btn = sender as Button;
            changecolorButtonMenu(btn);
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDM.TopLevel = false;
            panelMain.Controls.Add(frmDM);
            frmDM.Show();
            
        }

        private void btnKhoHang_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            changecolorButtonMenu(btn);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            changecolorButtonMenu(btn);
        }

        private void btnThuChi_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            changecolorButtonMenu(btn);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            changecolorButtonMenu(btn);
        }

        void changecolorButtonMenu(Button btn)
        {
            btnBanHang.BackColor = btnBaoCao.BackColor = btnDanhMuc.BackColor= btnSanPham.BackColor = btnKhoHang.BackColor = btnSetting.BackColor = btnThuChi.BackColor = ColorTranslator.FromHtml("#00FFFFFF");
            btn.BackColor = ColorTranslator.FromHtml("#03ebfc");
        }
    }
}
