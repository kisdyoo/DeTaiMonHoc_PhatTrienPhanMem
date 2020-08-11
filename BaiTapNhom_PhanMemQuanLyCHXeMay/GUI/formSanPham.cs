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
    public partial class formSanPham : Form
    {
        BLL_SanPham bllSP = new BLL_SanPham();
        BLL_NhaCungCap bllNhaCungCap = new BLL_NhaCungCap();
        BLL_NhaSanXuat bllNhaSanXuat = new BLL_NhaSanXuat();
        BLL_LoaiSP bllLoaiSP = new BLL_LoaiSP();
        public formSanPham()
        {
            InitializeComponent();
        }

        private void formSanPham_Load(object sender, EventArgs e)
        {
            loadCboTimKiem();
            loadDatagridViewSP();
            LoadCboNCC();
            LoadCboNSX();
            LoadCboMaLoai();
            foreach (Control ctrl in groupThongTInSP.Controls)
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
        void loadCboTimKiem()
        {
            cboTimKiem.SelectedItem = "Mã sản phẩm";
        }
        void loadDatagridViewSP()
        {
            dataGridViewSanPham.DataSource = bllSP.loadDSSanPham();
            dataGridViewSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadCboNCC()
        {
            cboNCC.DataSource = bllNhaCungCap.loadDSNhaCungCap();
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }
        void LoadCboNSX()
        {

            cboNSX.DataSource = bllNhaSanXuat.loadDSNhaSanXuat();
            cboNSX.DisplayMember = "TenNSX";
            cboNSX.ValueMember = "MaNSX";
        }
        void LoadCboMaLoai()
        {

            cboMaLoai.DataSource = bllLoaiSP.loadDSMaLoai();
            cboMaLoai.DisplayMember = "TenLoai";
            cboMaLoai.ValueMember = "MaLoai";
        }

        private void dataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int item;
            item = e.RowIndex;
            try
            {
                txtMaSanPham.Text = dataGridViewSanPham.Rows[item].Cells[0].Value.ToString();
                txtTenSanPham.Text = dataGridViewSanPham.Rows[item].Cells[1].Value.ToString();
                txtDonGia.Text = dataGridViewSanPham.Rows[item].Cells[2].Value.ToString();
                txtSoLuong.Text = dataGridViewSanPham.Rows[item].Cells[3].Value.ToString();
                cboNCC.SelectedValue = dataGridViewSanPham.Rows[item].Cells[4].Value;
                cboNSX.SelectedValue = dataGridViewSanPham.Rows[item].Cells[5].Value;
                txtBaoHanh.Text = dataGridViewSanPham.Rows[item].Cells[6].Value.ToString();
                cboMaLoai.SelectedValue = dataGridViewSanPham.Rows[item].Cells[7].Value;
                txtMota.Text = dataGridViewSanPham.Rows[item].Cells[8].Value.ToString();

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch
            {


            }


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupThongTInSP.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = null;
            }
            txtMaSanPham.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = dataGridViewSanPham.CurrentRow.Cells[0].Value.ToString();
            bllSP.xoaSanPham(maSP);
            formSanPham_Load(sender, e);
            loadDatagridViewSP();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string masp = txtMaSanPham.Text;
            string tensp = txtTenSanPham.Text;
            int dongia = Int32.Parse(txtDonGia.Text);
            int soluong = Int32.Parse(txtSoLuong.Text);
            string mancc = cboNCC.SelectedValue.ToString();
            string mansx = cboNSX.SelectedValue.ToString();
            string baohanh = txtBaoHanh.Text;
            string maloai = cboMaLoai.SelectedValue.ToString();
            string mota = txtMota.Text;

            if (bllSP.kTraKhoaChinh(txtMaSanPham.Text))
            {
                bllSP.ThemSanPham(masp, tensp, dongia, soluong, mancc, mansx, baohanh, maloai, mota);
            }
            else
                bllSP.updateSanPham(masp, tensp, dongia, soluong, mancc, mansx, baohanh, maloai, mota);
            
            //MessageBox.Show(masp + tensp + dongia.ToString() + soluong.ToString() + mancc + mansx + baohanh + maloai + mota);
            loadDatagridViewSP();
            formSanPham_Load(sender, e);
        }

        private void btnTKSanPham_Click(object sender, EventArgs e)
        {
            if (cboTimKiem.SelectedItem == "Mã sản phẩm")
            {
                dataGridViewSanPham.DataSource = bllSP.timKiemSPtheoMa(txtTimKiem.Text);
            }
            else
            {
                if (cboTimKiem.SelectedItem == "Tên sản phẩm")
                {
                    dataGridViewSanPham.DataSource = bllSP.timKiemSPtheoTen(txtTimKiem.Text);
                }
            }
        }

        private void btnXoaBoLoc_Click(object sender, EventArgs e)
        {
            loadDatagridViewSP();
        }

        private void cboSapXepSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSapXepSP.SelectedItem == "Số lượng giảm dần")
            {
                dataGridViewSanPham.DataSource = bllSP.SapXepSanPhamTheoSoLuongGiam();
            }
            if (cboSapXepSP.SelectedItem == "Giá tăng dần")
            {
                dataGridViewSanPham.DataSource = bllSP.SapXepSanPhamTheoGiaTangDan();
            }
            if (cboSapXepSP.SelectedItem == "Giá giảm dần")
            {
                dataGridViewSanPham.DataSource = bllSP.SapXepSanPhamTheoGiaGiamDan();
            }
            if (cboSapXepSP.SelectedItem == "Số lượng tăng dần")
            {
                dataGridViewSanPham.DataSource = bllSP.SapXepSanPhamTheoSoLuongTang();
            }
            if (cboSapXepSP.SelectedItem == "Số lượng giảm dần")
            {
                dataGridViewSanPham.DataSource = bllSP.SapXepSanPhamTheoSoLuongGiam();
            }
            if (cboSapXepSP.SelectedItem == "Loại sản phẩm")
            {
                dataGridViewSanPham.DataSource = bllSP.SapXepSanPhamTheoLoaiSP();
            }
        }

        private void groupThaoTac_Enter(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupThongTInSP.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
                if (ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                }
                txtMaSanPham.Enabled = false;
                btnLuu.Enabled = true;
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            foreach (Control ctrl in groupThongTInSP.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                    ctrl.Enabled = true;
                }
                if(ctrl is ComboBox)
                {
                    ctrl.Enabled = true;
                }    
                txtMaSanPham.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                txtDonGia.Text = "0";
                txtSoLuong.Text = "0";
            }

            if(dataGridViewSanPham.RowCount <= 1)
            {
                txtMaSanPham.Text = "SP001";
            }
            else
            {
                txtMaSanPham.Text =  bllSP.getMaSanPham();
            }
           
        }
    }
}
