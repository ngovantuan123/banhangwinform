using DoAn_2.DAL;
using System;
using System.Windows.Forms;


namespace DoAn_2.MenuTab
{
	public partial class Dashboard : Form
	{
		private Form currentchildform;
		string CurrentMonth = DateTime.Now.ToString("MM");
		public Dashboard()
		{
			InitializeComponent();
			updateInfo();
		}
		private void motrangcon(Form trangcon)
		{
			if (currentchildform != null)
			{
				currentchildform.Close();

			}
			currentchildform = trangcon;
			trangcon.TopLevel = false;
			trangcon.FormBorderStyle = FormBorderStyle.None;
			trangcon.Dock = DockStyle.Fill;
			PanelChart.Controls.Add(trangcon);
			PanelChart.Tag = trangcon;
			trangcon.BringToFront();
			trangcon.Show();

		}
		
		// mt code
		private void updateInfo()
		{
			DBUtil dao = new DBUtil();
			lbTongDoanhSo.Text = dao.getDoanhThuThang().ToString();

		}


		private void doanhsobanhang()
		{
			
		 //   MessageBox.Show(CurrentMonth);
		}



		private void tongslsptrongkho()
		{
		}
		private void loaisptrongkho()
		{
		}
		private void khachno()
		{
		}
		private void Dashboard_Load(object sender, EventArgs e)
		{
			motrangcon(new ChartMoney());
			doanhsobanhang();
			tongslsptrongkho();
			loaisptrongkho();
			khachno();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void iconPictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			 motrangcon(new ChartMoney());
		   
		}

		private void btnChartSL_Click(object sender, EventArgs e)
		{
			motrangcon(new ChartSLSP());
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			motrangcon(new ChartSPHet());
		}
	}
}
