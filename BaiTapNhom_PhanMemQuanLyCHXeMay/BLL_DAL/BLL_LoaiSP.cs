using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
	public class BLL_LoaiSP
	{
		QLCHXMDataContext QLCH = new QLCHXMDataContext();

		public IQueryable<LoaiSanPham> loadDSMaLoai()
		{
			return QLCH.LoaiSanPhams.Select(l => l);
		}
	}
}

