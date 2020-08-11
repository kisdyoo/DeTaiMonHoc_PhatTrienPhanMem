using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
    public class BLL_BanHang
    {
		QLCHXMDataContext QLCH = new QLCHXMDataContext();
		public IQueryable<HoaDonBan> loadDsHoaDonBan()
		{
			return QLCH.HoaDonBans.Select(k => k);
		}

		public IQueryable<ChiTietHDBan> loadCTHoaDon(string pMaHD)
		{
			return QLCH.ChiTietHDBans.Where(k => k.MaHD == pMaHD);
		}

		public IQueryable<ChiTietHDBan> hoaDonSi()
		{
			return QLCH.ChiTietHDBans.Where(k => k.SoLuong >10 );
		}
		public IQueryable BanSiPT()
		{
			var countofdetails = from bill in QLCH.HoaDonBans 
								 join details in QLCH.ChiTietHDBans on bill.MaHD equals details.MaHD
								 join sanpham in QLCH.QLSanPhams on details.MaSanPham equals sanpham.MaSP 
								 where (details.SoLuong>=10) && (sanpham.LoaiSP == "PT" )
								 select new { bill.MaHD, bill.NgayBan, bill.MaNV,bill.MaKH,bill.GhiChu };
			return countofdetails;
		}
		
    }
}
