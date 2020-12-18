namespace DoAn_2.MenuTab
{
    partial class donhang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dgvDonHang = new System.Windows.Forms.DataGridView();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.ButtonReloadTable = new FontAwesome.Sharp.IconButton();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.btnExportExcel = new FontAwesome.Sharp.IconButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDonHang
			// 
			this.dgvDonHang.AllowUserToAddRows = false;
			this.dgvDonHang.AllowUserToDeleteRows = false;
			this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDonHang.Location = new System.Drawing.Point(24, 81);
			this.dgvDonHang.Name = "dgvDonHang";
			this.dgvDonHang.ReadOnly = true;
			this.dgvDonHang.Size = new System.Drawing.Size(835, 318);
			this.dgvDonHang.TabIndex = 0;
			this.dgvDonHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Location = new System.Drawing.Point(24, 54);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(260, 20);
			this.textBoxSearch.TabIndex = 1;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.AutoSize = true;
			this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSearch.Location = new System.Drawing.Point(21, 19);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(295, 32);
			this.labelSearch.TabIndex = 2;
			this.labelSearch.Text = "Tìm kiếm theo: ID hóa đơn, Tổng tiền thanh toán, \r\nSĐT khách hàng, Tên khách hàng" +
    ".";
			// 
			// ButtonReloadTable
			// 
			this.ButtonReloadTable.IconChar = FontAwesome.Sharp.IconChar.None;
			this.ButtonReloadTable.IconColor = System.Drawing.Color.Black;
			this.ButtonReloadTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.ButtonReloadTable.IconSize = 16;
			this.ButtonReloadTable.Location = new System.Drawing.Point(301, 51);
			this.ButtonReloadTable.Name = "ButtonReloadTable";
			this.ButtonReloadTable.Size = new System.Drawing.Size(75, 23);
			this.ButtonReloadTable.TabIndex = 5;
			this.ButtonReloadTable.Text = "Reload";
			this.ButtonReloadTable.UseVisualStyleBackColor = true;
			this.ButtonReloadTable.Click += new System.EventHandler(this.ButtonReloadTable_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(659, 51);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 4;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnExportExcel.IconColor = System.Drawing.Color.Black;
			this.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExportExcel.IconSize = 16;
			this.btnExportExcel.Location = new System.Drawing.Point(659, 8);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(200, 37);
			this.btnExportExcel.TabIndex = 6;
			this.btnExportExcel.Text = "Xuất Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// donhang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 411);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.ButtonReloadTable);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.labelSearch);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.dgvDonHang);
			this.Name = "donhang";
			this.Text = "Đơn hàng";
			this.Load += new System.EventHandler(this.donhang_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.DataGridView dgvDonHang;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Label labelSearch;
		private FontAwesome.Sharp.IconButton ButtonReloadTable;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private FontAwesome.Sharp.IconButton btnExportExcel;
	}
}