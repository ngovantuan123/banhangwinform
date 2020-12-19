using DoAn_2.Model;
using System.Collections.Generic;
using System.Linq;

namespace DoAn_2.DAL
{
	public class ProductDAO
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public List<Product> getAll()
		{
			return _context.Product.ToList();


		}
		public Product getByID(int id)
		{
			return _context.Product.Where(i => i.ID == id).FirstOrDefault();
		}

		internal Product add(Product product)
		{
			if (product.ID == 0)
				product.ID = _context.Product.Count() + 1;
			Product newprd = _context.Product.Add(product);
			_context.SaveChanges();
			return newprd;
		}

		internal void update(Product product)
		{
			List<Product> t = _context.Product.Where(m => m.ID == product.ID).ToList();
			foreach (Product d in t)
			{
				d.Product_Name = product.Product_Name;
				d.Amount = product.Amount;
				d.Price = product.Price;
				d.Catalog_ID = product.Catalog_ID;
				d.Img = product.Img;
			}
			_context.SaveChanges();
		}

	}
}
