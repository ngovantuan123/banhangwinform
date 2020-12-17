using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DoAn_2.Model;

namespace DoAn_2.MenuTab
{

	public partial class tonkho : Form
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();
		//ComboDAO cbDao = new ComboDAO();

		string imgloc = "";
		
		public void gridviewsp()
		{
			string querysp = @"select masp as 'Mã sản phẩm', tensp as 'Tên sản phẩm', soluongsp as 'Số lượng', gianhapsp as 'Giá nhập', giabansp as 'Giá bán', loaisp as 'Loại', donvisp as 'Đơn vị',giamgia as 'Giảm giá' from tonkho";
			//SqlDataAdapter sqldatasp = new SqlDataAdapter(querysp, connect);
			DataTable datatbsp = new DataTable();
			//sqldatasp.Fill(datatbsp);
			//dgtCombo.DataSource = datatbsp;
			//connect.Close();
		}

		public void clearsp()
		{
			txtid.Clear();
			txttensp.Clear();
			txtsl.Clear();
			txtgianhap.Clear();
			txtgiaban.Clear();
			comboloai.SelectedItem = null;
			combodonvi.SelectedItem = null;
		   // pictureBox1.Image = null;
			//pictureBox1.Image = Properties.Resources._default;
		}
		private void autoid()
		{
			if (comboloai.SelectedIndex == -1)
			{
			//    MessageBox.Show("nhập thông tin!");
			}
			else
			{
				string comboselected = this.comboloai.GetItemText(this.comboloai.SelectedItem);
				// string s1 = comboselected.Substring(0, comboselected.IndexOf(" "));
				string s1 = comboselected.Substring(0, 1);
				string s2 = comboselected.Substring(comboselected.IndexOf(" ") + 1);
				if (s2 == null)
				{
					string s1a = s1.Substring(0, 1).ToUpper();
					string s2a = s1.Substring(0, 1).ToUpper();
					String s3 = String.Concat(s1a, s2a);

					//connect.Open();
					//SqlCommand cmd = new SqlCommand("select count(masp) from tonkho", connect);
					//int i = Convert.ToInt32(cmd.ExecuteScalar());
					//connect.Close();
					//i++;
					//txtid.Text = s3 + i.ToString();
				}
				else
				{
					string s1a = s1.Substring(0, 1).ToUpper();
					string s2a = s2.Substring(0, 1).ToUpper();
					String s3 = String.Concat(s1a, s2a);

					//connect.Open();
					//SqlCommand cmd = new SqlCommand("select count(masp) from tonkho", connect);
					//int i = Convert.ToInt32(cmd.ExecuteScalar());
					//connect.Close();
					//i++;
					//txtid.Text = s3 + i.ToString();
				}

			}
		}

		public tonkho()
		{
			InitializeComponent();
			
	// todo		dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
	// todo		gridviewsp();
	// todo
	// todo	   // string querysp = @"select masp as 'Mã sản phẩm', tensp as 'Tên sản phẩm', soluongsp as 'Số lượng', gianhapsp as 'Giá nhập', giabansp as 'Giá bán', loaisp as 'Loại', donvisp as 'Đơn vị'from sanpham;";
	// todo		string queryloai = @"select * from loaisp";
	// todo		string querydonvi = @"select * from donvisp";
	// todo
	// todo	   // SqlDataAdapter sqldatasp = new SqlDataAdapter(querysp, connect);
	// todo		SqlDataAdapter sqldataloai = new SqlDataAdapter(queryloai, connect);
	// todo		SqlDataAdapter sqldatadonvi = new SqlDataAdapter(querydonvi, connect);
	// todo
	// todo	   // DataTable datatbsp = new DataTable();
	// todo		DataTable datatbloai = new DataTable();
	// todo		DataTable datatbdonvi = new DataTable();
	// todo
	// todo	   // sqldatasp.Fill(datatbsp);
	// todo		sqldataloai.Fill(datatbloai);
	// todo		sqldatadonvi.Fill(datatbdonvi);
	// todo
	// todo		//combobox
	// todo		comboloai.Items.Clear();
	// todo		combodonvi.Items.Clear();
	// todo		foreach (DataRow dr in datatbloai.Rows)
	// todo		{
	// todo			comboloai.Items.Add(dr["TenLoai"].ToString());
	// todo		}
	// todo		foreach (DataRow dr2 in datatbdonvi.Rows)
	// todo		{
	// todo			combodonvi.Items.Add(dr2["TenDonvi"].ToString());
	// todo		}
	// todo		connect.Close();
	// todo		//table
	// todo	   // dataGridView1.DataSource = datatbsp;
		}


