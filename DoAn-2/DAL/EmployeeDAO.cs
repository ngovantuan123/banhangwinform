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
            //int count = _context.Employee.Where(m => m.username == username ).Where(m=>m.password == pass).Count();
            //return count <0;
            return true;
        }

    }
}
