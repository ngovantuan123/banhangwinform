using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DoAn_2
{
	public partial class LoginForm : Form
	{
		public static string usernv = "";
		SqlConnection connect = ClassKetnoi.connect;
		// SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-A0E9NLI\MSSQLSERVER2019;Initial Catalog=doan-3;Integrated Security=True");
		public LoginForm()
		{   
			InitializeComponent();
			// txtuser.SelectionStart = 0;

			// DEBUG TODO REMOVE
			//btnlogin_Click(null, null);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//try
			//{
			//	SqlCommand command;
			//	string sqllogo = "select ID from dbo.Role where ID='Role_1'";
			//	if (connect.State != ConnectionState.Open)
			//		connect.Open();
			//	command = new SqlCommand(sqllogo, connect);
			//	SqlDataReader reader = command.ExecuteReader();
			//
			//	reader.Read();
			//	if (!reader.HasRows)
			//	{
			//		connect.Close();
			//		MessageBox.Show("bị lỗi");
			//	}
			//
			//}
			//catch (Exception ex)
			//{
			//	connect.Close();
			//	MessageBox.Show("Không thể kết nối database: " + ex.Message);
			//}
		}

		private void txtuser_Click(object sender, EventArgs e)
		{
			txtuser.Clear();
		}

		private void txtpass_Click(object sender, EventArgs e)
		{
			txtpass.Clear();
		}

		private void lbexit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void lbmini_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnlogin_Click(object sender, EventArgs e)
		{
			usernv = txtuser.Text;
			// TODO
			//string querynv = "select * From dbo.Employee where username='"+txtuser.Text+"' and password='"+txtpass.Text+"'";
			//SqlDataAdapter sqldata = new SqlDataAdapter(querynv, connect);
			//DataTable datatb1 = new DataTable();
			//sqldata.Fill(datatb1);
			//if(datatb1.Rows.Count==1)
			{
				MainControl mainmenu = new MainControl();
				this.Hide();
				mainmenu.Show();
			}
			//else
			//{
			//	MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
			//}
		}
	}
}
