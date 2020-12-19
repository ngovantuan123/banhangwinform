using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn_2.DAL;
using DoAn_2.Model;
using System.Collections.Generic;

namespace DoAn_2.MenuTab
{
	public partial class BanHang : Form
	{
		SqlConnection connect = ClassKetnoi.connect;
		CustomerDAO customerDAO = new CustomerDAO();
		ProductDAO productDAO = new ProductDAO();
		ComboDAO comboDAO = new ComboDAO();
		CatalogDAO catalogDAO = new CatalogDAO();
		Project_BanHang1Entities1 _context = new Project_BanHang1Entities1();

		public static string thanhtoan = "";//nut Tính tiền chuyển tạm thời cho form TT
		public static string IDhoadon = "";
		public static string HDmasp = "";
		public static string HDtensp = "";
		public static string HDdongia = "";
		public static string HDsl = "";
		public static string HDloai = "";
		public static string HDdonvi = "";
		public static string SDT = "";
		public static string TenKH = "";
		
		int checkslsp;//kiem tra so luong san pham nao do trong ton kho
		int indexRow;
		public BanHang()
		{
			InitializeComponent();
			loadKhachHang();

			showAllProduct();
			//test
		}
		public void loadKhachHang()
        {
			List<Customer> cystomers= customerDAO.getAll();
			cystomers.ForEach(m =>
			{
				cbc_kh.Items.Add(m.firstName+"_"+m.ID);
			});
			

		}
		private void showAllProduct()
		{
			//String[] datas = { "", "", "", "", "" };
			//
			//// TODO connect.Open();
			//string sqlsp = "select p.ID, Product_Name, Catalog_Name, Amount, Price from Product p, Catalog c where Catalog_ID = c.ID";
			//SqlCommand cmd2 = new SqlCommand(sqlsp, connect);
			//SqlDataReader dr2 = cmd2.ExecuteReader();
			//while (dr2.Read())
			//{
			//	datas[0] = dr2["ID"].ToString();
			//	datas[1] = dr2["Product_Name"].ToString();
			//	datas[2] = dr2["Catalog_Name"].ToString();
			//	datas[3] = dr2["Amount"].ToString();
			//	datas[4] = dr2["Price"].ToString();
			//	dataGridView1.Rows.Add(datas);
			//}
			//connect.Close();
		}

