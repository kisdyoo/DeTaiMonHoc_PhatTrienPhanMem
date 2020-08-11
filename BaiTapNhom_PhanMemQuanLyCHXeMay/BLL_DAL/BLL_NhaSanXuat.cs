using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
	public class BLL_NhaSanXuat
	{
		QLCHXMDataContext QLCH = new QLCHXMDataContext();

		public IQueryable<NhaSanXuat> loadDSNhaSanXuat()
		{
			return QLCH.NhaSanXuats.Select(nsx => nsx);
		}
	}
}
