using DoAn_2.DAL;
using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAn_2.MenuTab
{
	public partial class donhang : Form
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		InvoiceDAO ivcDao = new InvoiceDAO();
		CustomerDAO ctmDao = new CustomerDAO();

		// init
		public donhang()
		{
			InitializeComponent();

			// update
			updateTable();
		}

		// mt code
		private void updateTable(int cusId = -1)
		{
			// Clear
			dgvDonHang.Rows.Clear();

			// Add
			List<Invoice> lstInvoice = ivcDao.getAll();

			String[] datas = { "", "", "", "", "", "", "" };
			lstInvoice.ForEach(i => {
				if (cusId == -1 || i.Customer_ID == cusId)
				{
					Customer c = ctmDao.getByID(i.Customer_ID);

					datas[0] = i.ID.ToString(); // id
					datas[1] = i.Invoice_Name; // ten
					datas[2] = c.ID.ToString() + ". " + c.firstName; // khach hang
					datas[3] = i.totalMoney.ToString(); // tong tien
					datas[4] = i.createdDate; // ngay tao
					datas[5] = i.customerAddress; // dia chi
					switch (i.status)
					{
						case 0: datas[6] = "Chưa xác nhận"; break;
						case 1: datas[6] = "Đang giao"; break;
						case 2: datas[6] = "Hoàn thành"; break;
					}
					dgvDonHang.Rows.Add(datas);
				}
			});
		}

		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void btnExportExcel_Click(object sender, EventArgs e)
		{
			// creating Excel Application  
		   /* Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
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
			for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
			{
				worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
			}
			// storing Each row and column value to excel sheet  
			for (int i = 0; i < dataGridView1.Rows.Count; i++)
			{
				for (int j = 0; j < dataGridView1.Columns.Count; j++)
				{
					worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
				}
			}*/
			// save the application  
			//  workbook.SaveAs("C:\\Users\\lionel\\Desktop\\Test\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			// Exit from the application  
			//  app.Quit(); 
		}

		private void donhang_Load(object sender, EventArgs e)
		{
			//thay the o trong trong datagridview = " "
			foreach (DataGridViewRow item in dgvDonHang.Rows)
			{
				for (int i = 0; i < item.Cells.Count; i++)
				{
					if (item.Cells[i].Value == null || item.Cells[i].Value == DBNull.Value )
					{
						for (int n = 1; n < dgvDonHang.Rows.Count; n++)
						{
							dgvDonHang.Rows[n].Cells[i].Value = " ";
						}
					}
					else
					{


					}
				}
			}
		}

		private void btnDetail_Click(object sender, EventArgs e)
		{
			int curRow = dgvDonHang.CurrentRow.Index;
			if (curRow == -1)
				return;
			HoaDonChiTiet ct = new HoaDonChiTiet(Convert.ToInt32(dgvDonHang.CurrentRow.Cells[0].Value.ToString()));
			ct.Show();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			int cusId = -1;
			if (txtSearch.Text.Length > 0)
				cusId = Convert.ToInt32(txtSearch.Text);
			updateTable(cusId);
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13) // nhan enter
			{
				int cusId = -1;
				if (txtSearch.Text.Length > 0)
					cusId = Convert.ToInt32(txtSearch.Text);
				updateTable(cusId);
			}
			else if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
