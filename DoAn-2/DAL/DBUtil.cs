using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_2.DAL
{
	public class DBUtil
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public int getDoanhThuNam()
		{
			String sql = "select sum(CONVERT(int, CONVERT(varchar(50), totalMoney))) as tong \n" +
						"from Invoice \n" +
						"where CONVERT(date, createdDate, 103) >= CAST(DATEADD(yy, DATEDIFF(yy, 0, GETDATE()), 0) AS DATE) \n" +
						"and CONVERT(date, createdDate,103) <= CAST(DATEADD(yy, DATEDIFF(yy, 0, GETDATE()) + 1, -1) AS DATE)";

			return (int)_context.Database.SqlQuery<int>(sql).FirstOrDefault();
		}
		public int getDoanhThuThang()
		{
			String sql = "select sum(CONVERT(int, CONVERT(varchar(50), totalMoney))) as tong \n" +
						"from Invoice \n" +
						"where CONVERT(date, createdDate, 103) >= CAST(DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0) AS DATE) \n"+
						"and CONVERT(date, createdDate,103) <= CAST(EOMONTH(GETDATE()) AS DATE)";

			var tong = _context.Database.SqlQuery<int>(sql).FirstOrDefault();
			if (tong != null)
				return Convert.ToInt32(tong);
			else
				return 0;
		}
	}
}


/*
 

use Project_BanHang1

-- Doanh thu nam nay
select sum(CONVERT(int, CONVERT(varchar(50), totalMoney))) as tong
from Invoice
where CONVERT(date,createdDate,103) >= CAST(DATEADD(yy, DATEDIFF(yy, 0, GETDATE()), 0) AS DATE)
	and CONVERT(date,createdDate,103) <= CAST(DATEADD(yy, DATEDIFF(yy, 0, GETDATE()) + 1, -1) AS DATE)
--

-- Doanh thu thang
select sum(CONVERT(int, CONVERT(varchar(50), totalMoney))) tong
from Invoice
where CONVERT(date,createdDate,103) >= CAST(DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0) AS DATE)
	and CONVERT(date,createdDate,103) <= CAST(EOMONTH(GETDATE()) AS DATE)
--


 
 */