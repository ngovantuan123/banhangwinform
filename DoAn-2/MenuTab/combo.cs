using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using DoAn_2.Model;
using System.Collections.Generic;
using DoAn_2.DAL;

namespace DoAn_2.MenuTab
{

	public partial class combo : Form
	{
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();
		ComboDAO cbDao = new ComboDAO();
		ProductDAO prdDao = new ProductDAO();

		Combo curCB;
		string imgloc = "";

		// mt code
		private void updateTable()
		{
			// Clear
			while (dgvCombo.Rows.Count > 0)
				dgvCombo.Rows.RemoveAt(0);

			List<Combo> lstCombo = cbDao.getAll();
			List<Product> lstProduct = prdDao.getAll();

			String[] datas = { "", "", "", "", "", "", "", "" };
			lstCombo.ForEach(c => {
				// process data
				String[] lstStrPrd = c.Product_List.Split(';');
				String listPrd = "";
				foreach (String idStr in lstStrPrd)
				{
					listPrd = listPrd + lstProduct.Find(p => p.ID == Convert.ToInt32(idStr)).Product_Name + '\n';
					if (listPrd.Length > 32)
					{
						listPrd = listPrd.Substring(0,32) + "...";
						break;
					}
				}

				// insert
				datas[0] = c.ID.ToString(); // id
				datas[1] = c.Combo_Name; // ten
				datas[2] = listPrd; // ds san pham
				datas[3] = c.startDate; // start date
				datas[4] = c.endDate; // end date
				datas[5] = c.totalMoney.ToString(); // total money
				datas[6] = c.discountMoney.ToString(); // discount money
				datas[7] = c.discount; // discount

				dgvCombo.Rows.Add(datas);

			});
		}
		private void updateLstPrd()
		{
			if (curCB != null)
			{
				// remove combobox
				cbbLstPrd.Items.Clear();
				cbbLstPrd.Text = "";

				// add combobox
				String[] lstPrdStr = curCB.Product_List.Split(';');
				foreach (String idStr in lstPrdStr)
				{
					Product p = prdDao.getByID(Convert.ToInt32(idStr));
					cbbLstPrd.Items.Add(p.ID.ToString() + ". " + p.Product_Name);
				}
			}
		}

