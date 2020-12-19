using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2.DAL
{
   public class EmployeeDAO
    {
        Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();
        public bool checkLogin(String username ,String pass)
        {
            var data1 = (from e in _context.Employee select e);

            var data = data1.AsEnumerable().Where(c => c.username == username && c.password == pass);
            if (data.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
