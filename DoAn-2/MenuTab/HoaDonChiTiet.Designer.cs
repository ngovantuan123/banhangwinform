namespace DoAn_2.MenuTab
{
    partial class HoaDonChiTiet
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
			this.dgvCTDH = new System.Windows.Forms.DataGridView();
			this.hdid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.btnPdf = new System.Windows.Forms.Button();
			this.btnthanhtoanno = new System.Windows.Forms.Button();
			this.nbrAmount = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChange = new System.Windows.Forms.Button();
			this.cbbStatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nbrAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCTDH
			// 
			this.dgvCTDH.AllowUserToAddRows = false;
			this.dgvCTDH.AllowUserToDeleteRows = false;
			this.dgvCTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCTDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hdid,
            this.TenKH,
            this.masp,
            this.tensp});
			this.dgvCTDH.Location = new System.Drawing.Point(23, 66);
			this.dgvCTDH.Name = "dgvCTDH";
			this.dgvCTDH.ReadOnly = true;
			this.dgvCTDH.RowHeadersVisible = false;
			this.dgvCTDH.Size = new System.Drawing.Size(835, 318);
			this.dgvCTDH.TabIndex = 1;
			this.dgvCTDH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTDH_CellContentClick);
			// 
			// hdid
			// 
			this.hdid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.hdid.HeaderText = "Sản phẩm";
			this.hdid.Name = "hdid";
			this.hdid.ReadOnly = true;
			this.hdid.Width = 80;
			// 
			// TenKH
			// 
			this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.TenKH.HeaderText = "Combo";
			this.TenKH.Name = "TenKH";
			this.TenKH.ReadOnly = true;
			this.TenKH.Width = 65;
			// 
			// masp
			// 
			this.masp.HeaderText = "Số lượng";
			this.masp.Name = "masp";
			this.masp.ReadOnly = true;
			// 
			// tensp
			// 
			this.tensp.HeaderText = "Giá";
			this.tensp.Name = "tensp";
			this.tensp.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(702, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(156, 48);
			this.button1.TabIndex = 2;
			this.button1.Text = "In hóa đơn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnPdf
			// 
			this.btnPdf.Location = new System.Drawing.Point(549, 12);
			this.btnPdf.Name = "btnPdf";
			this.btnPdf.Size = new System.Drawing.Size(147, 48);
			this.btnPdf.TabIndex = 4;
			this.btnPdf.Text = "Xuất file PDF";
			this.btnPdf.UseVisualStyleBackColor = true;
			this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
			// 
			// btnthanhtoanno
			// 
			this.btnthanhtoanno.Location = new System.Drawing.Point(51, 12);
			this.btnthanhtoanno.Name = "btnthanhtoanno";
			this.btnthanhtoanno.Size = new System.Drawing.Size(147, 48);
			this.btnthanhtoanno.TabIndex = 6;
			this.btnthanhtoanno.Text = "Thanh toán";
			this.btnthanhtoanno.UseVisualStyleBackColor = true;
			this.btnthanhtoanno.Click += new System.EventHandler(this.btnthanhtoanno_Click);
			// 
			// nbrAmount
			// 
			this.nbrAmount.Location = new System.Drawing.Point(294, 12);
			this.nbrAmount.Name = "nbrAmount";
			this.nbrAmount.Size = new System.Drawing.Size(77, 20);
			this.nbrAmount.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(239, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Số lượng";
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(377, 12);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(129, 48);
			this.btnChange.TabIndex = 9;
			this.btnChange.Text = "Thay đổi";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// cbbStatus
			// 
			this.cbbStatus.FormattingEnabled = true;
			this.cbbStatus.Items.AddRange(new object[] {
            "Chưa xác nhận",
            "Đang giao",
            "Hoàn thành"});
			this.cbbStatus.Location = new System.Drawing.Point(242, 39);
			this.cbbStatus.Name = "cbbStatus";
			this.cbbStatus.Size = new System.Drawing.Size(129, 21);
			this.cbbStatus.TabIndex = 10;
			// 
			// HoaDonChiTiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 411);
			this.Controls.Add(this.cbbStatus);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nbrAmount);
			this.Controls.Add(this.btnthanhtoanno);
			this.Controls.Add(this.btnPdf);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvCTDH);
			this.Name = "HoaDonChiTiet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hóa đơn chi tiết";
			this.Load += new System.EventHandler(this.HoaDonChiTiet_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCTDH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nbrAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTDH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnthanhtoanno;
		private System.Windows.Forms.DataGridViewTextBoxColumn hdid;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn masp;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
		private System.Windows.Forms.NumericUpDown nbrAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.ComboBox cbbStatus;
	}
}