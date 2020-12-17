namespace DoAn_2.MenuTab
{
    partial class tonkho
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
			this.txtid = new System.Windows.Forms.TextBox();
			this.txttensp = new System.Windows.Forms.TextBox();
			this.txtsl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtgiaban = new System.Windows.Forms.TextBox();
			this.txtgianhap = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnsave = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			this.txtsearch = new System.Windows.Forms.TextBox();
			this.comboloai = new System.Windows.Forms.ComboBox();
			this.combodonvi = new System.Windows.Forms.ComboBox();
			this.LabelSearch = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtGiamGia = new System.Windows.Forms.TextBox();
			this.btnExportExcel = new FontAwesome.Sharp.IconButton();
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
			this.dgvCombo.Location = new System.Drawing.Point(309, 88);
			this.dgvCombo.Name = "dgvCombo";
			this.dgvCombo.ReadOnly = true;
			this.dgvCombo.Size = new System.Drawing.Size(563, 311);
			this.dgvCombo.TabIndex = 0;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(114, 12);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(180, 20);
			this.txtid.TabIndex = 1;
			// 
			// txttensp
			// 
			this.txttensp.Location = new System.Drawing.Point(114, 39);
			this.txttensp.Name = "txttensp";
			this.txttensp.Size = new System.Drawing.Size(180, 20);
			this.txttensp.TabIndex = 2;
			// 
			// txtsl
			// 
			this.txtsl.Location = new System.Drawing.Point(114, 67);
			this.txtsl.Name = "txtsl";
			this.txtsl.Size = new System.Drawing.Size(180, 20);
			this.txtsl.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Mã sản phẩm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 16);
			this.label2.TabIndex = 9;
			this.label2.Text = "Tên sản phẩm";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 16);
			this.label3.TabIndex = 10;
			this.label3.Text = "Số lượng";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(14, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 16);
			this.label4.TabIndex = 16;
			this.label4.Text = "Loại";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 16);
			this.label5.TabIndex = 15;
			this.label5.Text = "Giá bán";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(14, 97);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 16);
			this.label6.TabIndex = 14;
			this.label6.Text = "Giá nhập";
			// 
			// txtgiaban
			// 
			this.txtgiaban.Location = new System.Drawing.Point(114, 120);
			this.txtgiaban.Name = "txtgiaban";
			this.txtgiaban.Size = new System.Drawing.Size(180, 20);
			this.txtgiaban.TabIndex = 12;
			// 
			// txtgianhap
			// 
			this.txtgianhap.Location = new System.Drawing.Point(114, 93);
			this.txtgianhap.Name = "txtgianhap";
			this.txtgianhap.Size = new System.Drawing.Size(180, 20);
			this.txtgianhap.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(14, 178);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.TabIndex = 18;
			this.label7.Text = "Đơn vị";
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(17, 243);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(60, 40);
			this.btnsave.TabIndex = 20;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			// 
			// btndelete
			// 
			this.btndelete.Location = new System.Drawing.Point(124, 243);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(57, 40);
			this.btndelete.TabIndex = 21;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = true;
			this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
			// 
			// txtsearch
			// 
			this.txtsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtsearch.Location = new System.Drawing.Point(309, 58);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new System.Drawing.Size(196, 20);
			this.txtsearch.TabIndex = 25;
			this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
			// 
			// comboloai
			// 
			this.comboloai.FormattingEnabled = true;
			this.comboloai.Items.AddRange(new object[] {
            "Nước ngọt",
            "Bánh",
            "Mì",
            "Nước suối",
            "Xúc xích"});
			this.comboloai.Location = new System.Drawing.Point(114, 147);
			this.comboloai.Name = "comboloai";
			this.comboloai.Size = new System.Drawing.Size(180, 21);
			this.comboloai.TabIndex = 27;
			this.comboloai.SelectedIndexChanged += new System.EventHandler(this.comboloai_SelectedIndexChanged);
			// 
			// combodonvi
			// 
			this.combodonvi.FormattingEnabled = true;
			this.combodonvi.Items.AddRange(new object[] {
            "Chai",
            "Lon",
            "Gói",
            "Hộp",
            "Thùng"});
			this.combodonvi.Location = new System.Drawing.Point(114, 178);
			this.combodonvi.Name = "combodonvi";
			this.combodonvi.Size = new System.Drawing.Size(180, 21);
			this.combodonvi.TabIndex = 28;
			// 
			// LabelSearch
			// 
			this.LabelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LabelSearch.AutoSize = true;
			this.LabelSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelSearch.Location = new System.Drawing.Point(512, 60);
			this.LabelSearch.Name = "LabelSearch";
			this.LabelSearch.Size = new System.Drawing.Size(63, 17);
			this.LabelSearch.TabIndex = 30;
			this.LabelSearch.Text = "Tìm kiếm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 211);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 16);
			this.label8.TabIndex = 32;
			this.label8.Text = "Giảm giá (%)";
			// 
			// txtGiamGia
			// 
			this.txtGiamGia.Location = new System.Drawing.Point(114, 208);
			this.txtGiamGia.Name = "txtGiamGia";
			this.txtGiamGia.Size = new System.Drawing.Size(180, 20);
			this.txtGiamGia.TabIndex = 31;
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
			// tonkho
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 411);
			this.Controls.Add(this.btnExportExcel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtGiamGia);
			this.Controls.Add(this.LabelSearch);
			this.Controls.Add(this.combodonvi);
			this.Controls.Add(this.comboloai);
			this.Controls.Add(this.txtsearch);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtgiaban);
			this.Controls.Add(this.txtgianhap);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtsl);
			this.Controls.Add(this.txttensp);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.dgvCombo);
			this.Name = "tonkho";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tồn kho";
			((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox comboloai;
        private System.Windows.Forms.ComboBox combodonvi;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGiamGia;
        private FontAwesome.Sharp.IconButton btnExportExcel;
    }
}