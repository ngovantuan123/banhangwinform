using DoAn_2.Model;
using System.Collections.Generic;
using System.Linq;

namespace DoAn_2.DAL
{
	class InvoiceDAO
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public List<Invoice> getAll()
		{
			return _context.Invoice.ToList();
		}
		public Invoice getByID(int id)
		{
			return _context.Invoice.Where(i => i.ID == id).FirstOrDefault();
		}

		internal Invoice add(Invoice invoice)
		{
			invoice.ID = _context.Invoice.Count() + 1;
			Invoice newivc = _context.Invoice.Add(invoice);
			_context.SaveChanges();
			return newivc;
		}

		internal void update(Invoice invoice)
		{
			List<Invoice> t = _context.Invoice.Where(m => m.ID == invoice.ID).ToList();
			foreach (Invoice d in t)
			{
				d.Invoice_Name = invoice.Invoice_Name;
				d.Customer_ID = invoice.Customer_ID;
				d.Shipper_ID = invoice.Shipper_ID;
				d.totalMoney = invoice.totalMoney;
				d.createdDate = invoice.createdDate;
				d.customerAddress = invoice.customerAddress;
				d.status = invoice.status;
				d.shipDate = invoice.shipDate;
			}
			_context.SaveChanges();
		}
	}
}
