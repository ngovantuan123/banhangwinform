namespace DoAn_2.MenuTab
{
    partial class BanHang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongsp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiasp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttongcongtiensp = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.txtdongiasp = new System.Windows.Forms.TextBox();
            this.txttiensp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnthanhtoan = new FontAwesome.Sharp.IconButton();
            this.btnthem = new FontAwesome.Sharp.IconButton();
            this.btntim = new FontAwesome.Sharp.IconButton();
            this.cbc_kh = new System.Windows.Forms.ComboBox();
            this.chb_combo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tensanpham = new System.Windows.Forms.TextBox();
            this.soluong = new System.Windows.Forms.NumericUpDown();
            this.btnxoa = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.loaisp,
            this.soluongsp,
            this.dongiasp});
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(523, 389);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // masp
            // 
            this.masp.HeaderText = "Mã hàng";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Tên hàng";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // loaisp
            // 
            this.loaisp.HeaderText = "Loại";
            this.loaisp.Name = "loaisp";
            this.loaisp.ReadOnly = true;
            // 
            // soluongsp
            // 
            this.soluongsp.HeaderText = "SL";
            this.soluongsp.Name = "soluongsp";
            this.soluongsp.ReadOnly = true;
            // 
            // dongiasp
            // 
            this.dongiasp.HeaderText = "Đơn giá";
            this.dongiasp.Name = "dongiasp";
            this.dongiasp.ReadOnly = true;
            // 
            // txttongcongtiensp
            // 
            this.txttongcongtiensp.Location = new System.Drawing.Point(102, 463);
            this.txttongcongtiensp.Name = "txttongcongtiensp";
            this.txttongcongtiensp.Size = new System.Drawing.Size(141, 20);
            this.txttongcongtiensp.TabIndex = 3;
            this.txttongcongtiensp.TextChanged += new System.EventHandler(this.txttongcongtiensp_TextChanged);
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(638, 68);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(133, 20);
            this.txtmasp.TabIndex = 10;
            this.txtmasp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmasp_KeyDown);
            // 
            // txtdongiasp
            // 
            this.txtdongiasp.Location = new System.Drawing.Point(638, 181);
            this.txtdongiasp.Name = "txtdongiasp";
            this.txtdongiasp.ReadOnly = true;
            this.txtdongiasp.Size = new System.Drawing.Size(133, 20);
            this.txtdongiasp.TabIndex = 14;
            // 
            // txttiensp
            // 
            this.txttiensp.Location = new System.Drawing.Point(638, 218);
            this.txttiensp.Name = "txttiensp";
            this.txttiensp.ReadOnly = true;
            this.txttiensp.Size = new System.Drawing.Size(133, 20);
            this.txttiensp.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tổng cộng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(542, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Mã sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(543, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(543, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "Đơn giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(541, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Thành tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(777, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "VNĐ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(249, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 15);
            this.label16.TabIndex = 44;
            this.label16.Text = "VNĐ";
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthanhtoan.IconColor = System.Drawing.Color.Black;
            this.btnthanhtoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthanhtoan.IconSize = 16;
            this.btnthanhtoan.Location = new System.Drawing.Point(546, 353);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(332, 77);
            this.btnthanhtoan.TabIndex = 24;
            this.btnthanhtoan.Text = "Thanh toán";
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnthem
            // 
            this.btnthem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnthem.IconColor = System.Drawing.Color.Black;
            this.btnthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnthem.IconSize = 20;
            this.btnthem.Location = new System.Drawing.Point(577, 271);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(77, 55);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btntim
            // 
            this.btntim.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btntim.IconColor = System.Drawing.Color.Black;
            this.btntim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btntim.IconSize = 16;
            this.btntim.Location = new System.Drawing.Point(835, 67);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(77, 20);
            this.btntim.TabIndex = 20;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // cbc_kh
            // 
            this.cbc_kh.FormattingEnabled = true;
            this.cbc_kh.Location = new System.Drawing.Point(96, 27);
            this.cbc_kh.Name = "cbc_kh";
            this.cbc_kh.Size = new System.Drawing.Size(169, 21);
            this.cbc_kh.TabIndex = 45;
            // 
            // chb_combo
            // 
            this.chb_combo.AutoSize = true;
            this.chb_combo.Location = new System.Drawing.Point(777, 70);
            this.chb_combo.Name = "chb_combo";
            this.chb_combo.Size = new System.Drawing.Size(59, 17);
            this.chb_combo.TabIndex = 46;
            this.chb_combo.Text = "Combo";
            this.chb_combo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "VNĐ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tên ";
            // 
            // tensanpham
            // 
            this.tensanpham.Location = new System.Drawing.Point(638, 141);
            this.tensanpham.Name = "tensanpham";
            this.tensanpham.ReadOnly = true;
            this.tensanpham.Size = new System.Drawing.Size(133, 20);
            this.tensanpham.TabIndex = 50;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(638, 106);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(133, 20);
            this.soluong.TabIndex = 51;
            this.soluong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.soluong.Click += new System.EventHandler(this.soluong_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnxoa.IconColor = System.Drawing.Color.Black;
            this.btnxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnxoa.IconSize = 20;
            this.btnxoa.Location = new System.Drawing.Point(694, 271);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(77, 55);
            this.btnxoa.TabIndex = 52;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 491);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.tensanpham);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chb_combo);
            this.Controls.Add(this.cbc_kh);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.txttiensp);
            this.Controls.Add(this.txtdongiasp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.txttongcongtiensp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BanHang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txttongcongtiensp;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.TextBox txtdongiasp;
        private System.Windows.Forms.TextBox txttiensp;
        private FontAwesome.Sharp.IconButton btntim;
        private FontAwesome.Sharp.IconButton btnthem;
        private FontAwesome.Sharp.IconButton btnthanhtoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn masp;
		private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
		private System.Windows.Forms.DataGridViewTextBoxColumn loaisp;
		private System.Windows.Forms.DataGridViewTextBoxColumn soluongsp;
		private System.Windows.Forms.DataGridViewTextBoxColumn dongiasp;
        private System.Windows.Forms.ComboBox cbc_kh;
        private System.Windows.Forms.CheckBox chb_combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tensanpham;
        private System.Windows.Forms.NumericUpDown soluong;
        private FontAwesome.Sharp.IconButton btnxoa;
    }
}