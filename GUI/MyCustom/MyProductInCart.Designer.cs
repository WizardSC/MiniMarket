namespace GUI.MyCustom
{
    partial class MyProductInCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProductInCart));
            this.pnProductInCart = new System.Windows.Forms.Panel();
            this.btnDelete = new GUI.MyCustom.RJButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSeperator = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnGiam = new GUI.MyCustom.RJButton();
            this.btnTang = new GUI.MyCustom.RJButton();
            this.txtSoLuong = new GUI.MyCustom.RJTextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.pnProductInCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnProductInCart
            // 
            this.pnProductInCart.BackColor = System.Drawing.Color.White;
            this.pnProductInCart.Controls.Add(this.lblMaSP);
            this.pnProductInCart.Controls.Add(this.btnDelete);
            this.pnProductInCart.Controls.Add(this.lblDonGia);
            this.pnProductInCart.Controls.Add(this.lblSeperator);
            this.pnProductInCart.Controls.Add(this.lblTongTien);
            this.pnProductInCart.Controls.Add(this.btnGiam);
            this.pnProductInCart.Controls.Add(this.btnTang);
            this.pnProductInCart.Controls.Add(this.txtSoLuong);
            this.pnProductInCart.Controls.Add(this.lblTenSP);
            this.pnProductInCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProductInCart.Location = new System.Drawing.Point(0, 0);
            this.pnProductInCart.Name = "pnProductInCart";
            this.pnProductInCart.Size = new System.Drawing.Size(452, 85);
            this.pnProductInCart.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(417, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(31, 28);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(216, 43);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(76, 23);
            this.lblDonGia.TabIndex = 7;
            this.lblDonGia.Text = "10000đ";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeperator
            // 
            this.lblSeperator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeperator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSeperator.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator.Location = new System.Drawing.Point(0, 83);
            this.lblSeperator.Name = "lblSeperator";
            this.lblSeperator.Size = new System.Drawing.Size(452, 2);
            this.lblSeperator.TabIndex = 8;
            this.lblSeperator.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTongTien
            // 
            this.lblTongTien.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(335, 43);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(76, 23);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "0đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGiam
            // 
            this.btnGiam.BackColor = System.Drawing.Color.White;
            this.btnGiam.BackgroundColor = System.Drawing.Color.White;
            this.btnGiam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGiam.BorderRadius = 0;
            this.btnGiam.BorderSize = 0;
            this.btnGiam.FlatAppearance.BorderSize = 0;
            this.btnGiam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiam.ForeColor = System.Drawing.Color.White;
            this.btnGiam.Image = ((System.Drawing.Image)(resources.GetObject("btnGiam.Image")));
            this.btnGiam.Location = new System.Drawing.Point(15, 38);
            this.btnGiam.Name = "btnGiam";
            this.btnGiam.Size = new System.Drawing.Size(31, 28);
            this.btnGiam.TabIndex = 5;
            this.btnGiam.TextColor = System.Drawing.Color.White;
            this.btnGiam.UseVisualStyleBackColor = false;
            this.btnGiam.Click += new System.EventHandler(this.btnGiam_Click);
            // 
            // btnTang
            // 
            this.btnTang.BackColor = System.Drawing.Color.White;
            this.btnTang.BackgroundColor = System.Drawing.Color.White;
            this.btnTang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTang.BorderRadius = 0;
            this.btnTang.BorderSize = 0;
            this.btnTang.FlatAppearance.BorderSize = 0;
            this.btnTang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTang.ForeColor = System.Drawing.Color.White;
            this.btnTang.Image = ((System.Drawing.Image)(resources.GetObject("btnTang.Image")));
            this.btnTang.Location = new System.Drawing.Point(99, 38);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(31, 28);
            this.btnTang.TabIndex = 4;
            this.btnTang.TextColor = System.Drawing.Color.White;
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtSoLuong.BorderRadius = 0;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuong.Location = new System.Drawing.Point(53, 38);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 20, 4, 10);
            this.txtSoLuong.MaximumSize = new System.Drawing.Size(500, 28);
            this.txtSoLuong.MinimumSize = new System.Drawing.Size(10, 28);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(15, 4, 2, 2);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(39, 28);
            this.txtSoLuong.TabIndex = 3;
            this.txtSoLuong.Texts = "1";
            this.txtSoLuong.UnderlinedStyle = false;
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(70, 11);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(341, 23);
            this.lblTenSP.TabIndex = 0;
            this.lblTenSP.Text = "Xịt côn trùng Raid Lavender 600ml";
            // 
            // lblMaSP
            // 
            this.lblMaSP.Font = new System.Drawing.Font("Cambria", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(3, 11);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(56, 23);
            this.lblMaSP.TabIndex = 10;
            this.lblMaSP.Text = "SP001";
            // 
            // MyProductInCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnProductInCart);
            this.Name = "MyProductInCart";
            this.Size = new System.Drawing.Size(452, 85);
            this.pnProductInCart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnProductInCart;
        public System.Windows.Forms.Label lblTenSP;
        public RJTextBox txtSoLuong;
        public System.Windows.Forms.Label lblDonGia;
        public System.Windows.Forms.Label lblTongTien;
        public RJButton btnGiam;
        public RJButton btnTang;
        public System.Windows.Forms.Label lblSeperator;
        public RJButton btnDelete;
        public System.Windows.Forms.Label lblMaSP;
    }
}
