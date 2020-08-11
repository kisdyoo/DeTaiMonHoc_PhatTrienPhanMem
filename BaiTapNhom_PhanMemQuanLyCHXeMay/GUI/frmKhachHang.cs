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
    public partial class frmKhachHang : Form
    {
        BLL_KhachHang khachHang_bll = new BLL_KhachHang();
        public frmKhachHang()
        {
            InitializeComponent();
        }

       void loadDataGridKH()
        {
            dataGridViewKH.DataSource = khachHang_bll.dsKhachHang();
            dataGridViewKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDataGridKH();
            foreach (Control ctrl in groupBoxKH.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = false;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = false;
                }
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;

            }
        }


        private void btnThem_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBoxKH.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                    ctrl.Enabled = true;
                }
                txtMaKH.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
            }
            if (dataGridViewKH.RowCount < 1)
            {
                txtMaKH.Text = "KH001";
            }
            else
                txtMaKH.Text = khachHang_bll.getMaKhachHang("KH00");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = dataGridViewKH.CurrentRow.Cells[0].Value.ToString();
            khachHang_bll.deleteKhachHang(maKH);
            loadDataGridKH();
            frmKhachHang_Load(sender, e);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBoxKH.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                }
                txtMaKH.Enabled = false;
                btnLuu.Enabled = true;
            }
            frmKhachHang_Load(sender, e);
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (khachHang_bll.kTraKhoaChinh(txtMaKH.Text))
            {
                khachHang_bll.addKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSoDT.Text);
            }
            else
                khachHang_bll.updateKhachHang(txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSoDT.Text);
            loadDataGridKH();
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int item = e.RowIndex;

            txtMaKH.Text = dataGridViewKH.Rows[item].Cells[0].Value.ToString();
            txtTenKH.Text = dataGridViewKH.Rows[item].Cells[1].Value.ToString();
            txtSoDT.Text = dataGridViewKH.Rows[item].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridViewKH.Rows[item].Cells[3].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridViewKH.DataSource =  khachHang_bll.timKiemKhachHang(txtTimKiem.Text);
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            loadDataGridKH();
            txtTimKiem.Clear();
        }

        private void groupBoxKH_Enter(object sender, EventArgs e)
        {

        }
    }
}
