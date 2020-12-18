namespace DoAn_2.MenuTab
{
    partial class combo
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
			this.dgvCombo = new System.Windows.Forms.DataGridView();
			this.clm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_lstPrd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_edate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_nprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.clm_discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txttotalmoney = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtdiscount = new System.Windows.Forms.TextBox();
			this.txtdiscountmoney = new System.Windows.Forms.TextBox();
			this.btnsave = new System.Windows.Forms.Button();
			this.btnedit = new System.Windows.Forms.Button();
			this.btnExportExcel = new FontAwesome.Sharp.IconButton();
			this.dtpSDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEDate = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.cbbLstPrd = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnAddPrd = new System.Windows.Forms.Button();
			this.txtIdPrd = new System.Windows.Forms.TextBox();
			this.btnDelPrd = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.lblNamePrd = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCombo
			// 
			this.dgvCombo.AllowUserToAddRows = false;
			this.dgvCombo.AllowUserToDeleteRows = false;
			this.dgvCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCombo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCombo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCombo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_id,
            this.clm_name,
            this.clm_lstPrd,
            this.clm_bdate,
            this.clm_edate,
            this.clm_price,
            this.clm_nprice,
            this.clm_discount});
			this.dgvCombo.Location = new System.Drawing.Point(309, 88);
			this.dgvCombo.Name = "dgvCombo";
			this.dgvCombo.ReadOnly = true;
			this.dgvCombo.Size = new System.Drawing.Size(563, 311);
			this.dgvCombo.TabIndex = 0;
			this.dgvCombo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCombo_MouseClick);
			// 
			// clm_id
			// 
			this.clm_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.clm_id.HeaderText = "ID";
			this.clm_id.Name = "clm_id";
			this.clm_id.ReadOnly = true;
			this.clm_id.Width = 43;
			// 
			// clm_name
			// 
			this.clm_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.clm_name.HeaderText = "Tên combo";
			this.clm_name.Name = "clm_name";
			this.clm_name.ReadOnly = true;
			this.clm_name.Width = 79;
			// 
			// clm_lstPrd
			// 
			this.clm_lstPrd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.clm_lstPrd.HeaderText = "Danh sách sản phẩm";
			this.clm_lstPrd.Name = "clm_lstPrd";
			this.clm_lstPrd.ReadOnly = true;
			this.clm_lstPrd.Width = 80;
			// 
			// clm_bdate
			// 
			this.clm_bdate.HeaderText = "Ngày bắt đầu";
			this.clm_bdate.Name = "clm_bdate";
			this.clm_bdate.ReadOnly = true;
			// 
			// clm_edate
			// 
			this.clm_edate.HeaderText = "Ngày kết thúc";
			this.clm_edate.Name = "clm_edate";
			this.clm_edate.ReadOnly = true;
			// 
			// clm_price
			// 
			this.clm_price.HeaderText = "Giá gốc";
			this.clm_price.Name = "clm_price";
			this.clm_price.ReadOnly = true;
			// 
			// clm_nprice
			// 
			this.clm_nprice.HeaderText = "Giá mới";
			this.clm_nprice.Name = "clm_nprice";
			this.clm_nprice.ReadOnly = true;
			// 
			// clm_discount
			// 
			this.clm_discount.HeaderText = "Giảm";
			this.clm_discount.Name = "clm_discount";
			this.clm_discount.ReadOnly = true;
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(114, 12);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(180, 20);
			this.txtname.TabIndex = 1;
			// 
			// txttotalmoney
			// 
			this.txttotalmoney.Location = new System.Drawing.Point(114, 67);
			this.txttotalmoney.Name = "txttotalmoney";
			this.txttotalmoney.Size = new System.Drawing.Size(144, 20);
			this.txttotalmoney.TabIndex = 3;
			this.txttotalmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotalmoney_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Tên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Thời gian";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Giá gốc";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(14, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Giảm";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Giá mới";
			// 
			// txtdiscount
			// 
			this.txtdiscount.Location = new System.Drawing.Point(114, 120);
			this.txtdiscount.Name = "txtdiscount";
			this.txtdiscount.Size = new System.Drawing.Size(69, 20);
			this.txtdiscount.TabIndex = 12;
			this.txtdiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiaban_KeyPress);
			this.txtdiscount.Leave += new System.EventHandler(this.txtdiscount_Leave);
			// 
			// txtdiscountmoney
			// 
			this.txtdiscountmoney.Location = new System.Drawing.Point(114, 93);
			this.txtdiscountmoney.Name = "txtdiscountmoney";
			this.txtdiscountmoney.Size = new System.Drawing.Size(144, 20);
			this.txtdiscountmoney.TabIndex = 11;
			this.txtdiscountmoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdiscountmoney_KeyPress);
			this.txtdiscountmoney.Leave += new System.EventHandler(this.txtdiscountmoney_Leave);
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(17, 327);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(137, 40);
			this.btnsave.TabIndex = 20;
			this.btnsave.Text = "Thêm";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			// 
			// btnedit
			// 
			this.btnedit.Location = new System.Drawing.Point(160, 327);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(134, 40);
			this.btnedit.TabIndex = 21;
			this.btnedit.Text = "Sửa";
			this.btnedit.UseVisualStyleBackColor = true;
			this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
			// 
			// btnExportExcel
			// 
			this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
			this.btnExportExcel.IconColor = System.Drawing.Color.Black;
			this.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnExportExcel.IconSize = 16;
			this.btnExportExcel.Location = new System.Drawing.Point(672, 40);
			this.btnExportExcel.Name = "btnExportExcel";
			this.btnExportExcel.Size = new System.Drawing.Size(200, 37);
			this.btnExportExcel.TabIndex = 36;
			this.btnExportExcel.Text = "Xuất Excel";
			this.btnExportExcel.UseVisualStyleBackColor = true;
			this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
			// 
			// dtpSDate
			// 
			this.dtpSDate.Location = new System.Drawing.Point(114, 38);
			this.dtpSDate.Name = "dtpSDate";
			this.dtpSDate.Size = new System.Drawing.Size(79, 20);
			this.dtpSDate.TabIndex = 38;
			// 
			// dtpEDate
			// 
			this.dtpEDate.Location = new System.Drawing.Point(215, 38);
			this.dtpEDate.Name = "dtpEDate";
			this.dtpEDate.Size = new System.Drawing.Size(79, 20);
			this.dtpEDate.TabIndex = 39;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(199, 44);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(10, 13);
			this.label9.TabIndex = 40;
			this.label9.Text = ":";
			// 
			// cbbLstPrd
			// 
			this.cbbLstPrd.FormattingEnabled = true;
			this.cbbLstPrd.Location = new System.Drawing.Point(114, 177);
			this.cbbLstPrd.Name = "cbbLstPrd";
			this.cbbLstPrd.Size = new System.Drawing.Size(180, 21);
			this.cbbLstPrd.TabIndex = 42;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 16);
			this.label4.TabIndex = 43;
			this.label4.Text = "DS Sản phẩm";
			// 
			// btnAddPrd
			// 
			this.btnAddPrd.Location = new System.Drawing.Point(17, 212);
			this.btnAddPrd.Name = "btnAddPrd";
			this.btnAddPrd.Size = new System.Drawing.Size(75, 23);
			this.btnAddPrd.TabIndex = 44;
			this.btnAddPrd.Text = "thêm sp";
			this.btnAddPrd.UseVisualStyleBackColor = true;
			this.btnAddPrd.Click += new System.EventHandler(this.btnAddPrd_Click);
			// 
			// txtIdPrd
			// 
			this.txtIdPrd.Location = new System.Drawing.Point(114, 215);
			this.txtIdPrd.Name = "txtIdPrd";
			this.txtIdPrd.Size = new System.Drawing.Size(99, 20);
			this.txtIdPrd.TabIndex = 45;
			this.txtIdPrd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtIdPrd_MouseClick);
			this.txtIdPrd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPrd_KeyPress);
			this.txtIdPrd.Leave += new System.EventHandler(this.txtIdPrd_Leave);
			// 
			// btnDelPrd
			// 
			this.btnDelPrd.Location = new System.Drawing.Point(17, 241);
			this.btnDelPrd.Name = "btnDelPrd";
			this.btnDelPrd.Size = new System.Drawing.Size(75, 23);
			this.btnDelPrd.TabIndex = 46;
			this.btnDelPrd.Text = "xóa sp";
			this.btnDelPrd.UseVisualStyleBackColor = true;
			this.btnDelPrd.Click += new System.EventHandler(this.btnDelPrd_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(264, 70);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 13);
			this.label7.TabIndex = 47;
			this.label7.Text = "VNĐ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(264, 96);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 48;
			this.label8.Text = "VNĐ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(189, 123);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(15, 13);
			this.label10.TabIndex = 49;
			this.label10.Text = "%";
			// 
			// lblNamePrd
			// 
			this.lblNamePrd.AutoSize = true;
			this.lblNamePrd.Location = new System.Drawing.Point(111, 246);
			this.lblNamePrd.Name = "lblNamePrd";
			this.lblNamePrd.Size = new System.Drawing.Size(75, 13);
			this.lblNamePrd.TabIndex = 50;
			this.lblNamePrd.Text = "Tên sản phẩm";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(219, 218);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 13);
			this.label11.TabIndex = 51;
			this.label11.Text = "(ID Sản phẩm)";
			// 
			// combo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 411);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.lblNamePrd);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnDelPrd);
			this.Controls.Add(this.txtIdPrd);
			this.Controls.Add(this.btnAddPrd);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbbLstPrd);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtpEDate);
			this.Controls.Add(this.dtpSDate);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.btnedit);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtdiscount);
			this.Controls.Add(this.txtdiscountmoney);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txttotalmoney);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.dgvCombo);
			this.Name = "combo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Combo";
			((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttotalmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtdiscountmoney;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private FontAwesome.Sharp.IconButton btnExportExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_lstPrd;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_bdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_edate;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_price;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_nprice;
		private System.Windows.Forms.DataGridViewTextBoxColumn clm_discount;
		private System.Windows.Forms.DateTimePicker dtpSDate;
		private System.Windows.Forms.DateTimePicker dtpEDate;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox cbbLstPrd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddPrd;
		private System.Windows.Forms.TextBox txtIdPrd;
		private System.Windows.Forms.Button btnDelPrd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblNamePrd;
		private System.Windows.Forms.Label label11;
	}
}