		private void btnsave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtid.Text))
			{
				MessageBox.Show("Thông tin trống!");
			}
			else
			{
			try
			{
				byte[] img = null;
				FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
				BinaryReader br = new BinaryReader(fs);
				img = br.ReadBytes((int)fs.Length);
				using (var cmd = new SqlCommand("update tonkho set tensp=@tensp,soluongsp=@soluongsp,gianhapsp=@gianhapsp,giabansp=@giabansp,loaisp=@loaisp,donvisp=@donvisp,anhsp=@anhsp where masp=@masp"))
				{
					/*cmd.Connection = connect;
					cmd.Parameters.AddWithValue("@masp", txtid.Text);
					cmd.Parameters.AddWithValue("@tensp", txttensp.Text);
					cmd.Parameters.AddWithValue("@soluongsp", txtsl.Text);
					cmd.Parameters.AddWithValue("@gianhapsp", txtgianhap.Text);
					cmd.Parameters.AddWithValue("@giabansp", txtgiaban.Text);
					cmd.Parameters.AddWithValue("@loaisp", comboloai.GetItemText(comboloai.SelectedItem));
					cmd.Parameters.AddWithValue("@donvisp", combodonvi.GetItemText(combodonvi.SelectedItem));
					cmd.Parameters.AddWithValue("@anhsp", img);
					connect.Open();*/
					if (cmd.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Đã lựu");
						gridviewsp();
						txtid.ReadOnly = true;
					}
					else
					{
						MessageBox.Show("Lưu không thành công!");
						txtid.ReadOnly = true;
					}
					//connect.Close();
				}
			}
			catch (Exception ex)
			{
				//connect.Close();
				MessageBox.Show("Error during insert: " + ex.Message);
			}
			}
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtid.Text))
			{
				MessageBox.Show("Thông tin trống!");
			}
			else
			{


			try
			{
				using (var cmd = new SqlCommand("delete tonkho where masp=@masp"))
				{
					/*cmd.Connection = connect;
					cmd.Parameters.AddWithValue("@masp", txtid.Text);
					connect.Open();*/
					if (cmd.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Đã xóa");
						clearsp();
						gridviewsp();
					}
					else
					{
						MessageBox.Show("Lưu không thành công!");
					}
					//connect.Close();
				}
			}
			catch (Exception ex)
			{
				//connect.Close();
				MessageBox.Show("Error during insert: " + ex.Message);
			}

			}
		}

		private void btnclear_Click(object sender, EventArgs e)
		{
			clearsp();
		}

		private void btnButtonChooseIMG_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog dlg = new OpenFileDialog();
				if(dlg.ShowDialog()==DialogResult.OK)
				{
					imgloc = dlg.FileName.ToString();
					//pictureBox1.ImageLocation = imgloc;
				}
			}
			catch (Exception ex)
			{
				//connect.Close();
				MessageBox.Show("Error during insert: " + ex.Message);
			}
		}

		private void btnDeleteIMG_Click(object sender, EventArgs e)
		{
			try
			{
				using (var cmd = new SqlCommand("update tonkho set anhsp=null where masp=@masp"))
				{
					//cmd.Connection = connect;
					cmd.Parameters.AddWithValue("@masp", txtid.Text);
					//connect.Open();
					if (cmd.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Đã xóa");
						clearsp();
						gridviewsp();
					}
					else
					{
						MessageBox.Show("Không thành công!");
					}
					//connect.Close();
				}
			}
			catch (Exception ex)
			{
				//connect.Close();
				MessageBox.Show("Error during insert: " + ex.Message);
			}
		}

		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			/*try
			{
				if (connect.State != ConnectionState.Open)
					connect.Open();
				using (SqlDataAdapter da = new SqlDataAdapter("select masp,tensp,soluongsp,gianhapsp,giabansp,loaisp,donvisp from tonkho where ( masp like '" + txtsearch.Text + "%' or tensp like N'" + txtsearch.Text + "%' or soluongsp like '" + txtsearch.Text + "%' or gianhapsp like '" + txtsearch.Text + "%' or giabansp like '" + txtsearch.Text + "%'  or loaisp like N'" + txtsearch.Text + "%'  or donvisp like N'" + txtsearch.Text + "%'     )", connect))
				{
					DataTable dtsearch = new DataTable("tonkho");
					da.Fill(dtsearch);
					dgtCombo.DataSource = dtsearch;
					
				}
				connect.Close();
				if (dgtCombo.Rows.Count > 0 && dgtCombo.Rows != null)
				{
					LabelSearch.Text = "Đã tìm thấy"; 
				}
				else
				{
					LabelSearch.Text = "Không tìm thấy...";
				}

				if (string.IsNullOrWhiteSpace(txtsearch.Text))
				{
					LabelSearch.Text = "Tìm kiếm";
				}

				
			}
			catch (Exception ex)
			{
				connect.Close();
				MessageBox.Show(ex.Message);
			}*/
			
		}

		private void btnsearch_Click(object sender, EventArgs e)
		{

		}



		private void comboloai_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtid.Text))
			{
				autoid();
			}
			else
			{

			}

		}

		private void ButtonAutoid_Click(object sender, EventArgs e)
		{

		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			/*// creating Excel Application  
			Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
			// creating new WorkBook within Excel application  
			Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
			// creating new Excelsheet in workbook  
			Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
			// see the excel sheet behind the program  
			app.Visible = true;
			// get the reference of first sheet. By default its name is Sheet1.  
			// store its reference to worksheet  
			worksheet = workbook.Sheets["Sheet1"];
			worksheet = workbook.ActiveSheet;
			// changing the name of active sheet  
			worksheet.Name = "Exported from gridview";
			// storing header part in Excel  
			for (int i = 1; i < dgtCombo.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = dgtCombo.Columns[i - 1].HeaderText;
			}
			// storing Each row and column value to excel sheet  
			for (int i = 0; i < dgtCombo.Rows.Count; i++)
			{
				for (int j = 0; j < dgtCombo.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = dgtCombo.Rows[i].Cells[j].Value.ToString();
				}
			}*/
			// save the application  
			//  workbook.SaveAs("C:\\Users\\lionel\\Desktop\\Test\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			// Exit from the application  
			//  app.Quit(); 
		}

        // mt code
        private void updateTable()
        {
            /*// Clear
			while (dgvCombo.Rows.Count > 0)
			{
				dgvCombo.Rows.RemoveAt(0);
			}

			List<Combo> lstProduct = PrdDao.getAll();

			String[] datas = { "", "", "", "", "" };
			lstProduct.ForEach(p => {
				Catalog c = ctlDao.getByID(Convert.ToInt32(p.Catalog_ID));

				datas[0] = p.ID.ToString(); // id
				datas[1] = p.Product_Name; // ten
				datas[2] = c.ID.ToString() + "_" + c.Catalog_Name; // loai
				datas[3] = p.Amount.ToString(); // soluong
				datas[4] = p.Price.ToString(); // gia

				dgvlstProduct.Rows.Add(datas);

			});
		}*/
        }

	}
}
