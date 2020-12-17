using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2.DAL
{
	class ComboDAO
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public List<Combo> getAll()
		{
			return _context.Combo.ToList();
		}
		public Combo getByID(int id)
		{
			return _context.Combo.Where(i => i.ID == id).FirstOrDefault();
		}

		internal Combo save(Combo cb)
		{
			if (cb.ID == 0)
				cb.ID = _context.Combo.Count() + 1;
			Combo newcb = _context.Combo.Add(cb);
			_context.SaveChanges();
			return newcb;
		}

		internal void update(Combo cb)
		{
			List<Combo> t = _context.Combo.Where(m => m.ID == cb.ID).ToList();
			foreach (Combo d in t)
			{
				d.Combo_Name = cb.Combo_Name;
				d.endDate = cb.endDate;
				d.Product_List = cb.Product_List;
				d.startDate = cb.startDate;
				d.endDate = cb.endDate;
				d.totalMoney = cb.totalMoney;
				d.discount = cb.discount;
				d.discountMoney = cb.discountMoney;
			}
			_context.SaveChanges();
		}

		public List<Product> getListProduct(Combo cb)
		{

			return null;
		}
	}

}

