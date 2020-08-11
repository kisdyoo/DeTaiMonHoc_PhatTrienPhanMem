using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace GUI
{
	public partial class QL_NguoiDung
	{
		public int Check_Config()
		{
			if (Properties.Settings.Default.QL_CuaHangXeMay == string.Empty)
				return 1;
			SqlConnection _SqlConn = new SqlConnection(Properties.Settings.Default.QL_CuaHangXeMay);
			try
			{
				if (_SqlConn.State == System.Data.ConnectionState.Closed)
					_SqlConn.Open();
				return 0;
			}
			catch
			{
				return 2;
			}
		}
		public enum LoginResult
		{
			/// <summary>
			/// wrong username or password
			/// </summary>
			Invalid,
			/// <summary>
			/// user has been disable
			/// </summary>
			Disable,
			/// <summary>
			/// Login success
			/// </summary>
			Success
		}
		public int Check_User(string pUser, string pPass)
		{
			SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NguoiDung where TenDangNhap = '" + pUser + "' and MatKhau='" + pPass + "'", Properties.Settings.Default.QL_CuaHangXeMay);
			DataTable dt = new DataTable();
			daUser.Fill(dt);
			if (dt.Rows.Count == 0)
				return 0;
			else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
			{
				return 1;
			}
			return 2;
		}
		public DataTable GetServerName()
		{
			DataTable dt = new DataTable();
			dt = SqlDataSourceEnumerator.Instance.GetDataSources();
			return dt;
		}
	}
}
