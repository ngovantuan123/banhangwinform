using DoAn_2.DAL;
using DoAn_2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_2.MenuTab
{
	public partial class LoaiSP : Form
	{
		CatalogDAO catalogDAO = new CatalogDAO();
		SqlConnection connect = ClassKetnoi.connect;
		public LoaiSP()
		{
			InitializeComponent();
			loadtable();

		}
		private void autoidSPLoai()
		{
			// todo connect.Open();
			// todo SqlCommand cmd = new SqlCommand("select count(IDloai) from loaisp", connect);
			// todo int i = Convert.ToInt32(cmd.ExecuteScalar());
			// todo i++;
			// todo textBoxID.Text = i.ToString();
			// todo connect.Close();
		}
		private void clear()
		{
			textBoxTenLoai.Clear();
			textBoxID.Clear();
		}
		private void gridviewsploai()
		{

			
		}
		private void loadtable()
        {
			while (dataGridViewLoaiSPloai.Rows.Count > 0)
			{
				dataGridViewLoaiSPloai.Rows.RemoveAt(0);
			}
			List<Catalog> list = catalogDAO.getAll();
			String[] datas = { "", "" };
			list.ForEach(m => {
				datas[0] = m.ID.ToString();
				datas[1] = m.Catalog_Name;
				dataGridViewLoaiSPloai.Rows.Add(datas);
			});
		}
		private void iconButton4_Click(object sender, EventArgs e)
		{
			clear();
			autoidSPLoai();
		}

		private void dataGridViewLoaiSP_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewLoaiSPloai.CurrentRow.Index != -1)
			{
				clear();
				textBoxID.Text = dataGridViewLoaiSPloai.CurrentRow.Cells[0].Value.ToString();
				textBoxTenLoai.Text = dataGridViewLoaiSPloai.CurrentRow.Cells[1].Value.ToString();
				// lam toi day roi ne
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			if (textBoxTenLoai.Text.Equals(""))
			{
				MessageBox.Show("Tên thể loại trống!");
			}
			else
			{
				try
				{
					Catalog ca = new Catalog();
					ca.ID = Convert.ToInt32(textBoxID.Text);
					ca.Catalog_Name = textBoxTenLoai.Text;
					catalogDAO.update(ca);
					clear();
					loadtable();
					MessageBox.Show("Sửa thành công");
				}
				catch (Exception ex)
				{
					connect.Close();
					MessageBox.Show("lỗi khi sửa: " + ex.Message);
				}
			}
			
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			if (!textBoxID.Text.Equals(""))
			{
				MessageBox.Show("Thể loại đã tồn tại!");

			}
			else if (textBoxTenLoai.Text.Equals(""))
            {
				MessageBox.Show("Tên thể loại trống!");

			}
			else
			{
                try
                {
					Catalog c = new Catalog();
					c.Catalog_Name = textBoxTenLoai.Text;
					catalogDAO.save(c);
					clear();
					loadtable();
					MessageBox.Show("Thêm thành công!");
				}	
				catch(Exception ex)
                {
					MessageBox.Show("Thêm thất bại :"+ex.Message);
				}
			}
		}


		private void LoaiSP_Load(object sender, EventArgs e)
		{
			autoidSPLoai();
			gridviewsploai();
		}

        private void btnclear_Click(object sender, EventArgs e)
        {
			clear();
        }
    }
}
