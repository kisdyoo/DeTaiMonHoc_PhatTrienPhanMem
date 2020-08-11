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
    public partial class frmDanhMuc : Form
    {
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panelDanhMuc.Controls.Clear();
            panelBottom.Width = btnNhanVien.Width;
            panelBottom.Left = btnNhanVien.Left;
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.TopLevel = false;
            panelDanhMuc.Controls.Add(frmNV);
            frmNV.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panelDanhMuc.Controls.Clear();
            panelBottom.Width = btnKhachHang.Width;
            panelBottom.Left = btnKhachHang.Left;
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.TopLevel = false;
            panelDanhMuc.Controls.Add(frmKH);
            frmKH.Show();
        }

        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            btnNhanVien_Click(sender, e);
        }
    }
}
