using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2.DAL
{
    class CustomerDAO
    {
        Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();
        public List<Customer> getAll()
        {
            return _context.Customer.ToList();
        }
    }
}
