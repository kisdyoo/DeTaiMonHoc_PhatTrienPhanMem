using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL_DAL
{
	public class BLL_NhaCungCap
	{
		QLCHXMDataContext QLCH = new QLCHXMDataContext();
		public IQueryable<NhaCungCap> loadDSNhaCungCap()
		{
			return QLCH.NhaCungCaps.Select(ncc => ncc);
		}
	}
}
