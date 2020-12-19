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
			this.clm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_totalmoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_adr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnExportExcel = new FontAwesome.Sharp.IconButton();
			this.btnDetail = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDonHang
			// 
			this.dgvDonHang.AllowUserToAddRows = false;
			this.dgvDonHang.AllowUserToDeleteRows = false;
			this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_id,
            this.clm_name,
            this.clm_customer,
            this.clm_totalmoney,
            this.clm_createdate,
            this.clm_adr,
            this.clm_status});
			this.dgvDonHang.Location = new System.Drawing.Point(24, 51);
			this.dgvDonHang.Name = "dgvDonHang";
			this.dgvDonHang.ReadOnly = true;
			this.dgvDonHang.Size = new System.Drawing.Size(835, 348);
			this.dgvDonHang.TabIndex = 0;
			this.dgvDonHang.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			// 
			// clm_id
			// 
			this.clm_id.HeaderText = "ID";
			this.clm_id.Name = "clm_id";
			this.clm_id.ReadOnly = true;
			// 
			// clm_name
			// 
			this.clm_name.HeaderText = "Tên";
			this.clm_name.Name = "clm_name";
			this.clm_name.ReadOnly = true;
			// 
			// clm_customer
			// 
			this.clm_customer.HeaderText = "Khách hàng";
			this.clm_customer.Name = "clm_customer";
			this.clm_customer.ReadOnly = true;
			// 
			// clm_totalmoney
			// 
			this.clm_totalmoney.HeaderText = "Thành tiền";
			this.clm_totalmoney.Name = "clm_totalmoney";
			this.clm_totalmoney.ReadOnly = true;
			// 
			// clm_createdate
			// 
			this.clm_createdate.HeaderText = "Ngày tạo";
			this.clm_createdate.Name = "clm_createdate";
			this.clm_createdate.ReadOnly = true;
			// 
			// clm_adr
			// 
			this.clm_adr.HeaderText = "Địa chỉ";
			this.clm_adr.Name = "clm_adr";
			this.clm_adr.ReadOnly = true;
			// 
			// clm_status
			// 
			this.clm_status.HeaderText = "Trạng thái";
			this.clm_status.Name = "clm_status";
			this.clm_status.ReadOnly = true;
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
			// btnDetail
			// 
			this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDetail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetail.ForeColor = System.Drawing.SystemColors.Desktop;
			this.btnDetail.Location = new System.Drawing.Point(474, 8);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(179, 37);
			this.btnDetail.TabIndex = 7;
			this.btnDetail.Text = "Chi tiết";
			this.btnDetail.UseVisualStyleBackColor = true;
			this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(302, 8);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(166, 37);
			this.btnRefresh.TabIndex = 8;
			this.btnRefresh.Text = "Làm mới";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "ID Khách hàng:";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(109, 18);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(83, 20);
			this.txtSearch.TabIndex = 10;
			this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// donhang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 411);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnDetail);
			this.Controls.Add(this.btnExportExcel);
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
		private FontAwesome.Sharp.IconButton btnExportExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_totalmoney;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_createdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_adr;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_status;
		private System.Windows.Forms.Button btnDetail;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSearch;
	}
}