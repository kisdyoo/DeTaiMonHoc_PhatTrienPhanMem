using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace BaiTapNhom_PhanMemQuanLyCHXeMay
{
    public partial class SetCauHinh : Form
    {
        QL_NguoiDung CauHinh = new QL_NguoiDung();

        public SetCauHinh()
        {
            InitializeComponent();
        }

        private void cboServerList_DropDown(object sender, EventArgs e)
        {
            cboServerList.DataSource = CauHinh.GetServerName();
            cboServerList.DisplayMember = "ServerName";
        }
       





    }
}
