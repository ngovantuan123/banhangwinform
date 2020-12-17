using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2.DAL
{
	public class CatalogDAO
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public List<Catalog> getAll()
		{
			return _context.Catalog.ToList();


		}
		public Catalog getByID(int id)
		{
			return _context.Catalog.Where(i => i.ID == id).FirstOrDefault();
		}
	}
}