		private void autoidHD()
		{
			connect.Open();
			SqlCommand cmd = new SqlCommand("select count(ID) from Invoice", connect);
			int i = Convert.ToInt32(cmd.ExecuteScalar());
			connect.Close();
			i++;
			//txtsohd.Text = i.ToString();
			//IDhoadon = txtsohd.Text; // luu cho form tt
		}
		public void clearsp()
		{
			txtmasp.Clear();
			tensanpham.Clear();
			soluong.Value = 0;
			txtdongiasp.Clear();
			txttiensp.Clear();
		}
		public void huyhd()
		{
			txtmasp.Clear();
			txtdongiasp.Clear();
			txttiensp.Clear();
			txttongcongtiensp.Clear();
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();
		}
		private void btnthem_Click(object sender, EventArgs e)
		{
			try
			{

				
				String idsp = txtmasp.Text;
				if (chb_combo.Checked)
				{
					idsp = "c_" + idsp;
				}

				// kiem tra trung
				int tt = 0;
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (idsp.Equals(row.Cells[0].Value))
                    {
						throw new Exception("san pham da co trong gio hang");
                    }
					 
				}

                
					String sl = soluong.Value.ToString();

				if (soluong.Value <= 0)
                {
					throw new Exception("So luong phai lon hon 0");
                }
				String name = tensanpham.Text;
				String txtdongia = txtdongiasp.Text;
				String loai = "";
				if (idsp.StartsWith("c_"))
                {
					String idc = idsp.Split('_')[1];
					int id_combo = Convert.ToInt32(idc);
					loai = "combo";
					Combo _combo = _context.Combo.Where(m=>m.ID== id_combo).FirstOrDefault();
					String[] ids = _combo.Product_List.Split(';');
					for (int i = 0; i < ids.Length; i++)
					{
						int idsptemp = Convert.ToInt32(ids[i]);
						Product pro = _context.Product.Where(m => m.ID == idsptemp).FirstOrDefault();
						if(pro.Amount == 0)
                        {
							throw new Exception("trong combo có san pham ma là :"+pro.ID+" hết hàng");
                        }

					}

				}
                else {
					Product pr = productDAO.getByID(Convert.ToInt32(idsp));
				    loai = catalogDAO.getByID(Convert.ToInt32(pr.Catalog_ID)).Catalog_Name;
					if(pr.Amount < soluong.Value)
                    {
						throw new Exception("sản pahmr chỉ còn lại :"+pr.Amount);
                    }
				}
				String[] data = { idsp, name, loai, sl, txtdongia };
				dataGridView1.Rows.Add(data);			
				clearsp();
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					tt += Convert.ToInt32(row.Cells[3].Value) * Convert.ToInt32(row.Cells[4].Value);
				}
					txttongcongtiensp.Text = tt.ToString();

			}
			catch(Exception ex)
            {
				MessageBox.Show("error:"+ex.Message);
			}
		}

		private void btnsua_Click(object sender, EventArgs e)
		{
            try{



            }catch(Exception ex)
            {
				MessageBox.Show("error:" + ex.Message);
			}

		   

		   clearsp();
		}
		string maspedit;
		int slspedit;
		private void dataGridView1_DoubleClick(object sender, EventArgs e)
		{
			
			
		}
		string masp1;
		int slsp1;
		private void btnxoa_Click(object sender, EventArgs e)
		{

			foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
			{
				DataGridViewRow row = dataGridView1.Rows[item.Index];
				masp1 = row.Cells[0].Value.ToString();
				slsp1 = Convert.ToInt32(row.Cells[2].Value.ToString());
				dataGridView1.Rows.RemoveAt(item.Index); //remove row in datagridview
			}
			//------------- tra lai soluong sp database -----------------//
			try
			{
				using (var cmdupdatesl2 = new SqlCommand("update tonkho set soluongsp=soluongsp + '" + slsp1 + "' where masp='" + masp1 + "' "))
				{
					cmdupdatesl2.Connection = connect;
					connect.Open();
					if (cmdupdatesl2.ExecuteNonQuery() > 0)
					{
						MessageBox.Show("Đã update");
					}
					else
					{
						MessageBox.Show("Không thành công!");
					}
					connect.Close();
				}
			}
			catch (Exception ex)
			{
				connect.Close();
				MessageBox.Show("loi update ne" + ex.Message);
			}
			//-----------------------------------------//
		}

		private void btnhuy_Click(object sender, EventArgs e)
		{
			try
			{
				bool checkbox_combo = chb_combo.Checked;
			int idsanpham = Convert.ToInt32(txtmasp.Text);
			if (checkbox_combo != true)
            {
					//tim trong bang product
					Product p = productDAO.getByID(idsanpham);
					if(p != null)
                    {
						txtdongiasp.Text = p.Price.ToString();
						tensanpham.Text = p.Product_Name;
						soluong.Value = 0;
						int sl = Convert.ToInt32(soluong.Text);
						
						txttiensp.Text = (sl * Convert.ToInt32(txtdongiasp.Text)).ToString();
					}
                    else
                    {
						MessageBox.Show("Không tìm thấy!");
					}
			}
            else
            {
					//tim trong bang combo
					Combo combo = comboDAO.getByID(idsanpham);
					if (combo != null)
					{
						txtdongiasp.Text = combo.totalMoney.ToString();
						tensanpham.Text = combo.Combo_Name;
					}
					else
					{
						MessageBox.Show("Không tìm thấy!");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tìm thấy!");
			}

		}

		private void txttongcongtiensp_TextChanged(object sender, EventArgs e)
		{
			//txtthanhtoan.Text = txttongcongtiensp.Text;
		}

		private void txtgiamtientong_TextChanged(object sender, EventArgs e)
		{
			/*txtgiamphantramtong.Enabled = false;
			txtcongtientong.Enabled = false;
			txtcongphantramtong.Enabled = false;
			if (string.IsNullOrWhiteSpace(txtgiamtientong.Text))
			{
				txtthanhtoan.Text = txttongcongtiensp.Text;
				txtgiamphantramtong.Enabled = true;
				txtcongtientong.Enabled = true;
				txtcongphantramtong.Enabled = true;
			}
			else if(txtgiamtientong.Text.StartsWith(","))
			{
				MessageBox.Show("loi .");
			}
			else
			{
				double tongcongtiensp;
				double trutientongcong;
				double TCtiensaukhitru;
				tongcongtiensp = double.Parse(txttongcongtiensp.Text);
				trutientongcong = double.Parse(txtgiamtientong.Text);
				if (trutientongcong > tongcongtiensp)
				{
					MessageBox.Show("sai tham số > tổng tiền");
					txtthanhtoan.Text = txttongcongtiensp.Text;
				}
				else
				{
					TCtiensaukhitru = tongcongtiensp - trutientongcong;
					txtthanhtoan.Text = TCtiensaukhitru.ToString("###,###");
					//pass form TT
				  //  HDthanhtoan = txtthanhtoan.Text;
				}
			}*/
		}

		private void txtgiamphantramtong_TextChanged(object sender, EventArgs e)
		{
			//txtgiamtientong.Enabled = false;
			//txtcongtientong.Enabled = false;
			//txtcongphantramtong.Enabled = false;
			//if (string.IsNullOrWhiteSpace(txtgiamphantramtong.Text))
			//{
			//	txtthanhtoan.Text = txttongcongtiensp.Text;
			//	txtgiamtientong.Enabled = true;
			//	txtcongtientong.Enabled = true;
			//	txtcongphantramtong.Enabled = true;
			//}
			//else if (txtgiamphantramtong.Text.StartsWith("."))
			//{
			//	MessageBox.Show("loi .");
			//}
			//else
			//{
			//	txtgiamtientong.Enabled = false;
			//	double tongcongtiensp;
			//	double truphantramtong;
			//	double TCtiensaukhitruPT;
			//	double TCtiensaukhitruPT2;
			//	tongcongtiensp = double.Parse(txttongcongtiensp.Text);
			//	truphantramtong = double.Parse(txtgiamphantramtong.Text);
			//
			//	if (truphantramtong < 0)
			//	{
			//		MessageBox.Show("sai tham số <0");
			//		txtthanhtoan.Text = txttongcongtiensp.Text;
			//	}
			//	else if (truphantramtong > 0)
			//	{
			//		TCtiensaukhitruPT = (truphantramtong * tongcongtiensp) / 100;
			//		TCtiensaukhitruPT2 = tongcongtiensp - TCtiensaukhitruPT;
			//		txtthanhtoan.Text = TCtiensaukhitruPT2.ToString("###,###");
			//	}
			//	else if (truphantramtong > 100)
			//	{
			//		MessageBox.Show("sai tham số >100");
			//		txtthanhtoan.Text = txttongcongtiensp.Text;
			//	}
			//
			//}

		}

		private void txtgiamtientong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar!=',')
			{
				e.Handled = true;
			}
		}

		private void txtgiamphantramtong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private void txtcongtientong_TextChanged(object sender, EventArgs e)
		{
			//txtcongphantramtong.Enabled = false;
			//txtgiamtientong.Enabled = false;
			//txtgiamphantramtong.Enabled = false;
			//if (string.IsNullOrWhiteSpace(txtcongtientong.Text))
			//{
			//	txtthanhtoan.Text = txttongcongtiensp.Text;
			//	txtcongphantramtong.Enabled = true;
			//	txtgiamtientong.Enabled = true;
			//	txtgiamphantramtong.Enabled = true;
			//}
			//else if (txtcongtientong.Text.StartsWith(","))
			//{
			//	MessageBox.Show("loi .");
			//}
			//else
			//{
			//	double tongcongtiensp;
			//	double congtientongcong;
			//	double TCtiensaukhitru;
			//	tongcongtiensp = double.Parse(txttongcongtiensp.Text);
			//	congtientongcong = double.Parse(txtcongtientong.Text);
			//	if (congtientongcong > tongcongtiensp)
			//	{
			//		MessageBox.Show("sai tham số > tổng tiền");
			//		txtthanhtoan.Text = txttongcongtiensp.Text;
			//	}
			//	else
			//	{
			//		TCtiensaukhitru = tongcongtiensp + congtientongcong;
			//		txtthanhtoan.Text = TCtiensaukhitru.ToString("###,###");
			//	}
			//}
		}

		private void txtcongphantramtong_TextChanged(object sender, EventArgs e)
		{
			//txtcongtientong.Enabled = false;
			//txtgiamtientong.Enabled = false;
			//txtgiamphantramtong.Enabled = false;
			//if (string.IsNullOrWhiteSpace(txtcongphantramtong.Text))
			//{
			//	txtthanhtoan.Text = txttongcongtiensp.Text;
			//	txtgiamtientong.Enabled = true;
			//	txtgiamtientong.Enabled = true;
			//	txtgiamphantramtong.Enabled = true;
			//}
			//else if (txtcongphantramtong.Text.StartsWith("."))
			//{
			//	MessageBox.Show("loi .");
			//}
			//else
			//{
			// //   txtcongtientong.Enabled = false;
			//	double tongcongtiensp;
			//	double congphantramtong;
			//	double TCtiensaukhicongPT;
			//	double TCtiensaukhicongPT2;
			//
			//	tongcongtiensp = double.Parse(txttongcongtiensp.Text);
			//	congphantramtong = double.Parse(txtcongphantramtong.Text);
			//
			//	if (congphantramtong < 0)
			//	{
			//		MessageBox.Show("sai tham số <0");
			//		txtthanhtoan.Text = txttongcongtiensp.Text;
			//	}
			//	else if (congphantramtong > 0)
			//	{
			//		TCtiensaukhicongPT = (congphantramtong * tongcongtiensp) / 100;
			//		TCtiensaukhicongPT2 = TCtiensaukhicongPT + tongcongtiensp;
			//		txtthanhtoan.Text = TCtiensaukhicongPT2.ToString("###,###");
			//	}
			//	else if (congphantramtong > 100)
			//	{
			//		MessageBox.Show("sai tham số >100");
			//		txtthanhtoan.Text = txttongcongtiensp.Text;
			//	}
			//
			//}
		}

		private void txtcongphantramtong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
			{
				e.Handled = true;
			}
		}

		private void txtcongtientong_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
			{
				e.Handled = true;
			}
		}
		string colmasp;
		string coltensp;
		string colslsp;
		string colloaisp;
		string coldvsp;
		string coldongiasp;
		private void btnthanhtoan_Click(object sender, EventArgs e)
		{
            try
            {
				if (cbc_kh.SelectedItem==null)
                {
					throw new Exception("chua chon khach hang");
                }
				if(dataGridView1.Rows.Count == 0)
                {
					throw new Exception("chua co san pham nao");
				}
				int idiv = _context.Invoice.Count() + 1;
				Invoice invoice = new Invoice();
				invoice.createdDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss").ToString();
				invoice.customerAddress = "";
				invoice.Invoice_Name = "In shop invoice";
				invoice.shipDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss").ToString(); 
				invoice.Shipper_ID = null;
				invoice.status = 2;
				invoice.totalMoney = txttongcongtiensp.Text;
				invoice.Customer_ID = Convert.ToInt32(cbc_kh.SelectedItem.ToString().Split('_')[1]);
				List<InvoiceDetail> l_detailInvoice = new List<InvoiceDetail>();
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					InvoiceDetail invoiceDetail = new InvoiceDetail();
					if(row.Cells[0].Value.ToString().StartsWith("c_"))
                    {
						invoiceDetail.Product_ID = -1;
						invoiceDetail.Combo_ID =Convert.ToInt32(row.Cells[0].Value.ToString().Split('_')[1]);
						Combo c = _context.Combo.Where(m => m.ID == invoiceDetail.Combo_ID).FirstOrDefault();
						String[] ids = c.Product_List.Split(';');
						for(int i = 0; i < ids.Length; i++)
                        {
							int idsp = Convert.ToInt32(ids[i]);
							Product pro = _context.Product.Where(m => m.ID == idsp).FirstOrDefault();
							pro.Amount = pro.Amount - 1;
							_context.SaveChanges();

                        }
                    }
                    else
                    {
						invoiceDetail.Combo_ID = -1;
						invoiceDetail.Product_ID = Convert.ToInt32(row.Cells[0].Value.ToString());
						Product pro = _context.Product.Where(m => m.ID == invoiceDetail.Product_ID).FirstOrDefault();
						pro.Amount = pro.Amount - invoiceDetail.Amount;
						_context.SaveChanges();
					}
					invoiceDetail.Amount = Convert.ToInt32(row.Cells[3].Value);
					invoiceDetail.Invoice_ID = idiv;
					invoiceDetail.Price= Convert.ToInt32(row.Cells[4].Value);
					l_detailInvoice.Add(invoiceDetail);
					
				}

				//save
				_context.Invoice.Add(invoice);
				l_detailInvoice.ForEach(i =>
				{
					//save invoice detail
					string strSQL = "INSERT INTO InvoiceDetail ";
					strSQL += " (Invoice_ID,Product_ID,Combo_ID,Amount,Price)";
					strSQL += " VALUES";
					strSQL += " (@Invoice_ID,@Product_ID,@Combo_ID,@Amount";
					strSQL += ",@Price)";
					List<SqlParameter> parameterList = new List<SqlParameter>();
					parameterList.Add(new SqlParameter("@Invoice_ID", i.Invoice_ID));
					parameterList.Add(new SqlParameter("@Product_ID", i.Product_ID));
					parameterList.Add(new SqlParameter("@Combo_ID", i.Combo_ID));
					parameterList.Add(new SqlParameter("@Amount", i.Amount));
					parameterList.Add(new SqlParameter("@Price", i.Price));
					
					SqlParameter[] Param = parameterList.ToArray();

					int noOfRowInserted = _context.Database.ExecuteSqlCommand(strSQL, Param);
				});
				_context.SaveChanges();
				dataGridView1.Rows.Clear();
				txttongcongtiensp.Clear();

				//giam so luong san pham
				
				MessageBox.Show("Thanh cong");


			}
			catch (Exception ex)
            {
				MessageBox.Show("error :"+ex.Message);
            }
			
		}

		

		private void BanHang_Load(object sender, EventArgs e)
		{
			//try
			//{
			//	autoidHD();
			//	string sqltensp = "select Product_Name from Product";
			//	SqlCommand cmd = new SqlCommand(sqltensp, connect);
			//	connect.Open();
			//	SqlDataReader dr = cmd.ExecuteReader();
			//	AutoCompleteStringCollection autotensp = new AutoCompleteStringCollection();
			//	while (dr.Read())
			//	{
			//		autotensp.Add(dr.GetString(0));
			//		
			//	}
			//	txttensp.AutoCompleteMode = AutoCompleteMode.Suggest;
			//	txttensp.AutoCompleteSource = AutoCompleteSource.CustomSource;
			//	txttensp.AutoCompleteCustomSource = autotensp;
			//	connect.Close();
			//}
			//catch(Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}

		}

		

		

		private void txtmasp_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				double giamgiaTextbox;
				connect.Open();
				string sqlsp = "select * from tonkho where (masp= '" + txtmasp.Text + "') ";
				SqlCommand cmd2 = new SqlCommand(sqlsp, connect);
				SqlDataReader dr2 = cmd2.ExecuteReader();
				if (dr2.Read())
				{

				}
				connect.Close();
			}
		}

		
		

		

		
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
			
		}

        private void soluong_Click(object sender, EventArgs e)
        {
			int sl = Convert.ToInt32(soluong.Text);

			txttiensp.Text = (sl * Convert.ToInt32(txtdongiasp.Text)).ToString();
		}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (dataGridView1.CurrentRow.Index != -1)
			{
				clearsp();


				txtmasp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
				tensanpham.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
				txtdongiasp.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
				soluong.Value =Convert.ToInt32( dataGridView1.CurrentRow.Cells[3].Value.ToString());

			}
			else
			{
				MessageBox.Show("No data!");
			}
		}

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
			foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
			{
				dataGridView1.Rows.RemoveAt(item.Index);
				txttongcongtiensp.Text = ((Convert.ToInt32(txttongcongtiensp.Text) - (Convert.ToInt32(item.Cells[3].Value) * Convert.ToInt32(item.Cells[4].Value)))).ToString();
			}
		}
    }
}
