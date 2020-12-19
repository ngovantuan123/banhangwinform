using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using DoAn_2.Model;
using System.Collections.Generic;
using DoAn_2.DAL;

namespace DoAn_2
{
	public partial class LoginForm : Form
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();
		EmployeeDAO employeeDAO = new EmployeeDAO();
		public static string usernv = "";
		public LoginForm()
		{   
			InitializeComponent();
			
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
			String username = txtuser.Text;
			String pass= MD5Hash(txtpass.Text);
			
			if(employeeDAO.checkLogin(username,pass) == true)
            {
				LoginForm.usernv = username;
				MainControl mainmenu = new MainControl();
				this.Hide();
				mainmenu.Show();
			}
            else
            {
				MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
			}			
				
		}
		public String MD5Hash(String text)
        {
			MD5 md5 = new MD5CryptoServiceProvider();

			//compute hash from the bytes of text  
			md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(txtpass.Text));

			byte[] result = md5.Hash;

			StringBuilder strBuilder = new StringBuilder();
			for (int i = 0; i < result.Length; i++)
			{
				strBuilder.Append(result[i].ToString("x2"));
			}

			return strBuilder.ToString();
		}

	}
}
