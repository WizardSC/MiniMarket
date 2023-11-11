namespace GUI
{
    partial class MiniNSXGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniNSXGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new GUI.MyCustom.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXacNhan = new GUI.MyCustom.RJButton();
            this.btnHuyBo = new GUI.MyCustom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNSX = new GUI.MyCustom.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNSX = new GUI.MyCustom.RJTextBox();
            this.dgvNhaSanXuat = new System.Windows.Forms.DataGridView();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new GUI.MyCustom.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new GUI.MyCustom.RJButton();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).BeginInit();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.gradientPanel1);
            this.panel3.Controls.Add(this.pnHeader);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 554);
            this.panel3.TabIndex = 5;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.dgvNhaSanXuat);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 43);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(885, 509);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.White;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnXacNhan);
            this.panel2.Controls.Add(this.btnHuyBo);
            this.panel2.Location = new System.Drawing.Point(677, 322);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 170);
            this.panel2.TabIndex = 4;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnXacNhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnXacNhan.BorderRadius = 20;
            this.btnXacNhan.BorderSize = 2;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.Image")));
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.Location = new System.Drawing.Point(13, 21);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(31, 4, 13, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(160, 49);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "        Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.TextColor = System.Drawing.Color.Black;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyBo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHuyBo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnHuyBo.BorderRadius = 20;
            this.btnHuyBo.BorderSize = 2;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.ForeColor = System.Drawing.Color.Black;
            this.btnHuyBo.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyBo.Image")));
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(13, 89);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(31, 4, 13, 4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(160, 49);
            this.btnHuyBo.TabIndex = 1;
            this.btnHuyBo.Text = "       Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.TextColor = System.Drawing.Color.Black;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenNSX);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaNSX);
            this.panel1.Location = new System.Drawing.Point(16, 322);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 170);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên NSX";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNSX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenNSX.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenNSX.BorderRadius = 0;
            this.txtTenNSX.BorderSize = 2;
            this.txtTenNSX.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNSX.ForeColor = System.Drawing.Color.Black;
            this.txtTenNSX.Location = new System.Drawing.Point(152, 89);
            this.txtTenNSX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTenNSX.MaximumSize = new System.Drawing.Size(400, 34);
            this.txtTenNSX.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtTenNSX.Multiline = false;
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Padding = new System.Windows.Forms.Padding(5, 5, 3, 2);
            this.txtTenNSX.PasswordChar = false;
            this.txtTenNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNSX.PlaceholderText = "";
            this.txtTenNSX.ReadOnly = false;
            this.txtTenNSX.Size = new System.Drawing.Size(400, 34);
            this.txtTenNSX.TabIndex = 5;
            this.txtTenNSX.Texts = "";
            this.txtTenNSX.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NSX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNSX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaNSX.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaNSX.BorderRadius = 0;
            this.txtMaNSX.BorderSize = 2;
            this.txtMaNSX.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNSX.ForeColor = System.Drawing.Color.Black;
            this.txtMaNSX.Location = new System.Drawing.Point(152, 21);
            this.txtMaNSX.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMaNSX.MaximumSize = new System.Drawing.Size(400, 34);
            this.txtMaNSX.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtMaNSX.Multiline = false;
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Padding = new System.Windows.Forms.Padding(5, 5, 3, 2);
            this.txtMaNSX.PasswordChar = false;
            this.txtMaNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNSX.PlaceholderText = "";
            this.txtMaNSX.ReadOnly = false;
            this.txtMaNSX.Size = new System.Drawing.Size(400, 34);
            this.txtMaNSX.TabIndex = 3;
            this.txtMaNSX.Texts = "";
            this.txtMaNSX.UnderlinedStyle = false;
            // 
            // dgvNhaSanXuat
            // 
            this.dgvNhaSanXuat.AllowUserToAddRows = false;
            this.dgvNhaSanXuat.AllowUserToDeleteRows = false;
            this.dgvNhaSanXuat.AllowUserToResizeColumns = false;
            this.dgvNhaSanXuat.AllowUserToResizeRows = false;
            this.dgvNhaSanXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhaSanXuat.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhaSanXuat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaSanXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaSanXuat.ColumnHeadersHeight = 28;
            this.dgvNhaSanXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNSX,
            this.MaNCC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhaSanXuat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhaSanXuat.EnableHeadersVisualStyles = false;
            this.dgvNhaSanXuat.GridColor = System.Drawing.Color.Black;
            this.dgvNhaSanXuat.Location = new System.Drawing.Point(16, 15);
            this.dgvNhaSanXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNhaSanXuat.Name = "dgvNhaSanXuat";
            this.dgvNhaSanXuat.ReadOnly = true;
            this.dgvNhaSanXuat.RowHeadersVisible = false;
            this.dgvNhaSanXuat.RowHeadersWidth = 51;
            this.dgvNhaSanXuat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNhaSanXuat.RowTemplate.Height = 30;
            this.dgvNhaSanXuat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNhaSanXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaSanXuat.Size = new System.Drawing.Size(856, 299);
            this.dgvNhaSanXuat.TabIndex = 2;
            this.dgvNhaSanXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaSanXuat_CellClick);
            this.dgvNhaSanXuat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNhaSanXuat_DataBindingComplete);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.pnHeader.Controls.Add(this.label3);
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.panel4);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(885, 43);
            this.pnHeader.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "          CHỌN NHÀ SẢN XUẤT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::GUI.Properties.Resources.icons8_minimize_32__1_;
            this.btnMinimize.Location = new System.Drawing.Point(763, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(57, 43);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(820, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 43);
            this.panel4.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::GUI.Properties.Resources.icons8_close_32;
            this.btnClose.Location = new System.Drawing.Point(828, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaNSX
            // 
            this.MaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã NSX";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.ReadOnly = true;
            this.MaNSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNCC.DataPropertyName = "TenNSX";
            this.MaNCC.HeaderText = "Tên NSX";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // MiniNSXGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 554);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MiniNSXGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniNSXGUI";
            this.Load += new System.EventHandler(this.MiniNSXGUI_Load);
            this.panel3.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaSanXuat)).EndInit();
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MyCustom.GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel2;
        private MyCustom.RJButton btnXacNhan;
        private MyCustom.RJButton btnHuyBo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MyCustom.RJTextBox txtTenNSX;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaNSX;
        private System.Windows.Forms.DataGridView dgvNhaSanXuat;
        private System.Windows.Forms.Panel pnHeader;
        private MyCustom.RJButton btnMinimize;
        private System.Windows.Forms.Panel panel4;
        private MyCustom.RJButton btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
    }
}