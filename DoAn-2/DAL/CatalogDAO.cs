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
		public void add(Catalog catalog)
        {
			catalog.ID = _context.Catalog.Count()+1;
			_context.Catalog.Add(catalog);
			_context.SaveChanges();
        }
		public void update(Catalog catalog)
		{
			List<Catalog> list_c = _context.Catalog.Where(m => catalog.ID == m.ID).ToList();
            foreach (Catalog ca in list_c)
            {
				ca.Catalog_Name = catalog.Catalog_Name;
            }
			_context.SaveChanges();
		}
	}
}

