namespace GUI
{
    partial class LoaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.chkTrangThai = new GUI.MyCustom.BiggerCheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.chkHoatDong = new GUI.MyCustom.BiggerCheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.chkKoHD = new GUI.MyCustom.BiggerCheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvLoai = new System.Windows.Forms.DataGridView();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoai = new GUI.MyCustom.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenLoai = new GUI.MyCustom.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxTrangThai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnImport = new GUI.MyCustom.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExport = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.panel1.SuspendLayout();
            this.flpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flpFilter);
            this.panel1.Controls.Add(this.dgvLoai);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 738);
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
            this.flpFilter.Location = new System.Drawing.Point(878, 51);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(289, 76);
            this.flpFilter.TabIndex = 5;
            this.flpFilter.Visible = false;
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
            this.chkTrangThai.Location = new System.Drawing.Point(3, 3);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Padding = new System.Windows.Forms.Padding(10);
            this.chkTrangThai.Size = new System.Drawing.Size(24, 29);
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
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label27.Location = new System.Drawing.Point(33, 4);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 28);
            this.label27.TabIndex = 18;
            this.label27.Text = "T.Thái:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.chkHoatDong.Location = new System.Drawing.Point(118, 3);
            this.chkHoatDong.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Padding = new System.Windows.Forms.Padding(10);
            this.chkHoatDong.Size = new System.Drawing.Size(24, 29);
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
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(146, 4);
            this.label28.Margin = new System.Windows.Forms.Padding(4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(119, 28);
            this.label28.TabIndex = 22;
            this.label28.Text = "Hoạt động";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.chkKoHD.Location = new System.Drawing.Point(100, 39);
            this.chkKoHD.Margin = new System.Windows.Forms.Padding(100, 3, 0, 3);
            this.chkKoHD.Name = "chkKoHD";
            this.chkKoHD.Padding = new System.Windows.Forms.Padding(10);
            this.chkKoHD.Size = new System.Drawing.Size(24, 29);
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
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label29.Location = new System.Drawing.Point(128, 40);
            this.label29.Margin = new System.Windows.Forms.Padding(4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 28);
            this.label29.TabIndex = 23;
            this.label29.Text = "Không hoạt động";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvLoai
            // 
            this.dgvLoai.AllowUserToAddRows = false;
            this.dgvLoai.AllowUserToDeleteRows = false;
            this.dgvLoai.AllowUserToResizeColumns = false;
            this.dgvLoai.AllowUserToResizeRows = false;
            this.dgvLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoai.ColumnHeadersHeight = 28;
            this.dgvLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoai,
            this.TenLoai,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoai.EnableHeadersVisualStyles = false;
            this.dgvLoai.GridColor = System.Drawing.Color.Black;
            this.dgvLoai.Location = new System.Drawing.Point(332, 59);
            this.dgvLoai.Name = "dgvLoai";
            this.dgvLoai.ReadOnly = true;
            this.dgvLoai.RowHeadersVisible = false;
            this.dgvLoai.RowHeadersWidth = 51;
            this.dgvLoai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLoai.RowTemplate.Height = 30;
            this.dgvLoai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoai.Size = new System.Drawing.Size(836, 670);
            this.dgvLoai.TabIndex = 1;
            this.dgvLoai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellClick);
            this.dgvLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoai_CellContentClick);
            this.dgvLoai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLoai_CellFormatting);
            this.dgvLoai.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLoai_DataBindingComplete);
            // 
            // MaLoai
            // 
            this.MaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.Frozen = true;
            this.MaLoai.HeaderText = "Mã LOẠI";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 86;
            // 
            // TenLoai
            // 
            this.TenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "TÊN LOẠI";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 99;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(332, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(835, 50);
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
            this.cbxTimKiem.Size = new System.Drawing.Size(134, 30);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "MÃ LOẠI";
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
            this.txtTimKiem.Location = new System.Drawing.Point(146, 8);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(551, 32);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = true;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress_1);
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
            this.btnTimKiem.Location = new System.Drawing.Point(704, 8);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(29, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnFilter.Location = new System.Drawing.Point(751, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(44, 36);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(319, 726);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaLoai);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtTenLoai);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.cbxTrangThai);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.label20);
            this.flowLayoutPanel2.Controls.Add(this.btnImport);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.btnExport);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 43);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(301, 396);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Loại";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaLoai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaLoai.BorderRadius = 0;
            this.txtMaLoai.BorderSize = 2;
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.ForeColor = System.Drawing.Color.Black;
            this.txtMaLoai.Location = new System.Drawing.Point(106, 4);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaLoai.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtMaLoai.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaLoai.Multiline = false;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtMaLoai.PasswordChar = false;
            this.txtMaLoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaLoai.PlaceholderText = "";
            this.txtMaLoai.ReadOnly = false;
            this.txtMaLoai.Size = new System.Drawing.Size(171, 28);
            this.txtMaLoai.TabIndex = 1;
            this.txtMaLoai.Texts = "";
            this.txtMaLoai.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label13.Size = new System.Drawing.Size(262, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "* Bạn phải nhập Mã LOẠI";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(4, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên Loại";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenLoai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenLoai.BorderRadius = 0;
            this.txtTenLoai.BorderSize = 2;
            this.txtTenLoai.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.ForeColor = System.Drawing.Color.Black;
            this.txtTenLoai.Location = new System.Drawing.Point(106, 57);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoai.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtTenLoai.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTenLoai.Multiline = false;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenLoai.PasswordChar = false;
            this.txtTenLoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenLoai.PlaceholderText = "";
            this.txtTenLoai.ReadOnly = false;
            this.txtTenLoai.Size = new System.Drawing.Size(171, 28);
            this.txtTenLoai.TabIndex = 5;
            this.txtTenLoai.Texts = "";
            this.txtTenLoai.UnderlinedStyle = false;
            this.txtTenLoai._TextChanged += new System.EventHandler(this.txtTenLoai__TextChanged);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label15.Location = new System.Drawing.Point(3, 89);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label15.Size = new System.Drawing.Size(262, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "* Bạn phải nhập TÊN LOẠI";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(4, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Trạng Thái";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThai.FormattingEnabled = true;
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbxTrangThai.Location = new System.Drawing.Point(105, 109);
            this.cbxTrangThai.MinimumSize = new System.Drawing.Size(100, 0);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Size = new System.Drawing.Size(172, 27);
            this.cbxTrangThai.TabIndex = 28;
            this.cbxTrangThai.Text = "Hoạt động";
            this.cbxTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbxTrangThai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(3, 142);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label3.Size = new System.Drawing.Size(277, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "* Bạn phải nhập TRẠNG THÁI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(3, 167);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label20.Size = new System.Drawing.Size(287, 32);
            this.label20.TabIndex = 39;
            this.label20.Text = "Import File Excel";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            this.btnImport.AutoSize = true;
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnImport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnImport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnImport.BorderRadius = 0;
            this.btnImport.BorderSize = 2;
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.Location = new System.Drawing.Point(120, 207);
            this.btnImport.Margin = new System.Windows.Forms.Padding(120, 8, 10, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(44, 42);
            this.btnImport.TabIndex = 42;
            this.btnImport.TextColor = System.Drawing.Color.White;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 249);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label6.Size = new System.Drawing.Size(287, 26);
            this.label6.TabIndex = 43;
            this.label6.Text = "Export File Excel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnExport.BorderRadius = 0;
            this.btnExport.BorderSize = 2;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(120, 283);
            this.btnExport.Margin = new System.Windows.Forms.Padding(120, 8, 10, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(44, 42);
            this.btnExport.TabIndex = 44;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 447);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(301, 45);
            this.flowLayoutPanel3.TabIndex = 1;
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
            this.btnThem.Location = new System.Drawing.Point(23, 3);
            this.btnThem.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(44, 40);
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
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.DarkGray;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(87, 3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(44, 40);
            this.btnSua.TabIndex = 1;
            this.btnSua.TextColor = System.Drawing.Color.DarkGray;
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
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(151, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(44, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
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
            this.btnReset.Location = new System.Drawing.Point(215, 3);
            this.btnReset.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // LoaiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaiGUI";
            this.Text = "LoaiGUI";
            this.Load += new System.EventHandler(this.LoaiGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoai)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaLoai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtTenLoai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.DataGridView dgvLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkTrangThai;
        private System.Windows.Forms.Label label27;
        private MyCustom.BiggerCheckBox chkHoatDong;
        private System.Windows.Forms.Label label28;
        private MyCustom.BiggerCheckBox chkKoHD;
        private System.Windows.Forms.Label label29;
        private MyCustom.RJButton btnThem;
        private System.Windows.Forms.Label label20;
        private MyCustom.RJButton btnImport;
        private System.Windows.Forms.Label label6;
        private MyCustom.RJButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}