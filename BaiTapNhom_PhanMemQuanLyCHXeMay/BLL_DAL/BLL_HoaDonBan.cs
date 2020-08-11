using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
	public class BLL_HoaDonBan
	{
		QLCHXMDataContext QLCH = new QLCHXMDataContext();
		public IQueryable<HoaDonBan> loadDsHoaDonBan()
		{
			return QLCH.HoaDonBans.Select(k => k);
		}
	}
}
