namespace DoAn_2
{
    partial class MainControl
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
			this.components = new System.ComponentModel.Container();
			this.PanelMenu = new System.Windows.Forms.Panel();
			this.btntheloai = new FontAwesome.Sharp.IconButton();
			this.PanelDropDownSP = new System.Windows.Forms.Panel();
			this.iconButtonSP = new FontAwesome.Sharp.IconButton();
			this.btndashboard = new FontAwesome.Sharp.IconButton();
			this.btnlogout = new FontAwesome.Sharp.IconButton();
			this.btntonkho = new FontAwesome.Sharp.IconButton();
			this.btnorders = new FontAwesome.Sharp.IconButton();
			this.btnhome = new FontAwesome.Sharp.IconButton();
			this.btnnhapkho = new FontAwesome.Sharp.IconButton();
			this.PanelLogo = new System.Windows.Forms.Panel();
			this.picLogo = new System.Windows.Forms.PictureBox();
			this.panelTitlebar = new System.Windows.Forms.Panel();
			this.lbDateTime = new System.Windows.Forms.Label();
			this.LabelUser = new System.Windows.Forms.Label();
			this.iconMinimize = new FontAwesome.Sharp.IconButton();
			this.iconZoom = new FontAwesome.Sharp.IconButton();
			this.iconExit = new FontAwesome.Sharp.IconButton();
			this.labelcon = new System.Windows.Forms.Label();
			this.iconmenusmall = new FontAwesome.Sharp.IconPictureBox();
			this.panelshadow = new System.Windows.Forms.Panel();
			this.paneltrangcon = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.PanelMenu.SuspendLayout();
			this.PanelDropDownSP.SuspendLayout();
			this.PanelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
			this.panelTitlebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).BeginInit();
			this.SuspendLayout();
			// 
			// PanelMenu
			// 
			this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.PanelMenu.Controls.Add(this.btntheloai);
			this.PanelMenu.Controls.Add(this.PanelDropDownSP);
			this.PanelMenu.Controls.Add(this.btndashboard);
			this.PanelMenu.Controls.Add(this.btnlogout);
			this.PanelMenu.Controls.Add(this.btntonkho);
			this.PanelMenu.Controls.Add(this.btnorders);
			this.PanelMenu.Controls.Add(this.btnhome);
			this.PanelMenu.Controls.Add(this.btnnhapkho);
			this.PanelMenu.Controls.Add(this.PanelLogo);
			this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.PanelMenu.Location = new System.Drawing.Point(0, 0);
			this.PanelMenu.Name = "PanelMenu";
			this.PanelMenu.Size = new System.Drawing.Size(170, 600);
			this.PanelMenu.TabIndex = 0;
			this.PanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenu_Paint);
			// 
			// btntheloai
			// 
			this.btntheloai.FlatAppearance.BorderSize = 0;
			this.btntheloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btntheloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntheloai.ForeColor = System.Drawing.Color.Gainsboro;
			this.btntheloai.IconChar = FontAwesome.Sharp.IconChar.Columns;
			this.btntheloai.IconColor = System.Drawing.Color.Gainsboro;
			this.btntheloai.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btntheloai.IconSize = 35;
			this.btntheloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btntheloai.Location = new System.Drawing.Point(0, 400);
			this.btntheloai.Name = "btntheloai";
			this.btntheloai.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btntheloai.Size = new System.Drawing.Size(170, 50);
			this.btntheloai.TabIndex = 8;
			this.btntheloai.Text = "Thể Loại";
			this.btntheloai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btntheloai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btntheloai.UseVisualStyleBackColor = true;
			this.btntheloai.Click += new System.EventHandler(this.btntheloai_Click);
			// 
			// PanelDropDownSP
			// 
			this.PanelDropDownSP.Controls.Add(this.iconButtonSP);
			this.PanelDropDownSP.Location = new System.Drawing.Point(0, 350);
			this.PanelDropDownSP.Name = "PanelDropDownSP";
			this.PanelDropDownSP.Size = new System.Drawing.Size(170, 50);
			this.PanelDropDownSP.TabIndex = 5;
			// 
			// iconButtonSP
			// 
			this.iconButtonSP.Dock = System.Windows.Forms.DockStyle.Top;
			this.iconButtonSP.FlatAppearance.BorderSize = 0;
			this.iconButtonSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconButtonSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.iconButtonSP.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconButtonSP.IconChar = FontAwesome.Sharp.IconChar.Tag;
			this.iconButtonSP.IconColor = System.Drawing.Color.Gainsboro;
			this.iconButtonSP.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconButtonSP.IconSize = 35;
			this.iconButtonSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonSP.Location = new System.Drawing.Point(0, 0);
			this.iconButtonSP.Name = "iconButtonSP";
			this.iconButtonSP.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.iconButtonSP.Size = new System.Drawing.Size(170, 50);
			this.iconButtonSP.TabIndex = 4;
			this.iconButtonSP.Text = "Sản phẩm";
			this.iconButtonSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iconButtonSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconButtonSP.UseVisualStyleBackColor = true;
			this.iconButtonSP.Click += new System.EventHandler(this.iconButtonSP_Click);
			// 
			// btndashboard
			// 
			this.btndashboard.FlatAppearance.BorderSize = 0;
			this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btndashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btndashboard.ForeColor = System.Drawing.Color.Gainsboro;
			this.btndashboard.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
			this.btndashboard.IconColor = System.Drawing.Color.Gainsboro;
			this.btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btndashboard.IconSize = 35;
			this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btndashboard.Location = new System.Drawing.Point(0, 300);
			this.btndashboard.Name = "btndashboard";
			this.btndashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btndashboard.Size = new System.Drawing.Size(170, 50);
			this.btndashboard.TabIndex = 4;
			this.btndashboard.Text = "Báo cáo";
			this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btndashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btndashboard.UseVisualStyleBackColor = true;
			this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
			// 
			// btnlogout
			// 
			this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnlogout.FlatAppearance.BorderSize = 0;
			this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogout.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnlogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
			this.btnlogout.IconColor = System.Drawing.Color.Gainsboro;
			this.btnlogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnlogout.IconSize = 35;
			this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnlogout.Location = new System.Drawing.Point(0, 550);
			this.btnlogout.Name = "btnlogout";
			this.btnlogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnlogout.Size = new System.Drawing.Size(170, 50);
			this.btnlogout.TabIndex = 7;
			this.btnlogout.Text = "Đăng xuất";
			this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnlogout.UseVisualStyleBackColor = true;
			this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
			// 
			// btntonkho
			// 
			this.btntonkho.FlatAppearance.BorderSize = 0;
			this.btntonkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btntonkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btntonkho.ForeColor = System.Drawing.Color.Gainsboro;
			this.btntonkho.IconChar = FontAwesome.Sharp.IconChar.Boxes;
			this.btntonkho.IconColor = System.Drawing.Color.Gainsboro;
			this.btntonkho.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btntonkho.IconSize = 35;
			this.btntonkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btntonkho.Location = new System.Drawing.Point(0, 250);
			this.btntonkho.Name = "btntonkho";
			this.btntonkho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btntonkho.Size = new System.Drawing.Size(170, 50);
			this.btntonkho.TabIndex = 6;
			this.btntonkho.Text = "Combo";
			this.btntonkho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btntonkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btntonkho.UseVisualStyleBackColor = true;
			this.btntonkho.Click += new System.EventHandler(this.btnluong_Click);
			// 
			// btnorders
			// 
			this.btnorders.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnorders.FlatAppearance.BorderSize = 0;
			this.btnorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnorders.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnorders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
			this.btnorders.IconColor = System.Drawing.Color.Gainsboro;
			this.btnorders.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnorders.IconSize = 35;
			this.btnorders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnorders.Location = new System.Drawing.Point(0, 150);
			this.btnorders.Name = "btnorders";
			this.btnorders.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnorders.Size = new System.Drawing.Size(170, 50);
			this.btnorders.TabIndex = 2;
			this.btnorders.Text = "Đơn Hàng";
			this.btnorders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnorders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnorders.UseVisualStyleBackColor = true;
			this.btnorders.Click += new System.EventHandler(this.btnorders_Click);
			// 
			// btnhome
			// 
			this.btnhome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnhome.FlatAppearance.BorderSize = 0;
			this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnhome.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnhome.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.btnhome.IconColor = System.Drawing.Color.Gainsboro;
			this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnhome.IconSize = 35;
			this.btnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnhome.Location = new System.Drawing.Point(0, 100);
			this.btnhome.Name = "btnhome";
			this.btnhome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnhome.Size = new System.Drawing.Size(170, 50);
			this.btnhome.TabIndex = 1;
			this.btnhome.Text = "Bán hàng";
			this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnhome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnhome.UseVisualStyleBackColor = true;
			this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
			// 
			// btnnhapkho
			// 
			this.btnnhapkho.FlatAppearance.BorderSize = 0;
			this.btnnhapkho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnnhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnnhapkho.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnnhapkho.IconChar = FontAwesome.Sharp.IconChar.Truck;
			this.btnnhapkho.IconColor = System.Drawing.Color.Gainsboro;
			this.btnnhapkho.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnnhapkho.IconSize = 35;
			this.btnnhapkho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnnhapkho.Location = new System.Drawing.Point(0, 200);
			this.btnnhapkho.Name = "btnnhapkho";
			this.btnnhapkho.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.btnnhapkho.Size = new System.Drawing.Size(170, 50);
			this.btnnhapkho.TabIndex = 5;
			this.btnnhapkho.Text = "Kho hàng";
			this.btnnhapkho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnnhapkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnnhapkho.UseVisualStyleBackColor = true;
			this.btnnhapkho.Click += new System.EventHandler(this.btnnhanvien_Click);
			// 
			// PanelLogo
			// 
			this.PanelLogo.Controls.Add(this.picLogo);
			this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PanelLogo.Location = new System.Drawing.Point(0, 0);
			this.PanelLogo.Name = "PanelLogo";
			this.PanelLogo.Size = new System.Drawing.Size(170, 100);
			this.PanelLogo.TabIndex = 0;
			// 
			// picLogo
			// 
			this.picLogo.Image = global::DoAn_2.Properties.Resources.logo200;
			this.picLogo.Location = new System.Drawing.Point(30, 6);
			this.picLogo.Name = "picLogo";
			this.picLogo.Size = new System.Drawing.Size(105, 97);
			this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLogo.TabIndex = 0;
			this.picLogo.TabStop = false;
			// 
			// panelTitlebar
			// 
			this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.panelTitlebar.Controls.Add(this.lbDateTime);
			this.panelTitlebar.Controls.Add(this.LabelUser);
			this.panelTitlebar.Controls.Add(this.iconMinimize);
			this.panelTitlebar.Controls.Add(this.iconZoom);
			this.panelTitlebar.Controls.Add(this.iconExit);
			this.panelTitlebar.Controls.Add(this.labelcon);
			this.panelTitlebar.Controls.Add(this.iconmenusmall);
			this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitlebar.Location = new System.Drawing.Point(170, 0);
			this.panelTitlebar.Name = "panelTitlebar";
			this.panelTitlebar.Size = new System.Drawing.Size(930, 70);
			this.panelTitlebar.TabIndex = 1;
			this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
			// 
			// lbDateTime
			// 
			this.lbDateTime.AutoSize = true;
			this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDateTime.ForeColor = System.Drawing.Color.Gainsboro;
			this.lbDateTime.Location = new System.Drawing.Point(366, 31);
			this.lbDateTime.Name = "lbDateTime";
			this.lbDateTime.Size = new System.Drawing.Size(71, 20);
			this.lbDateTime.TabIndex = 6;
			this.lbDateTime.Text = "12:30:33";
			// 
			// LabelUser
			// 
			this.LabelUser.AutoSize = true;
			this.LabelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LabelUser.ForeColor = System.Drawing.Color.Gainsboro;
			this.LabelUser.Location = new System.Drawing.Point(184, 31);
			this.LabelUser.Name = "LabelUser";
			this.LabelUser.Size = new System.Drawing.Size(71, 16);
			this.LabelUser.TabIndex = 5;
			this.LabelUser.Text = "Username";
			// 
			// iconMinimize
			// 
			this.iconMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
			this.iconMinimize.IconColor = System.Drawing.Color.Gainsboro;
			this.iconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconMinimize.IconSize = 25;
			this.iconMinimize.Location = new System.Drawing.Point(832, 2);
			this.iconMinimize.Name = "iconMinimize";
			this.iconMinimize.Size = new System.Drawing.Size(30, 30);
			this.iconMinimize.TabIndex = 4;
			this.iconMinimize.UseVisualStyleBackColor = true;
			this.iconMinimize.Click += new System.EventHandler(this.iconMinimize_Click);
			// 
			// iconZoom
			// 
			this.iconZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconZoom.IconChar = FontAwesome.Sharp.IconChar.Clone;
			this.iconZoom.IconColor = System.Drawing.Color.Gainsboro;
			this.iconZoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconZoom.IconSize = 25;
			this.iconZoom.Location = new System.Drawing.Point(867, 7);
			this.iconZoom.Name = "iconZoom";
			this.iconZoom.Size = new System.Drawing.Size(30, 30);
			this.iconZoom.TabIndex = 3;
			this.iconZoom.UseVisualStyleBackColor = true;
			this.iconZoom.Click += new System.EventHandler(this.iconZoom_Click);
			// 
			// iconExit
			// 
			this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iconExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.iconExit.IconColor = System.Drawing.Color.Gainsboro;
			this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconExit.IconSize = 25;
			this.iconExit.Location = new System.Drawing.Point(895, 7);
			this.iconExit.Name = "iconExit";
			this.iconExit.Size = new System.Drawing.Size(30, 30);
			this.iconExit.TabIndex = 2;
			this.iconExit.UseVisualStyleBackColor = true;
			this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
			// 
			// labelcon
			// 
			this.labelcon.AutoSize = true;
			this.labelcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelcon.ForeColor = System.Drawing.Color.Gainsboro;
			this.labelcon.Location = new System.Drawing.Point(64, 31);
			this.labelcon.Name = "labelcon";
			this.labelcon.Size = new System.Drawing.Size(45, 16);
			this.labelcon.TabIndex = 1;
			this.labelcon.Text = "Home";
			// 
			// iconmenusmall
			// 
			this.iconmenusmall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.iconmenusmall.ForeColor = System.Drawing.Color.Gainsboro;
			this.iconmenusmall.IconChar = FontAwesome.Sharp.IconChar.Home;
			this.iconmenusmall.IconColor = System.Drawing.Color.Gainsboro;
			this.iconmenusmall.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconmenusmall.Location = new System.Drawing.Point(19, 23);
			this.iconmenusmall.Name = "iconmenusmall";
			this.iconmenusmall.Size = new System.Drawing.Size(32, 32);
			this.iconmenusmall.TabIndex = 0;
			this.iconmenusmall.TabStop = false;
			// 
			// panelshadow
			// 
			this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
			this.panelshadow.Location = new System.Drawing.Point(173, 64);
			this.panelshadow.Name = "panelshadow";
			this.panelshadow.Size = new System.Drawing.Size(628, 9);
			this.panelshadow.TabIndex = 2;
			// 
			// paneltrangcon
			// 
			this.paneltrangcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
			this.paneltrangcon.Location = new System.Drawing.Point(170, 67);
			this.paneltrangcon.Name = "paneltrangcon";
			this.paneltrangcon.Size = new System.Drawing.Size(930, 533);
			this.paneltrangcon.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 600);
			this.Controls.Add(this.panelTitlebar);
			this.Controls.Add(this.paneltrangcon);
			this.Controls.Add(this.panelshadow);
			this.Controls.Add(this.PanelMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainControl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainControl";
			this.Load += new System.EventHandler(this.MainControl_Load);
			this.PanelMenu.ResumeLayout(false);
			this.PanelDropDownSP.ResumeLayout(false);
			this.PanelLogo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
			this.panelTitlebar.ResumeLayout(false);
			this.panelTitlebar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconmenusmall)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton btnhome;
        private FontAwesome.Sharp.IconButton btnnhapkho;
        private FontAwesome.Sharp.IconButton btndashboard;
        private FontAwesome.Sharp.IconButton btnorders;
        private FontAwesome.Sharp.IconButton btntonkho;
        private FontAwesome.Sharp.IconButton btnlogout;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconPictureBox iconmenusmall;
        private System.Windows.Forms.Label labelcon;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel paneltrangcon;
        private FontAwesome.Sharp.IconButton iconExit;
        private FontAwesome.Sharp.IconButton iconZoom;
        private FontAwesome.Sharp.IconButton iconMinimize;
        private System.Windows.Forms.Label LabelUser;
        private System.Windows.Forms.Panel PanelDropDownSP;
        private FontAwesome.Sharp.IconButton iconButtonSP;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btntheloai;
    }
}