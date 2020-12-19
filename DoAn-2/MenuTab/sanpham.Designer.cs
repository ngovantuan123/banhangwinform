namespace DoAn_2.MenuTab
{
    partial class sanpham
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
            this.dgvlstProduct = new System.Windows.Forms.DataGridView();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.comboloai = new System.Windows.Forms.ComboBox();
            this.btnExportExcel = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnButtonChooseIMG = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clm_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ảnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlstProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlstProduct
            // 
            this.dgvlstProduct.AllowUserToAddRows = false;
            this.dgvlstProduct.AllowUserToDeleteRows = false;
            this.dgvlstProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlstProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlstProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvlstProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlstProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_id,
            this.clm_name,
            this.clm_type,
            this.clm_amount,
            this.clm_price,
            this.Ảnh});
            this.dgvlstProduct.Location = new System.Drawing.Point(309, 88);
            this.dgvlstProduct.Name = "dgvlstProduct";
            this.dgvlstProduct.ReadOnly = true;
            this.dgvlstProduct.Size = new System.Drawing.Size(563, 311);
            this.dgvlstProduct.TabIndex = 0;
            this.dgvlstProduct.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dgvlstProduct.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvlstProduct_MouseDoubleClick);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(114, 88);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(180, 20);
            this.txttensp.TabIndex = 2;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(114, 114);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(180, 20);
            this.txtsl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Loại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Giá bán";
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(114, 140);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(180, 20);
            this.txtgiaban.TabIndex = 12;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(17, 243);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(122, 40);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(163, 243);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(131, 40);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Sửa";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // comboloai
            // 
            this.comboloai.FormattingEnabled = true;
            this.comboloai.Location = new System.Drawing.Point(114, 166);
            this.comboloai.Name = "comboloai";
            this.comboloai.Size = new System.Drawing.Size(180, 21);
            this.comboloai.TabIndex = 27;
            this.comboloai.SelectedIndexChanged += new System.EventHandler(this.comboloai_SelectedIndexChanged);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnExportExcel.IconColor = System.Drawing.Color.Black;
            this.btnExportExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportExcel.IconSize = 16;
            this.btnExportExcel.Location = new System.Drawing.Point(672, 11);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(200, 37);
            this.btnExportExcel.TabIndex = 34;
            this.btnExportExcel.Text = "Xuất Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(672, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnButtonChooseIMG
            // 
            this.btnButtonChooseIMG.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnButtonChooseIMG.IconColor = System.Drawing.Color.Black;
            this.btnButtonChooseIMG.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnButtonChooseIMG.IconSize = 16;
            this.btnButtonChooseIMG.Location = new System.Drawing.Point(163, 323);
            this.btnButtonChooseIMG.Name = "btnButtonChooseIMG";
            this.btnButtonChooseIMG.Size = new System.Drawing.Size(131, 47);
            this.btnButtonChooseIMG.TabIndex = 24;
            this.btnButtonChooseIMG.Text = "Chọn ảnh";
            this.btnButtonChooseIMG.UseVisualStyleBackColor = true;
            this.btnButtonChooseIMG.Click += new System.EventHandler(this.btnButtonChooseIMG_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoAn_2.Properties.Resources._default;
            this.pictureBox1.Location = new System.Drawing.Point(17, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtanh
            // 
            this.txtanh.Enabled = false;
            this.txtanh.Location = new System.Drawing.Point(114, 193);
            this.txtanh.Name = "txtanh";
            this.txtanh.Size = new System.Drawing.Size(180, 20);
            this.txtanh.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ảnh";
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
            // clm_type
            // 
            this.clm_type.HeaderText = "Loại";
            this.clm_type.Name = "clm_type";
            this.clm_type.ReadOnly = true;
            // 
            // clm_amount
            // 
            this.clm_amount.HeaderText = "Số lượng";
            this.clm_amount.Name = "clm_amount";
            this.clm_amount.ReadOnly = true;
            // 
            // clm_price
            // 
            this.clm_price.HeaderText = "Giá";
            this.clm_price.Name = "clm_price";
            this.clm_price.ReadOnly = true;
            // 
            // Ảnh
            // 
            this.Ảnh.HeaderText = "Ảnh";
            this.Ảnh.Name = "Ảnh";
            this.Ảnh.ReadOnly = true;
            // 
            // sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtanh);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboloai);
            this.Controls.Add(this.btnButtonChooseIMG);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsl);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.dgvlstProduct);
            this.Name = "sanpham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlstProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlstProduct;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.ComboBox comboloai;
        private FontAwesome.Sharp.IconButton btnExportExcel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private FontAwesome.Sharp.IconButton btnButtonChooseIMG;
		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ảnh;
    }
}