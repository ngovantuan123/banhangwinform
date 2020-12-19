using DoAn_2.Model;
using System.Collections.Generic;
using System.Linq;

namespace DoAn_2.DAL
{
	class InvoiceDetailDAO
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public List<InvoiceDetail> getAllofInvoice(int id)
		{
			return _context.InvoiceDetail.Where(i => i.Invoice_ID == id).ToList();
		}

		internal InvoiceDetail add(InvoiceDetail ivcdtl)
		{
			InvoiceDetail newivcdtl = _context.InvoiceDetail.Add(ivcdtl);
			_context.SaveChanges();
			return newivcdtl;
		}

		internal void update(InvoiceDetail ivcdtl)
		{
			List<InvoiceDetail> t = _context.InvoiceDetail.Where(m => m.Invoice_ID == ivcdtl.Invoice_ID).ToList();
			foreach (InvoiceDetail d in t)
			{
				d.Amount = ivcdtl.Amount;
				d.Price = ivcdtl.Price;
			}
			_context.SaveChanges();
		}


	}
}