		// Init
		public combo()
		{
			// init
			InitializeComponent();

			// set default
			curCB = new Combo();
			dtpSDate.Format = DateTimePickerFormat.Custom;
			dtpSDate.CustomFormat = "dd/MM/yyyy";
			dtpEDate.Format = DateTimePickerFormat.Custom;
			dtpEDate.CustomFormat = "dd/MM/yyyy";

			// update data
			updateTable();
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

		// Chon combo tren danh sach
		private void dgvCombo_MouseClick(object sender, MouseEventArgs e)
		{
			if (dgvCombo.SelectedRows.Count >= 1)
			{
				DataGridViewRow row = dgvCombo.SelectedRows[0];
				int cbId = Convert.ToInt32(row.Cells[0].Value.ToString());
				curCB = cbDao.getByID(cbId);

				txtname.Text = curCB.Combo_Name;
				dtpSDate.Value = DateTime.Parse(curCB.startDate);
				dtpEDate.Value = DateTime.Parse(curCB.endDate);
				txttotalmoney.Text = curCB.totalMoney.ToString();
				txtdiscountmoney.Text = curCB.discountMoney.ToString();
				txtdiscount.Text = curCB.discount.ToString();

				updateLstPrd();
			}
			else
			{
				MessageBox.Show("No data!");
			}
		}

		// Validate tong tien chi nhap so, khong nhap chu
		private void txttotalmoney_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		// Validate tien giam chi nhap so, khong nhap chu
		private void txtdiscountmoney_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		// Validate giam phan tram chi nhap so, khong nhap chu
		private void txtgiaban_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		// Validate chi nhap so
		private void txtIdPrd_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
		// Caculator discount
		private void txtdiscountmoney_Leave(object sender, EventArgs e) // Thay doi discount
		{
			if (txtdiscountmoney.Text.Length != 0 && txttotalmoney.Text.Length != 0)
			{
				int giaCu = Convert.ToInt32(txttotalmoney.Text);
				int giaMoi = Convert.ToInt32(txtdiscountmoney.Text);
				double discount = (giaMoi * 100.0) / (giaCu * 1.0);
				if (discount > 100.0) discount = 100.0;
				else if (discount < 0.0) discount = 0.0;
				txtdiscount.Text = Math.Round(100.0 - discount).ToString();
			}
		}
		// Caculator discount money
		private void txtdiscount_Leave(object sender, EventArgs e) // Thay doi gia tien
		{
			if (txtdiscount.Text.Length != 0 && txttotalmoney.Text.Length != 0)
			{
				int giaCu = Convert.ToInt32(txttotalmoney.Text);
				double discount = 100 - Convert.ToInt32(txtdiscount.Text);
				double giaMoi = (giaCu * discount) / 100.0;
				txtdiscountmoney.Text = Math.Round(giaMoi).ToString();
			}
		}
		// Xoa noi dung khi nhap vao id product
		private void txtIdPrd_MouseClick(object sender, MouseEventArgs e)
		{
			txtIdPrd.Clear();
		}
		// Tìm sản phẩm hiện trên label sản phẩm
		private void txtIdPrd_Leave(object sender, EventArgs e)
		{
			if (txtIdPrd.Text.Length > 0)
			{
				int idPrd = Convert.ToInt32(txtIdPrd.Text);
				Product p = prdDao.getByID(idPrd);
				if (p != null)
					lblNamePrd.Text = p.Product_Name;
				else
					lblNamePrd.Text = "Không tìm thấy sản phẩm";
			}
		}
		// Them san pham vao combo
		private void btnAddPrd_Click(object sender, EventArgs e)
		{
			String a = txtIdPrd.Text;
			if (a.Length == 0)
				return;

			int id = Convert.ToInt32(a);
			if (prdDao.getByID(id) == null) // khong tim thay san pham
				MessageBox.Show("Thêm thất bại: không tìm thấy sản phẩm");
			
			if (curCB.Product_List != null && curCB.Product_List.Length > 0)
			{
				String[] lstPrdStr = curCB.Product_List.Split(';'); // san pham da them tu trc
				foreach (String idStr in lstPrdStr)
				{
					if (Convert.ToInt32(idStr) == id)
					{
						MessageBox.Show("Sản phẩm đã có trong combo");
						return;
					}
				}
			}

			if (curCB.Product_List == null || curCB.Product_List.Length == 0)
				curCB.Product_List = id.ToString();
			else
				curCB.Product_List = curCB.Product_List + ";" + id.ToString();

			updateLstPrd();
			MessageBox.Show("Đã thêm");
		}
		// Xoa san pham khoi combo
		private void btnDelPrd_Click(object sender, EventArgs e)
		{
			if (cbbLstPrd.SelectedIndex == -1)
			{
				MessageBox.Show("Chưa chọn sản phẩm để loại");
				return;
			}

			// Tim id san pham
			String prdStr = cbbLstPrd.Items[cbbLstPrd.SelectedIndex].ToString();
			int idPrd = Convert.ToInt32(prdStr.Substring(0, prdStr.IndexOf(".")));

			// Xoa khoi danh sach
			String[] lstPrdStr = curCB.Product_List.Split(';');
			String lstPrdNew = "";
			foreach (String idStr in lstPrdStr)
			{
				if (Convert.ToInt32(idStr) != idPrd)
				{
					lstPrdNew = lstPrdNew + idStr + ";";
				}
			}
			lstPrdNew = lstPrdNew.Substring(0, lstPrdNew.Length - 1); // bo dau ; cuoi
			curCB.Product_List = lstPrdNew;

			updateLstPrd();
		}

		// Them combo
		private void btnsave_Click(object sender, EventArgs e)
		{
			curCB.Combo_Name = txtname.Text;
			curCB.startDate = dtpSDate.Value.Date.ToString("dd/MM/yyyy");
			curCB.endDate = dtpEDate.Value.Date.ToString("dd/MM/yyyy");
			curCB.totalMoney = Convert.ToInt32(txttotalmoney.Text);
			curCB.discountMoney = Convert.ToInt32(txtdiscountmoney.Text);
			curCB.discount = txtdiscount.Text+"%";

			cbDao.save(curCB);

			updateTable();

			MessageBox.Show("Thêm combo thành công");
		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			curCB.Combo_Name = txtname.Text;
			curCB.startDate = dtpSDate.Value.Date.ToString("dd/MM/yyyy");
			curCB.endDate = dtpEDate.Value.Date.ToString("dd/MM/yyyy");
			curCB.totalMoney = Convert.ToInt32(txttotalmoney.Text);
			curCB.discountMoney = Convert.ToInt32(txtdiscountmoney.Text);
			curCB.discount = txtdiscount.Text + "%";

			cbDao.update(curCB);

			updateTable();

			MessageBox.Show("Sửa combo thành công");
		}
	}
}
