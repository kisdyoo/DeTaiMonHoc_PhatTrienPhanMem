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
    public partial class frmNhanVien : Form
    {
        BLL_NhanVien nhanVien_BLL = new BLL_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBoxNV.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                    ctrl.Enabled = true;
                }
                txtMaNV.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
            }
            if (dataGridViewNV.RowCount < 1)
            {
                txtMaNV.Text = "NV001";
            }
            else
                txtMaNV.Text = nhanVien_BLL.getMaNhanVien("NV00");
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadCboGioiTinh();
            loadDataGridNV();
            foreach (Control ctrl in groupBoxNV.Controls)
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
        void loadCboGioiTinh()
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = dataGridViewNV.CurrentRow.Cells[0].Value.ToString();
            nhanVien_BLL.deleteNhanVien(maNV);
            loadDataGridNV();
            frmNhanVien_Load(sender, e);
        }

        private void loadDataGridNV()
        {
            dataGridViewNV.DataSource = nhanVien_BLL.dsNhanVien();
            dataGridViewNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupBoxNV.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                }
                txtMaNV.Enabled = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (nhanVien_BLL.kTraKhoaChinh(txtMaNV.Text))
            {
                nhanVien_BLL.addNhanVien(txtMaNV.Text, txtTenNV.Text,cboGioiTinh.Text, txtDiaChi.Text, txtSoDienThoai.Text, Int32.Parse(txtLuongCB.Text)); 
            }
            else
                nhanVien_BLL.updateNhanVien(txtMaNV.Text, txtTenNV.Text, cboGioiTinh.Text, txtDiaChi.Text, txtSoDienThoai.Text, Int32.Parse(txtLuongCB.Text));
            loadDataGridNV();
            frmNhanVien_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dataGridViewNV.DataSource = nhanVien_BLL.timKiemNhanVien(txtTimKiem.Text);
        }

        private void dataGridViewNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int item = e.RowIndex;

            txtMaNV.Text = dataGridViewNV.Rows[item].Cells[0].Value.ToString();
            txtTenNV.Text = dataGridViewNV.Rows[item].Cells[1].Value.ToString();
            cboGioiTinh.Text = dataGridViewNV.Rows[item].Cells[2].Value.ToString();
            txtSoDienThoai.Text = dataGridViewNV.Rows[item].Cells[3].Value.ToString();
            txtDiaChi.Text = dataGridViewNV.Rows[item].Cells[4].Value.ToString();
            txtLuongCB.Text = dataGridViewNV.Rows[item].Cells[5].Value.ToString();
        }
    }
}
