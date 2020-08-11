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
	public partial class SetCauHinh : Form
	{
		QL_NguoiDung CauHinh = new QL_NguoiDung();
		public SetCauHinh()
		{
			InitializeComponent();
		}

		private void SetCauHinh_Load(object sender, EventArgs e)
		{

		}

		private void cboServerList_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboServerList.DataSource = CauHinh.GetServerName();
			cboServerList.DisplayMember = "ServerName";
		}
	}
}
