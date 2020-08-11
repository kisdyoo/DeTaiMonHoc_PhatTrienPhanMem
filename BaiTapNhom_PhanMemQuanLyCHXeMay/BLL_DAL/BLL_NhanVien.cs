using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class BLL_NhanVien
    {
        QLCHXMDataContext QLCH = new QLCHXMDataContext();
		public IQueryable<NhanVien> dsNhanVien()
		{
			return QLCH.NhanViens.Select(nv => nv);
		}
		public IQueryable<NhanVien> GetNhanViens(string maNV)
		{
			return QLCH.NhanViens.Where(nv => nv.MaNV == maNV);
		}
		public IQueryable<NhanVien> timKiemNhanVien(string tenNV)
		{
			return QLCH.NhanViens.Where(s => s.TenNV.Contains(tenNV));
		}
		public void addNhanVien(string maNV, string tenNV,string gioiTinh, string diaChi, string soDT, int luongCB)
		{
			NhanVien nv = new NhanVien();
			nv.MaNV = maNV;
			nv.TenNV = tenNV;
			nv.GioiTinh = gioiTinh;
			nv.DiaChi = diaChi;
			nv.SDT = soDT;
			nv.LuongCoBan = luongCB;

			QLCH.NhanViens.InsertOnSubmit(nv);
			QLCH.SubmitChanges();
		}
		public void deleteNhanVien(string maNV)
		{
			NhanVien nv = QLCH.NhanViens.Where(kh => kh.MaNV == maNV).FirstOrDefault();
			QLCH.NhanViens.DeleteOnSubmit(nv);
			QLCH.SubmitChanges();
		}
		public void updateNhanVien(string maNV, string tenNV, string gioiTinh, string diaChi, string soDT, int luongCB)
		{
			NhanVien nv = QLCH.NhanViens.Where(kh => kh.MaNV == maNV).FirstOrDefault();

			nv.TenNV = tenNV;
			nv.GioiTinh = 
			nv.DiaChi = diaChi;
			nv.SDT = soDT;
			nv.LuongCoBan = luongCB;

			QLCH.SubmitChanges();
		}

		public bool kTraKhoaChinh(string maNV)
		{
			int count = QLCH.NhanViens.Where(nv => nv.MaNV == maNV).Count();
			if (count > 0)
				return false;
			return true;
		}
		public string getMaNhanVien(string y)
		{
			string x = QLCH.NhanViens.Max(t => t.MaNV);
			int ma = int.Parse(x.Substring(x.Length - 3, 3));

			if (ma >= 0 && ma < 9)
			{
				return "NV00" + (ma + 1).ToString();
			}
			else if (ma >= 9)
			{
				return "NV0" + (ma + 1).ToString();
			}
			else
				return "";

		}
	}
}

