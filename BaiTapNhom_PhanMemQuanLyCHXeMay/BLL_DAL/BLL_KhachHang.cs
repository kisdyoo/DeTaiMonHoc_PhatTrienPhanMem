using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
	public class BLL_KhachHang
	{
		QLCHXMDataContext QLCH = new QLCHXMDataContext();
		public IQueryable<KhachHang> dsKhachHang()
        {
			return QLCH.KhachHangs.Select(kh => kh);
        }
		public IQueryable<KhachHang> GetKhachHangs(string maKH)
        {
			return QLCH.KhachHangs.Where(kh =>kh.MaKH == maKH);
        }
		public IQueryable<KhachHang> timKiemKhachHang(string tenKH)
		{
			return QLCH.KhachHangs.Where(s => s.TenKH.Contains(tenKH));
		}
		public void addKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
			KhachHang khachHang = new KhachHang();
			khachHang.MaKH = maKH;
			khachHang.TenKH = tenKH;
			khachHang.DiaChi = diaChi;
			khachHang.DienThoai = soDT;

			QLCH.KhachHangs.InsertOnSubmit(khachHang);
			QLCH.SubmitChanges();
        }
		public void deleteKhachHang(string maKH)
        {
			KhachHang khachHang =  QLCH.KhachHangs.Where(kh => kh.MaKH == maKH).FirstOrDefault();
			QLCH.KhachHangs.DeleteOnSubmit(khachHang);
			QLCH.SubmitChanges();
		}
		public void updateKhachHang(string maKH, string tenKH, string diaChi, string soDT)
        {
			KhachHang khachHang = QLCH.KhachHangs.Where(kh => kh.MaKH == maKH).FirstOrDefault();

			khachHang.TenKH = tenKH;
			khachHang.DiaChi = diaChi;
			khachHang.DienThoai = soDT;

			QLCH.SubmitChanges();
		}

		public bool kTraKhoaChinh(string maKH)
        {
			int count = QLCH.KhachHangs.Where(kh => kh.MaKH == maKH).Count();
			if (count > 0)
				return false;
			return true;
        }
		public string getMaKhachHang(string y)
		{
			string x = QLCH.KhachHangs.Max(t => t.MaKH);
			int ma = int.Parse(x.Substring(x.Length - 3, 3));

			if (ma >= 0 && ma < 9)
			{
				return "KH00" + (ma + 1).ToString();
			}
			else if (ma >= 9)
			{
				return "KH0" + (ma + 1).ToString();
			}
			else
				return "";

		}
	}
}
