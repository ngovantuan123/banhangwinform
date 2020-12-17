using DoAn_2.MenuTab;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_2
{
    class ClassKetnoi
    {
       public static SqlConnection connect = new SqlConnection(@"Data Source=MASSAN-LAPTOP\SQLEXPRESS;Initial Catalog=Project_BanHang;Integrated Security=True");

    }
}
