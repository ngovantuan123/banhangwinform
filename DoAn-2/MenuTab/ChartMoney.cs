using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DoAn_2.MenuTab
{
	public partial class ChartMoney : Form
	{
		string CurrentMonth = DateTime.Now.ToString("MM");
		public ChartMoney()
		{
			InitializeComponent();
			updateChart();
		}

		private void updateChart()
		{




			//chart1.Series["Series1"].XValueType = ChartValueType.DateTime;
			//
			//chart1.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM";
			//DataSet ds = new DataSet();
			//connect.Open();
			////SqlDataAdapter adapt = new SqlDataAdapter("SELECT CAST(HDtime AS DATE) AS Ngay,COUNT(value) as slsp, HDthanhtoan as tien FROM HoaDon CROSS APPLY STRING_SPLIT(HDmasp, ',') where MONTH(HDtime) = '"+ CurrentMonth + "' group by HDtime, HDthanhtoan ORDER BY HDtime", connect);
			//SqlDataAdapter adapt = new SqlDataAdapter("select CAST(HDtime AS DATE) as Ngay, sum(HDthanhtoan) AS tien from HoaDon where MONTH(HDtime) = '" + CurrentMonth + "' group by CAST(HDtime AS DATE) ORDER by CAST(HDtime AS DATE)", connect);
			//
			//adapt.Fill(ds);
			//chart1.DataSource = ds;
			////set the member of the chart data source used to data bind to the X-values of the series  
			//chart1.Series["Series1"].XValueMember = "Ngay";
			////set the member columns of the chart data source used to data bind to the X-values of the series  
			//chart1.Series["Series1"].YValueMembers = "tien";
			//chart1.Series["Series1"].IsValueShownAsLabel = true;
			////ChartSlspDayByDay.Titles.Add("Salary Chart");
			//connect.Close();
		}
	}
}
