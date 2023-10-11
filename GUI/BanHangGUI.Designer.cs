namespace GUI
{
    partial class BanHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHangGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpDanhSachSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new GUI.MyCustom.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNext = new GUI.MyCustom.RJButton();
            this.lblPagination = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 763);
            this.panel1.TabIndex = 0;
            // 
            // flpDanhSachSanPham
            // 
            this.flpDanhSachSanPham.BackColor = System.Drawing.Color.Gainsboro;
            this.flpDanhSachSanPham.Location = new System.Drawing.Point(3, 61);
            this.flpDanhSachSanPham.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flpDanhSachSanPham.Name = "flpDanhSachSanPham";
            this.flpDanhSachSanPham.Size = new System.Drawing.Size(788, 342);
            this.flpDanhSachSanPham.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(788, 50);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxTimKiem.BorderSize = 2;
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTimKiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxTimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxTimKiem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTimKiem.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxTimKiem.Location = new System.Drawing.Point(4, 8);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.cbxTimKiem.Size = new System.Drawing.Size(108, 30);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "Mã KH";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTimKiem.BorderRadius = 0;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.Location = new System.Drawing.Point(120, 8);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(551, 32);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.BorderSize = 0;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = global::GUI.Properties.Resources.icons8_search_32;
            this.btnTimKiem.Location = new System.Drawing.Point(678, 8);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(29, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnFilter.BorderRadius = 0;
            this.btnFilter.BorderSize = 2;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Image = global::GUI.Properties.Resources.icons8_filter_32;
            this.btnFilter.Location = new System.Drawing.Point(725, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(44, 36);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flpDanhSachSanPham);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 763);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.White;
            this.btnPrevious.BackgroundColor = System.Drawing.Color.White;
            this.btnPrevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrevious.BorderRadius = 0;
            this.btnPrevious.BorderSize = 0;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Location = new System.Drawing.Point(319, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(35, 35);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.TextColor = System.Drawing.Color.White;
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPagination);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPrevious);
            this.panel2.Location = new System.Drawing.Point(3, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(788, 39);
            this.panel2.TabIndex = 5;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.BackgroundColor = System.Drawing.Color.White;
            this.btnNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNext.BorderRadius = 0;
            this.btnNext.BorderSize = 0;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(435, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(35, 35);
            this.btnNext.TabIndex = 5;
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblPagination
            // 
            this.lblPagination.AutoSize = true;
            this.lblPagination.Location = new System.Drawing.Point(374, 12);
            this.lblPagination.Name = "lblPagination";
            this.lblPagination.Size = new System.Drawing.Size(35, 13);
            this.lblPagination.TabIndex = 6;
            this.lblPagination.Text = "label1";
            // 
            // BanHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanHangGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachSanPham;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private MyCustom.RJButton btnPrevious;
        private System.Windows.Forms.Label lblPagination;
        private MyCustom.RJButton btnNext;
    }
}