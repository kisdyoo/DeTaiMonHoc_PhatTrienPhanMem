using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
	public class BLL_SanPham
	{
		QLCHXMDataContext QLCH = new QLCHXMDataContext();
		public IQueryable<QLSanPham> loadDSSanPham()
		{
			return QLCH.QLSanPhams.Select(s => s);
		}
		public void ThemSanPham(string ma, string ten, int gia, int soLuong, string maNCC, string maNSX, string baohanh, string loaisp, string mota)
		{
			QLSanPham sp = new QLSanPham();
			sp.MaSP  = ma;
			sp.TenSP = ten;
			sp.DonGia = gia;
			sp.SoLuong = soLuong;
			sp.MaNCC = maNCC;
			sp.MaNSX = maNSX;
			sp.ThongTinBH = baohanh;
			sp.LoaiSP = loaisp;
			sp.MoTa = mota;

			QLCH.QLSanPhams.InsertOnSubmit(sp);
			QLCH.SubmitChanges();
			loadDSSanPham();
		}
		public void updateSanPham(string ma, string ten, int gia, int soLuong, string maNCC, string maNSX, string baohanh, string loaisp, string mota)
		{
			QLSanPham sp = QLCH.QLSanPhams.Where(kh => kh.MaSP == ma).FirstOrDefault();
			sp.TenSP = ten;
			sp.DonGia = gia;
			sp.SoLuong = soLuong;
			sp.MaNCC = maNCC;
			sp.MaNSX = maNSX;
			sp.ThongTinBH = baohanh;
			sp.LoaiSP = loaisp;
			sp.MoTa = mota;

			QLCH.SubmitChanges();
		}
		public void xoaSanPham(string pMaSP)
		{
			QLSanPham item = QLCH.QLSanPhams.Where(sp => sp.MaSP == pMaSP).FirstOrDefault();
			QLCH.QLSanPhams.DeleteOnSubmit(item);
			QLCH.SubmitChanges();
			
		}
		public IQueryable<QLSanPham> timKiemSPtheoMa(string masp)
		{
			return QLCH.QLSanPhams.Where(s => s.MaSP.Contains(masp));
		}
		public IQueryable<QLSanPham> timKiemSPtheoTen(string tensp)
		{
			return QLCH.QLSanPhams.Where(t => t.TenSP.Contains(tensp));
		}

		public IQueryable<QLSanPham> SapXepSanPhamTheoGiaTangDan()
		{
			return QLCH.QLSanPhams.Select(sp => sp).OrderBy(sp => sp.DonGia);
		}
		public IQueryable<QLSanPham> SapXepSanPhamTheoGiaGiamDan()
		{
			return QLCH.QLSanPhams.Select(sp => sp).OrderByDescending(sp => sp.DonGia);
		}
		public IQueryable<QLSanPham> SapXepSanPhamTheoSoLuongTang()
		{
			return QLCH.QLSanPhams.Select(sp => sp).OrderBy(sp => sp.SoLuong);
		}
		public IQueryable<QLSanPham> SapXepSanPhamTheoSoLuongGiam()
		{
			return QLCH.QLSanPhams.Select(sp => sp).OrderByDescending(sp => sp.SoLuong);
		}
		public IQueryable<QLSanPham> SapXepSanPhamTheoLoaiSP()
		{
			return QLCH.QLSanPhams.Select(sp => sp).OrderBy(sp => sp.LoaiSP);
		}
		public bool kTraKhoaChinh(string maSP)
		{
			int count = QLCH.QLSanPhams.Where(kh => kh.MaSP == maSP).Count();
			if (count > 0)
				return false;
			return true;
		}
		public string getMaSanPham()
		{
			string x = QLCH.QLSanPhams.Max(t => t.MaSP);
			int ma = int.Parse(x.Substring(x.Length - 3, 3));

			if (ma >= 0 && ma < 9)
			{
				return "SP00" + (ma + 1).ToString();
			}
			else if (ma >= 9)
			{
				return "SP0" + (ma + 1).ToString();
			}
			else
				return "";

		}
	}

}
