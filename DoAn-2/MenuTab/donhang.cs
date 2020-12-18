using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DoAn_2.MenuTab
{
    public partial class donhang : Form
    {
        public static string hdid = "";
        public static string hdmasp = "";
        public static string hdtensp = "";
        public static string hdsl = "";
        public static string hddongia = "";
        public static string hdloai = "";
        public static string hddonvi = "";
        public static string hdthanhtoan = "";
        public static string sdt = "";
        public static string tenkh = "";
        public static string hdtime = "";
        public static string hdno = "";
        public static string nvtt = "";

        // init
        public donhang()
        {
            InitializeComponent();

            // update
        }

        // mt code
        private void updateTable()
		{
            //dgvDonHang
            // 0 chua xac nhan 1 dang giao 2 xong status

		}

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.CurrentRow.Index != -1)
            {
                hdid = dgvDonHang.CurrentRow.Cells[0].Value.ToString();
                hdmasp = dgvDonHang.CurrentRow.Cells[1].Value.ToString();
                hdtensp = dgvDonHang.CurrentRow.Cells[2].Value.ToString();
                hdsl = dgvDonHang.CurrentRow.Cells[4].Value.ToString();
                hddongia = dgvDonHang.CurrentRow.Cells[5].Value.ToString();
                hdloai = dgvDonHang.CurrentRow.Cells[8].Value.ToString();
                hddonvi = dgvDonHang.CurrentRow.Cells[9].Value.ToString();
                hdthanhtoan = dgvDonHang.CurrentRow.Cells[6].Value.ToString();
                sdt = dgvDonHang.CurrentRow.Cells[10].Value.ToString();
                tenkh = dgvDonHang.CurrentRow.Cells[3].Value.ToString();
                hdtime = dgvDonHang.CurrentRow.Cells[7].Value.ToString();
                hdno = dgvDonHang.CurrentRow.Cells[11].Value.ToString();
                nvtt = dgvDonHang.CurrentRow.Cells[12].Value.ToString();

                var form2 = new HoaDonChiTiet();
                form2.Show();
            }
            else
            {
                //
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void ButtonReloadTable_Click(object sender, EventArgs e)
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
    }
}
