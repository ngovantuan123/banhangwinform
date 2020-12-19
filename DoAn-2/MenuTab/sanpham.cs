using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DoAn_2.Model;
using DoAn_2.DAL;

namespace DoAn_2.MenuTab
{

	public partial class sanpham : Form
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		CatalogDAO ctlDao = new CatalogDAO();
		ProductDAO PrdDao = new ProductDAO();

		private int prdId;

		// mt code
		private void updateTable()
		{
			// Clear
			while (dgvlstProduct.Rows.Count > 0)
			{
				dgvlstProduct.Rows.RemoveAt(0);
			}

			List<Product> lstProduct = PrdDao.getAll();

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
		}

		private void updateCombobox()
		{
			List<Catalog> lstCatalog = ctlDao.getAll();

			lstCatalog.ForEach(c => {
				comboloai.Items.Add(c.ID.ToString() + "_" + c.Catalog_Name);
			});
		}

		// init
		public sanpham()
		{
			InitializeComponent();
			updateTable();
			updateCombobox();
		}

		private void button1_Click(object sender, EventArgs e) // Nut them san pham
		{
			try
			{
				// Lay du lieu
				String tensp = txttensp.Text;
				int soluong = Convert.ToInt32(txtsl.Text);
				int gia = Convert.ToInt32(txtgiaban.Text);

				String loaitxt = comboloai.Text;
				int loai = Convert.ToInt32(loaitxt.Substring(0, loaitxt.IndexOf('_')));

				// Tao san pham
				Product prd = new Product();
				prd.Product_Name = tensp;
				prd.Catalog_ID = loai;
				prd.Amount = soluong;
				prd.Price = gia;

				prd = PrdDao.save(prd);

				// Cap nhap bang san pham
				updateTable();
				txttensp.Text = "";
				txtsl.Text = "";
				txtgiaban.Text = "";
				comboloai.SelectedIndex = 0;

				// Thong bao
				MessageBox.Show("Thêm sản phẩm thành công");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Thêm thất bại:"+ ex.Message);
			}
		}
		public static byte[] ImageToByte(Image img)
		{
			ImageConverter converter = new ImageConverter();
			return (byte[])converter.ConvertTo(img, typeof(byte[]));
		}
		byte[] currentimg;
		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
		}

		private void btnsave_Click(object sender, EventArgs e) // nut sua san pham
		{
			try
			{
				String tensp = txttensp.Text;
				int soluong = Convert.ToInt32(txtsl.Text);
				int gia = Convert.ToInt32(txtgiaban.Text);

				String loaitxt = comboloai.Text;
				int loai = Convert.ToInt32(loaitxt.Substring(0, loaitxt.IndexOf('_')));

				Product prd = new Product();
				prd.ID = prdId;
				prd.Product_Name = tensp;
				prd.Catalog_ID = loai;
				prd.Amount = soluong;
				prd.Price = gia;

				PrdDao.update(prd);

				// Cap nhap bang san pham
				updateTable();

				// Thong bao
				MessageBox.Show("Sửa sản phẩm thành công");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Sửa thất bại:" + ex.Message);
			}
		}

		private void btndelete_Click(object sender, EventArgs e)
		{
		}

		private void btnclear_Click(object sender, EventArgs e)
		{
		//	clearsp();
		}

		private void btnButtonChooseIMG_Click(object sender, EventArgs e)
		{
		//	try
		//	{
		//		OpenFileDialog dlg = new OpenFileDialog();
		//		if(dlg.ShowDialog()==DialogResult.OK)
		//		{
		//			imgloc = dlg.FileName.ToString();
		//			pictureBox1.ImageLocation = imgloc;
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		connect.Close();
		//		MessageBox.Show("Error during insert: " + ex.Message);
		//	}
		}

		private void btnDeleteIMG_Click(object sender, EventArgs e)
		{
		//	try
		//	{
		//		using (var cmd = new SqlCommand("update nhapkho set anhsp=null where masp=@masp"))
		//		{
		//			cmd.Connection = connect;
		//			cmd.Parameters.AddWithValue("@masp", txtid.Text);
		//			connect.Open();
		//			if (cmd.ExecuteNonQuery() > 0)
		//			{
		//				MessageBox.Show("Đã xóa");
		//				clearsp();
		//				gridviewsp();
		//			}
		//			else
		//			{
		//				MessageBox.Show("Không thành công!");
		//			}
		//			connect.Close();
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		connect.Close();
		//		MessageBox.Show("Error during insert: " + ex.Message);
		//	}
		}

		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
		//	try
		//	{
		//		if (connect.State != ConnectionState.Open)
		//			connect.Open();
		//		using (SqlDataAdapter da = new SqlDataAdapter("select masp,tensp,soluongsp,gianhapsp,giabansp,loaisp,donvisp from nhapkho where ( masp like '" + txtsearch.Text + "%' or tensp like N'" + txtsearch.Text + "%' or soluongsp like '" + txtsearch.Text + "%' or gianhapsp like '" + txtsearch.Text + "%' or giabansp like '" + txtsearch.Text + "%'  or loaisp like N'" + txtsearch.Text + "%'  or donvisp like N'" + txtsearch.Text + "%'     )", connect))
		//		{
		//			DataTable dtsearch = new DataTable("nhapkho");
		//			da.Fill(dtsearch);
		//			dgvlstProduct.DataSource = dtsearch;
		//			
		//		}
		//		connect.Close();
		//		if (dgvlstProduct.Rows.Count > 0 && dgvlstProduct.Rows != null)
		//		{
		//			LabelSearch.Text = "Đã tìm thấy"; 
		//		}
		//		else
		//		{
		//			LabelSearch.Text = "Không tìm thấy...";
		//		}
		//
		//		if (string.IsNullOrWhiteSpace(txtsearch.Text))
		//		{
		//			LabelSearch.Text = "Tìm kiếm";
		//		}
		//
		//		
		//	}
		//	catch (Exception ex)
		//	{
		//		connect.Close();
		//		MessageBox.Show(ex.Message);
		//	}
			
		}

		private void comboloai_SelectedIndexChanged(object sender, EventArgs e)
		{
		//	if (string.IsNullOrWhiteSpace(txtid.Text))
		//	{
		//		autoid();
		//		txtid.ReadOnly = false;
		//	}
		//	else
		//	{
		//
		//	}

		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
		//	// creating Excel Application  
		//	Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
		//	// creating new WorkBook within Excel application  
		//	Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
		//	// creating new Excelsheet in workbook  
		//	Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
		//	// see the excel sheet behind the program  
		//	app.Visible = true;
		//	// get the reference of first sheet. By default its name is Sheet1.  
		//	// store its reference to worksheet  
		//	worksheet = workbook.Sheets["Sheet1"];
		//	worksheet = workbook.ActiveSheet;
		//	// changing the name of active sheet  
		//	worksheet.Name = "Exported from gridview";
		//	// storing header part in Excel  
		//	for (int i = 1; i < dgvlstProduct.Columns.Count + 1; i++)
		//	{
		//		worksheet.Cells[1, i] = dgvlstProduct.Columns[i - 1].HeaderText;
		//	}
		//	// storing Each row and column value to excel sheet  
		//	for (int i = 0; i < dgvlstProduct.Rows.Count; i++)
		//	{
		//		for (int j = 0; j < dgvlstProduct.Columns.Count; j++)
		//		{
		//			worksheet.Cells[i + 2, j + 1] = dgvlstProduct.Rows[i].Cells[j].Value.ToString();
		//		}
		//	}
		//	// save the application  
		//	//  workbook.SaveAs("C:\\Users\\lionel\\Desktop\\Test\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		//	// Exit from the application  
		//	//  app.Quit(); 
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
		//	string getdate = dateTimePicker1.Value.Date.ToString("MM/dd/yyyy");
		//	try
		//	{
		//		if (connect.State != ConnectionState.Open)
		//			connect.Open();
		//		using (SqlDataAdapter da = new SqlDataAdapter("select masp,tensp,soluongsp,gianhapsp,giabansp,loaisp,donvisp,ngaynhapkho,nvnhapkho from nhapkho where cast ([ngaynhapkho] as date) = '" + getdate + "'      ", connect))
		//		{
		//			DataTable dtsearch = new DataTable("nhapkho");
		//			da.Fill(dtsearch);
		//			dgvlstProduct.DataSource = dtsearch;
		//
		//		}
		//		connect.Close();
		//		if (dgvlstProduct.Rows.Count > 1 && dgvlstProduct.Rows != null)
		//		{
		//			// labelSearch.Text = "Đã tìm thấy";
		//		}
		//		else
		//		{
		//			//  labelSearch.Text = "Không tìm thấy...";
		//		}
		//
		//
		//	}
		//	catch (Exception ex)
		//	{
		//		connect.Close();
		//		MessageBox.Show(ex.Message);
		//	}
		}

		private void dgvlstProduct_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			DataGridView dataGridView1 = (DataGridView)sender;
			if (dataGridView1.SelectedRows.Count >= 1)
			{
				DataGridViewRow row = dataGridView1.SelectedRows[0];
				prdId = Convert.ToInt32(row.Cells[0].Value.ToString());
				txttensp.Text = row.Cells[1].Value.ToString();
				txtsl.Text = row.Cells[3].Value.ToString();
				txtgiaban.Text = row.Cells[4].Value.ToString();

				for (int i = 0; i < comboloai.Items.Count; i++)
				{
					if (comboloai.Items[i].ToString().Equals(row.Cells[2].Value.ToString()))
					{
						comboloai.SelectedIndex = i;
						break;
					}
				}
			}
		}

	}
}
