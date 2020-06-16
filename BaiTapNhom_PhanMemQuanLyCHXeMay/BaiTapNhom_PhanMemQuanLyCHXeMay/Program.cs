using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BaiTapNhom_PhanMemQuanLyCHXeMay
{
	static class Program
	{
		public static frmMain mainForm = null;
		public static  SetCauHinh lgin = null;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmDangNhap());
		}
	}
}
