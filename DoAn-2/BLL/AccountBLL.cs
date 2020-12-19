using DoAn_2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2.BLL
{
    public class AccountBLL
    {
        EmployeeDAO employeeDAO = new EmployeeDAO();
        public bool checkLogin(String username,String pass)
        {
            return employeeDAO.checkLogin(username, pass);
        }
    }
}
