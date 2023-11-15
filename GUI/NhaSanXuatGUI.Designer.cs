namespace GUI
{
    partial class NhaSanXuatGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaSanXuatGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvNSX = new System.Windows.Forms.DataGridView();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkTrangThai = new GUI.MyCustom.BiggerCheckBox();
            this.chkHoatDong = new GUI.MyCustom.BiggerCheckBox();
            this.chkKoHD = new GUI.MyCustom.BiggerCheckBox();
            this.txtMaNSX = new GUI.MyCustom.RJTextBox();
            this.txtTenNSX = new GUI.MyCustom.RJTextBox();
            this.txtDiaChi = new GUI.MyCustom.RJTextBox();
            this.txtSoDT = new GUI.MyCustom.RJTextBox();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.flpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.flpFilter);
            this.panel1.Controls.Add(this.dgvNSX);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 874);
            this.panel1.TabIndex = 0;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.flpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFilter.Controls.Add(this.chkTrangThai);
            this.flpFilter.Controls.Add(this.label27);
            this.flpFilter.Controls.Add(this.chkHoatDong);
            this.flpFilter.Controls.Add(this.label28);
            this.flpFilter.Controls.Add(this.chkKoHD);
            this.flpFilter.Controls.Add(this.label29);
            this.flpFilter.Location = new System.Drawing.Point(1160, 92);
            this.flpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(385, 93);
            this.flpFilter.TabIndex = 4;
            this.flpFilter.Visible = false;
            this.flpFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.flpFilter_Paint);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label27.Location = new System.Drawing.Point(44, 5);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 34);
            this.label27.TabIndex = 18;
            this.label27.Text = "T.Thái:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(194, 5);
            this.label28.Margin = new System.Windows.Forms.Padding(5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 34);
            this.label28.TabIndex = 22;
            this.label28.Text = "Hoạt động";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label29.Location = new System.Drawing.Point(170, 49);
            this.label29.Margin = new System.Windows.Forms.Padding(5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(196, 34);
            this.label29.TabIndex = 23;
            this.label29.Text = "Không hoạt động";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvNSX
            // 
            this.dgvNSX.AllowUserToAddRows = false;
            this.dgvNSX.AllowUserToDeleteRows = false;
            this.dgvNSX.AllowUserToResizeColumns = false;
            this.dgvNSX.AllowUserToResizeRows = false;
            this.dgvNSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNSX.BackgroundColor = System.Drawing.Color.White;
            this.dgvNSX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNSX.ColumnHeadersHeight = 28;
            this.dgvNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNSX,
            this.TenNSX,
            this.DiaChi,
            this.SoDT,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNSX.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNSX.EnableHeadersVisualStyles = false;
            this.dgvNSX.GridColor = System.Drawing.Color.Black;
            this.dgvNSX.Location = new System.Drawing.Point(419, 53);
            this.dgvNSX.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNSX.Name = "dgvNSX";
            this.dgvNSX.ReadOnly = true;
            this.dgvNSX.RowHeadersVisible = false;
            this.dgvNSX.RowHeadersWidth = 51;
            this.dgvNSX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNSX.RowTemplate.Height = 30;
            this.dgvNSX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNSX.Size = new System.Drawing.Size(1127, 898);
            this.dgvNSX.TabIndex = 1;
            this.dgvNSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNSX_CellClick);
            this.dgvNSX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNSX_CellContentClick);
            this.dgvNSX.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNSX_CellFormatting);
            this.dgvNSX.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvNSX_DataBindingComplete);
            // 
            // MaNSX
            // 
            this.MaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.Frozen = true;
            this.MaNSX.HeaderText = "Mã NSX";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.ReadOnly = true;
            // 
            // TenNSX
            // 
            this.TenNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Tên NSX";
            this.TenNSX.MinimumWidth = 6;
            this.TenNSX.Name = "TenNSX";
            this.TenNSX.ReadOnly = true;
            this.TenNSX.Width = 104;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ NSX";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            // 
            // SoDT
            // 
            this.SoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số điện thoại NSX";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 120;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 124;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(415, 905);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÀ SẢN XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaNSX);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtTenNSX);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtDiaChi);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtSoDT);
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.cbxTrangThai);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 47);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(391, 363);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NSX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(4, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label13.Size = new System.Drawing.Size(341, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "* Bạn phải nhập Mã NSX";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NSX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label14.Location = new System.Drawing.Point(4, 109);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label14.Size = new System.Drawing.Size(341, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "* Bạn phải nhập Tên NSX";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(5, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ NSX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label15.Location = new System.Drawing.Point(4, 174);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label15.Size = new System.Drawing.Size(365, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "* Bạn phải nhập địa chỉ NSX";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(5, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số ĐT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label18.Location = new System.Drawing.Point(4, 239);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label18.Size = new System.Drawing.Size(364, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "* Bạn phải nhập số ĐT";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(5, 269);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 34);
            this.label5.TabIndex = 26;
            this.label5.Text = "Trạng Thái";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(4, 308);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label6.Size = new System.Drawing.Size(365, 30);
            this.label6.TabIndex = 28;
            this.label6.Text = "* Bạn phải nhập trạng thái";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 420);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(387, 55);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(419, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1127, 70);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // chkTrangThai
            // 
            this.chkTrangThai.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTrangThai.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkTrangThai.BoxColor = System.Drawing.Color.Black;
            this.chkTrangThai.BoxLocationX = 5;
            this.chkTrangThai.BoxLocationY = 8;
            this.chkTrangThai.BoxSize = 14;
            this.chkTrangThai.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTrangThai.FlatAppearance.BorderSize = 0;
            this.chkTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTrangThai.Location = new System.Drawing.Point(4, 4);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkTrangThai.Size = new System.Drawing.Size(32, 36);
            this.chkTrangThai.TabIndex = 19;
            this.chkTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTrangThai.TextLocationX = 16;
            this.chkTrangThai.TextLocationY = 1;
            this.chkTrangThai.TickColor = System.Drawing.Color.Black;
            this.chkTrangThai.TickLeftPosition = 5F;
            this.chkTrangThai.TickSize = 11F;
            this.chkTrangThai.TickTopPosition = 8F;
            this.chkTrangThai.UseVisualStyleBackColor = true;
            this.chkTrangThai.CheckedChanged += new System.EventHandler(this.chkTrangThai_CheckedChanged);
            // 
            // chkHoatDong
            // 
            this.chkHoatDong.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHoatDong.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkHoatDong.BoxColor = System.Drawing.Color.Black;
            this.chkHoatDong.BoxLocationX = 5;
            this.chkHoatDong.BoxLocationY = 8;
            this.chkHoatDong.BoxSize = 14;
            this.chkHoatDong.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHoatDong.Enabled = false;
            this.chkHoatDong.FlatAppearance.BorderSize = 0;
            this.chkHoatDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHoatDong.Location = new System.Drawing.Point(157, 4);
            this.chkHoatDong.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkHoatDong.Size = new System.Drawing.Size(32, 36);
            this.chkHoatDong.TabIndex = 20;
            this.chkHoatDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkHoatDong.TextLocationX = 16;
            this.chkHoatDong.TextLocationY = 1;
            this.chkHoatDong.TickColor = System.Drawing.Color.Black;
            this.chkHoatDong.TickLeftPosition = 5F;
            this.chkHoatDong.TickSize = 11F;
            this.chkHoatDong.TickTopPosition = 8F;
            this.chkHoatDong.UseVisualStyleBackColor = true;
            this.chkHoatDong.CheckedChanged += new System.EventHandler(this.chkHoatDong_CheckedChanged);
            // 
            // chkKoHD
            // 
            this.chkKoHD.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkKoHD.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkKoHD.BoxColor = System.Drawing.Color.Black;
            this.chkKoHD.BoxLocationX = 5;
            this.chkKoHD.BoxLocationY = 8;
            this.chkKoHD.BoxSize = 14;
            this.chkKoHD.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKoHD.Enabled = false;
            this.chkKoHD.FlatAppearance.BorderSize = 0;
            this.chkKoHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkKoHD.Location = new System.Drawing.Point(133, 48);
            this.chkKoHD.Margin = new System.Windows.Forms.Padding(133, 4, 0, 4);
            this.chkKoHD.Name = "chkKoHD";
            this.chkKoHD.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkKoHD.Size = new System.Drawing.Size(32, 36);
            this.chkKoHD.TabIndex = 21;
            this.chkKoHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkKoHD.TextLocationX = 16;
            this.chkKoHD.TextLocationY = 1;
            this.chkKoHD.TickColor = System.Drawing.Color.Black;
            this.chkKoHD.TickLeftPosition = 5F;
            this.chkKoHD.TickSize = 11F;
            this.chkKoHD.TickTopPosition = 8F;
            this.chkKoHD.UseVisualStyleBackColor = true;
            this.chkKoHD.CheckedChanged += new System.EventHandler(this.chkKoHD_CheckedChanged);
            // 
            // txtMaNSX
            // 
            this.txtMaNSX.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNSX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaNSX.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaNSX.BorderRadius = 0;
            this.txtMaNSX.BorderSize = 2;
            this.txtMaNSX.Enabled = false;
            this.txtMaNSX.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNSX.ForeColor = System.Drawing.Color.Black;
            this.txtMaNSX.Location = new System.Drawing.Point(140, 5);
            this.txtMaNSX.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNSX.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtMaNSX.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtMaNSX.Multiline = false;
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Padding = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.txtMaNSX.PasswordChar = false;
            this.txtMaNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNSX.PlaceholderText = "";
            this.txtMaNSX.ReadOnly = false;
            this.txtMaNSX.Size = new System.Drawing.Size(228, 34);
            this.txtMaNSX.TabIndex = 1;
            this.txtMaNSX.Texts = "";
            this.txtMaNSX.UnderlinedStyle = false;
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
            this.txtTenNSX.Location = new System.Drawing.Point(140, 70);
            this.txtTenNSX.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenNSX.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtTenNSX.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtTenNSX.Multiline = false;
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Padding = new System.Windows.Forms.Padding(9);
            this.txtTenNSX.PasswordChar = false;
            this.txtTenNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNSX.PlaceholderText = "";
            this.txtTenNSX.ReadOnly = false;
            this.txtTenNSX.Size = new System.Drawing.Size(228, 34);
            this.txtTenNSX.TabIndex = 3;
            this.txtTenNSX.Texts = "";
            this.txtTenNSX.UnderlinedStyle = false;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtDiaChi.BorderRadius = 0;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChi.Location = new System.Drawing.Point(140, 135);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtDiaChi.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(9);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.ReadOnly = false;
            this.txtDiaChi.Size = new System.Drawing.Size(228, 34);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtSoDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtSoDT.BorderRadius = 0;
            this.txtSoDT.BorderSize = 2;
            this.txtSoDT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.Black;
            this.txtSoDT.Location = new System.Drawing.Point(140, 200);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoDT.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtSoDT.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtSoDT.Multiline = false;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Padding = new System.Windows.Forms.Padding(9);
            this.txtSoDT.PasswordChar = false;
            this.txtSoDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.ReadOnly = false;
            this.txtSoDT.Size = new System.Drawing.Size(228, 34);
            this.txtSoDT.TabIndex = 11;
            this.txtSoDT.Texts = "";
            this.txtSoDT.UnderlinedStyle = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 2;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(31, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(31, 4, 13, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderSize = 2;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(116, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderSize = 2;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(201, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 49);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnReset.BorderRadius = 20;
            this.btnReset.BorderSize = 2;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(286, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 49);
            this.btnReset.TabIndex = 3;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.AutoCompleteCustomSource.AddRange(new string[] {
            "Tên NSX",
            "Địa Chỉ NSX",
            "Số ĐT"});
            this.cbxTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTimKiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxTimKiem.BorderSize = 2;
            this.cbxTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTimKiem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxTimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxTimKiem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTimKiem.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxTimKiem.Location = new System.Drawing.Point(5, 10);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(133, 37);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTimKiem.Size = new System.Drawing.Size(148, 37);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "Mã NSX";
            this.cbxTimKiem.OnSelectedIndexChanged += new System.EventHandler(this.cbxTimKiem_OnSelectedIndexChanged);
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
            this.txtTimKiem.Location = new System.Drawing.Point(163, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(9);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(807, 41);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = true;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
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
            this.btnTimKiem.Location = new System.Drawing.Point(979, 10);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(39, 39);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
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
            this.btnFilter.Location = new System.Drawing.Point(1042, 10);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(20, 10, 13, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(59, 46);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbxTrangThai.Location = new System.Drawing.Point(139, 268);
            this.cbxTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTrangThai.MinimumSize = new System.Drawing.Size(132, 0);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(230, 31);
            this.cbxTrangThai.TabIndex = 29;
            this.cbxTrangThai.Text = "Hoạt động";
            // 
            // NhaSanXuatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NhaSanXuatGUI";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "x";
            this.Load += new System.EventHandler(this.NhaSanXuatGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaNSX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJTextBox txtTenNSX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtDiaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJTextBox txtSoDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.RJButton btnThem;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.DataGridView dgvNSX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkTrangThai;
        private System.Windows.Forms.Label label27;
        private MyCustom.BiggerCheckBox chkHoatDong;
        private System.Windows.Forms.Label label28;
        private MyCustom.BiggerCheckBox chkKoHD;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.ComboBox cbxTrangThai;
    }
}