namespace GUI
{
    partial class SanPhamGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPhamGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.chkGioiTinh = new GUI.MyCustom.BiggerCheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkNam = new GUI.MyCustom.BiggerCheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkNu = new GUI.MyCustom.BiggerCheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.chkTuoi = new GUI.MyCustom.BiggerCheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTuoiStart = new GUI.MyCustom.RJTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTuoiEnd = new GUI.MyCustom.RJTextBox();
            this.chkDiemTL = new GUI.MyCustom.BiggerCheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDiemTLStart = new GUI.MyCustom.RJTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtDiemTLEnd = new GUI.MyCustom.RJTextBox();
            this.chkTrangThai = new GUI.MyCustom.BiggerCheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.chkHoatDong = new GUI.MyCustom.BiggerCheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.chkKoHD = new GUI.MyCustom.BiggerCheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteIMG = new GUI.MyCustom.RJButton();
            this.lblErrIMG = new System.Windows.Forms.Label();
            this.btnUploadAnh = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSP = new GUI.MyCustom.RJTextBox();
            this.lblErrMaSP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new GUI.MyCustom.RJTextBox();
            this.lblErrTenSP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTonKho = new GUI.MyCustom.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new GUI.MyCustom.RJTextBox();
            this.lblErrGiaNhap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiaBan = new GUI.MyCustom.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxDonViTinh = new GUI.MyCustom.RJComboBox();
            this.lblErrDonViTinh = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTrangThai = new GUI.MyCustom.RJComboBox();
            this.lblErrTrangThai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaLoai = new GUI.MyCustom.RJTextBox();
            this.btnMaLoai = new GUI.MyCustom.RJButton();
            this.lblErrMaLoai = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaNSX = new GUI.MyCustom.RJTextBox();
            this.btnMaNSX = new GUI.MyCustom.RJButton();
            this.lblErrMaNSX = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaNCC = new GUI.MyCustom.RJTextBox();
            this.btnMaNCC = new GUI.MyCustom.RJButton();
            this.lblErrMaNCC = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.flpFilter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1573, 908);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.dgvSanPham);
            this.panel3.Controls.Add(this.flpFilter);
            this.panel3.Location = new System.Drawing.Point(421, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 898);
            this.panel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1113, 61);
            this.flowLayoutPanel4.TabIndex = 2;
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
            this.cbxTimKiem.Location = new System.Drawing.Point(5, 10);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(133, 37);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTimKiem.Size = new System.Drawing.Size(144, 37);
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
            this.txtTimKiem.Location = new System.Drawing.Point(159, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
<<<<<<< HEAD
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(9, 9, 9, 9);
=======
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(9);
>>>>>>> d2608a1a22880381357abd8e1dd862e4ca8edf3a
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(805, 41);
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
            this.btnTimKiem.Location = new System.Drawing.Point(973, 10);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(39, 39);
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
            this.btnFilter.Location = new System.Drawing.Point(1036, 10);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(20, 10, 13, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(59, 46);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AllowUserToResizeColumns = false;
            this.dgvSanPham.AllowUserToResizeRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeight = 28;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.Ho,
            this.Ten,
            this.NgaySinh,
            this.GioiTinh,
            this.SoDT,
            this.TrangThai,
            this.a,
            this.MaNSX,
            this.MaNCC,
            this.Column1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanPham.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSanPham.EnableHeadersVisualStyles = false;
            this.dgvSanPham.GridColor = System.Drawing.Color.Black;
            this.dgvSanPham.Location = new System.Drawing.Point(7, 76);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSanPham.RowTemplate.Height = 30;
            this.dgvSanPham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1128, 812);
            this.dgvSanPham.TabIndex = 1;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            this.dgvSanPham.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPham_CellFormatting);
            this.dgvSanPham.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSanPham_DataBindingComplete);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKH.DataPropertyName = "MaSP";
            this.MaKH.Frozen = true;
            this.MaKH.HeaderText = "Mã SP";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Width = 60;
            // 
            // Ho
            // 
            this.Ho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ho.DataPropertyName = "TenSP";
            this.Ho.HeaderText = "Tên SP";
            this.Ho.MinimumWidth = 6;
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ten.DataPropertyName = "SoLuong";
            this.Ten.HeaderText = "Số lượng";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 75;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NgaySinh.DataPropertyName = "DonGiaNhap";
            this.NgaySinh.HeaderText = "Giá nhập";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 109;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GioiTinh.DataPropertyName = "DonGiaBan";
            this.GioiTinh.HeaderText = "Giá bán";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 98;
            // 
            // SoDT
            // 
            this.SoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoDT.DataPropertyName = "DonViTinh";
            this.SoDT.HeaderText = "Đơn vị tính";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 95;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 85;
            // 
            // a
            // 
            this.a.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.a.DataPropertyName = "MaLoai";
            this.a.HeaderText = "Mã loại";
            this.a.MinimumWidth = 6;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Width = 67;
            // 
            // MaNSX
            // 
            this.MaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.HeaderText = "Mã NSX";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.ReadOnly = true;
            this.MaNSX.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNSX.Width = 70;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 70;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IMG";
            this.Column1.HeaderText = "Hình ảnh";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Visible = false;
            this.Column1.Width = 112;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.flpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFilter.Controls.Add(this.chkGioiTinh);
            this.flpFilter.Controls.Add(this.label12);
            this.flpFilter.Controls.Add(this.chkNam);
            this.flpFilter.Controls.Add(this.label21);
            this.flpFilter.Controls.Add(this.chkNu);
            this.flpFilter.Controls.Add(this.label22);
            this.flpFilter.Controls.Add(this.chkTuoi);
            this.flpFilter.Controls.Add(this.label23);
            this.flpFilter.Controls.Add(this.txtTuoiStart);
            this.flpFilter.Controls.Add(this.label24);
            this.flpFilter.Controls.Add(this.txtTuoiEnd);
            this.flpFilter.Controls.Add(this.chkDiemTL);
            this.flpFilter.Controls.Add(this.label25);
            this.flpFilter.Controls.Add(this.txtDiemTLStart);
            this.flpFilter.Controls.Add(this.label26);
            this.flpFilter.Controls.Add(this.txtDiemTLEnd);
            this.flpFilter.Controls.Add(this.chkTrangThai);
            this.flpFilter.Controls.Add(this.label27);
            this.flpFilter.Controls.Add(this.chkHoatDong);
            this.flpFilter.Controls.Add(this.label28);
            this.flpFilter.Controls.Add(this.chkKoHD);
            this.flpFilter.Controls.Add(this.label29);
            this.flpFilter.Location = new System.Drawing.Point(711, 69);
            this.flpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(385, 226);
            this.flpFilter.TabIndex = 3;
            this.flpFilter.Visible = false;
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGioiTinh.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkGioiTinh.BoxColor = System.Drawing.Color.Black;
            this.chkGioiTinh.BoxLocationX = 5;
            this.chkGioiTinh.BoxLocationY = 8;
            this.chkGioiTinh.BoxSize = 14;
            this.chkGioiTinh.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGioiTinh.FlatAppearance.BorderSize = 0;
            this.chkGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGioiTinh.Location = new System.Drawing.Point(4, 4);
            this.chkGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkGioiTinh.Size = new System.Drawing.Size(32, 36);
            this.chkGioiTinh.TabIndex = 3;
            this.chkGioiTinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGioiTinh.TextLocationX = 16;
            this.chkGioiTinh.TextLocationY = 1;
            this.chkGioiTinh.TickColor = System.Drawing.Color.Black;
            this.chkGioiTinh.TickLeftPosition = 5F;
            this.chkGioiTinh.TickSize = 11F;
            this.chkGioiTinh.TickTopPosition = 8F;
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label12.Location = new System.Drawing.Point(44, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 34);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giới tính:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkNam
            // 
            this.chkNam.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNam.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkNam.BoxColor = System.Drawing.Color.Black;
            this.chkNam.BoxLocationX = 5;
            this.chkNam.BoxLocationY = 8;
            this.chkNam.BoxSize = 14;
            this.chkNam.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNam.FlatAppearance.BorderSize = 0;
            this.chkNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNam.Location = new System.Drawing.Point(170, 4);
            this.chkNam.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.chkNam.Name = "chkNam";
            this.chkNam.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkNam.Size = new System.Drawing.Size(32, 36);
            this.chkNam.TabIndex = 4;
            this.chkNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNam.TextLocationX = 16;
            this.chkNam.TextLocationY = 1;
            this.chkNam.TickColor = System.Drawing.Color.Black;
            this.chkNam.TickLeftPosition = 5F;
            this.chkNam.TickSize = 11F;
            this.chkNam.TickTopPosition = 8F;
            this.chkNam.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label21.Location = new System.Drawing.Point(207, 5);
            this.label21.Margin = new System.Windows.Forms.Padding(5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 34);
            this.label21.TabIndex = 6;
            this.label21.Text = "Nam";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkNu
            // 
            this.chkNu.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNu.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkNu.BoxColor = System.Drawing.Color.Black;
            this.chkNu.BoxLocationX = 5;
            this.chkNu.BoxLocationY = 8;
            this.chkNu.BoxSize = 14;
            this.chkNu.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNu.FlatAppearance.BorderSize = 0;
            this.chkNu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNu.Location = new System.Drawing.Point(281, 4);
            this.chkNu.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.chkNu.Name = "chkNu";
            this.chkNu.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkNu.Size = new System.Drawing.Size(32, 36);
            this.chkNu.TabIndex = 5;
            this.chkNu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNu.TextLocationX = 16;
            this.chkNu.TextLocationY = 1;
            this.chkNu.TickColor = System.Drawing.Color.Black;
            this.chkNu.TickLeftPosition = 5F;
            this.chkNu.TickSize = 11F;
            this.chkNu.TickTopPosition = 8F;
            this.chkNu.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label22.Location = new System.Drawing.Point(318, 5);
            this.label22.Margin = new System.Windows.Forms.Padding(5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 34);
            this.label22.TabIndex = 7;
            this.label22.Text = "Nữ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTuoi
            // 
            this.chkTuoi.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTuoi.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkTuoi.BoxColor = System.Drawing.Color.Black;
            this.chkTuoi.BoxLocationX = 5;
            this.chkTuoi.BoxLocationY = 8;
            this.chkTuoi.BoxSize = 14;
            this.chkTuoi.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTuoi.FlatAppearance.BorderSize = 0;
            this.chkTuoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTuoi.Location = new System.Drawing.Point(4, 48);
            this.chkTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.chkTuoi.Name = "chkTuoi";
            this.chkTuoi.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkTuoi.Size = new System.Drawing.Size(32, 36);
            this.chkTuoi.TabIndex = 9;
            this.chkTuoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTuoi.TextLocationX = 16;
            this.chkTuoi.TextLocationY = 1;
            this.chkTuoi.TickColor = System.Drawing.Color.Black;
            this.chkTuoi.TickLeftPosition = 5F;
            this.chkTuoi.TickSize = 11F;
            this.chkTuoi.TickTopPosition = 8F;
            this.chkTuoi.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label23.Location = new System.Drawing.Point(44, 49);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 34);
            this.label23.TabIndex = 8;
            this.label23.Text = "Tuổi:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTuoiStart
            // 
            this.txtTuoiStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtTuoiStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTuoiStart.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTuoiStart.BorderRadius = 0;
            this.txtTuoiStart.BorderSize = 2;
            this.txtTuoiStart.Enabled = false;
            this.txtTuoiStart.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoiStart.ForeColor = System.Drawing.Color.Black;
            this.txtTuoiStart.Location = new System.Drawing.Point(158, 49);
            this.txtTuoiStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtTuoiStart.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtTuoiStart.Multiline = false;
            this.txtTuoiStart.Name = "txtTuoiStart";
            this.txtTuoiStart.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtTuoiStart.PasswordChar = false;
            this.txtTuoiStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTuoiStart.PlaceholderText = "Từ";
            this.txtTuoiStart.ReadOnly = false;
            this.txtTuoiStart.Size = new System.Drawing.Size(79, 34);
            this.txtTuoiStart.TabIndex = 10;
            this.txtTuoiStart.Texts = "";
            this.txtTuoiStart.UnderlinedStyle = false;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label24.Location = new System.Drawing.Point(246, 49);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(17, 34);
            this.label24.TabIndex = 12;
            this.label24.Text = "-";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTuoiEnd
            // 
            this.txtTuoiEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtTuoiEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTuoiEnd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTuoiEnd.BorderRadius = 0;
            this.txtTuoiEnd.BorderSize = 2;
            this.txtTuoiEnd.Enabled = false;
            this.txtTuoiEnd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoiEnd.ForeColor = System.Drawing.Color.Black;
            this.txtTuoiEnd.Location = new System.Drawing.Point(273, 49);
            this.txtTuoiEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtTuoiEnd.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtTuoiEnd.Multiline = false;
            this.txtTuoiEnd.Name = "txtTuoiEnd";
            this.txtTuoiEnd.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtTuoiEnd.PasswordChar = false;
            this.txtTuoiEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTuoiEnd.PlaceholderText = "Đến";
            this.txtTuoiEnd.ReadOnly = false;
            this.txtTuoiEnd.Size = new System.Drawing.Size(79, 34);
            this.txtTuoiEnd.TabIndex = 11;
            this.txtTuoiEnd.Texts = "";
            this.txtTuoiEnd.UnderlinedStyle = false;
            // 
            // chkDiemTL
            // 
            this.chkDiemTL.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDiemTL.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkDiemTL.BoxColor = System.Drawing.Color.Black;
            this.chkDiemTL.BoxLocationX = 5;
            this.chkDiemTL.BoxLocationY = 8;
            this.chkDiemTL.BoxSize = 14;
            this.chkDiemTL.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDiemTL.FlatAppearance.BorderSize = 0;
            this.chkDiemTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDiemTL.Location = new System.Drawing.Point(4, 92);
            this.chkDiemTL.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiemTL.Name = "chkDiemTL";
            this.chkDiemTL.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkDiemTL.Size = new System.Drawing.Size(32, 36);
            this.chkDiemTL.TabIndex = 14;
            this.chkDiemTL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDiemTL.TextLocationX = 16;
            this.chkDiemTL.TextLocationY = 1;
            this.chkDiemTL.TickColor = System.Drawing.Color.Black;
            this.chkDiemTL.TickLeftPosition = 5F;
            this.chkDiemTL.TickSize = 11F;
            this.chkDiemTL.TickTopPosition = 8F;
            this.chkDiemTL.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label25.Location = new System.Drawing.Point(44, 93);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 34);
            this.label25.TabIndex = 13;
            this.label25.Text = "Điểm TL:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiemTLStart
            // 
            this.txtDiemTLStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTLStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtDiemTLStart.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtDiemTLStart.BorderRadius = 0;
            this.txtDiemTLStart.BorderSize = 2;
            this.txtDiemTLStart.Enabled = false;
            this.txtDiemTLStart.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTLStart.ForeColor = System.Drawing.Color.Black;
            this.txtDiemTLStart.Location = new System.Drawing.Point(158, 93);
            this.txtDiemTLStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiemTLStart.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtDiemTLStart.Multiline = false;
            this.txtDiemTLStart.Name = "txtDiemTLStart";
            this.txtDiemTLStart.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtDiemTLStart.PasswordChar = false;
            this.txtDiemTLStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDiemTLStart.PlaceholderText = "Từ";
            this.txtDiemTLStart.ReadOnly = false;
            this.txtDiemTLStart.Size = new System.Drawing.Size(79, 34);
            this.txtDiemTLStart.TabIndex = 15;
            this.txtDiemTLStart.Texts = "";
            this.txtDiemTLStart.UnderlinedStyle = false;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label26.Location = new System.Drawing.Point(246, 93);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(17, 34);
            this.label26.TabIndex = 17;
            this.label26.Text = "-";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDiemTLEnd
            // 
            this.txtDiemTLEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiemTLEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtDiemTLEnd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtDiemTLEnd.BorderRadius = 0;
            this.txtDiemTLEnd.BorderSize = 2;
            this.txtDiemTLEnd.Enabled = false;
            this.txtDiemTLEnd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTLEnd.ForeColor = System.Drawing.Color.Black;
            this.txtDiemTLEnd.Location = new System.Drawing.Point(273, 93);
            this.txtDiemTLEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiemTLEnd.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtDiemTLEnd.Multiline = false;
            this.txtDiemTLEnd.Name = "txtDiemTLEnd";
            this.txtDiemTLEnd.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtDiemTLEnd.PasswordChar = false;
            this.txtDiemTLEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDiemTLEnd.PlaceholderText = "Đến";
            this.txtDiemTLEnd.ReadOnly = false;
            this.txtDiemTLEnd.Size = new System.Drawing.Size(79, 34);
            this.txtDiemTLEnd.TabIndex = 16;
            this.txtDiemTLEnd.Texts = "";
            this.txtDiemTLEnd.UnderlinedStyle = false;
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
            this.chkTrangThai.Location = new System.Drawing.Point(4, 136);
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
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label27.Location = new System.Drawing.Point(44, 137);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 5, 5, 5);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(104, 34);
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
            this.chkHoatDong.Location = new System.Drawing.Point(157, 136);
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
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(194, 137);
            this.label28.Margin = new System.Windows.Forms.Padding(5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 34);
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
            this.chkKoHD.Location = new System.Drawing.Point(133, 180);
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
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label29.Location = new System.Drawing.Point(170, 181);
            this.label29.Margin = new System.Windows.Forms.Padding(5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(196, 34);
            this.label29.TabIndex = 23;
            this.label29.Text = "Không hoạt động";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 898);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN SẢN PHẨM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.panel4);
            this.flowLayoutPanel5.Controls.Add(this.pbImage);
            this.flowLayoutPanel5.Controls.Add(this.panel2);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 38);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(1, 4, 4, 1);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(387, 183);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 176);
            this.panel4.TabIndex = 23;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.ErrorImage = null;
            this.pbImage.Image = global::GUI.Properties.Resources.placeholder_image;
            this.pbImage.InitialImage = global::GUI.Properties.Resources.placeholder_image;
            this.pbImage.Location = new System.Drawing.Point(21, 0);
            this.pbImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(265, 183);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Tag = "Placeholder";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteIMG);
            this.panel2.Controls.Add(this.lblErrIMG);
            this.panel2.Controls.Add(this.btnUploadAnh);
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 183);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteIMG
            // 
            this.btnDeleteIMG.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteIMG.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDeleteIMG.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeleteIMG.BorderRadius = 0;
            this.btnDeleteIMG.BorderSize = 0;
            this.btnDeleteIMG.FlatAppearance.BorderSize = 0;
            this.btnDeleteIMG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteIMG.ForeColor = System.Drawing.Color.White;
            this.btnDeleteIMG.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteIMG.Image")));
            this.btnDeleteIMG.Location = new System.Drawing.Point(4, 0);
            this.btnDeleteIMG.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteIMG.Name = "btnDeleteIMG";
            this.btnDeleteIMG.Size = new System.Drawing.Size(31, 34);
            this.btnDeleteIMG.TabIndex = 4;
            this.btnDeleteIMG.TextColor = System.Drawing.Color.White;
            this.btnDeleteIMG.UseVisualStyleBackColor = false;
            this.btnDeleteIMG.Click += new System.EventHandler(this.btnDeleteIMG_Click);
            // 
            // lblErrIMG
            // 
            this.lblErrIMG.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrIMG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrIMG.Location = new System.Drawing.Point(4, 110);
            this.lblErrIMG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrIMG.Name = "lblErrIMG";
            this.lblErrIMG.Size = new System.Drawing.Size(92, 65);
            this.lblErrIMG.TabIndex = 22;
            this.lblErrIMG.Text = "* Bạn phải chọn ảnh đại diện";
            this.lblErrIMG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUploadAnh
            // 
            this.btnUploadAnh.BackColor = System.Drawing.Color.Transparent;
            this.btnUploadAnh.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUploadAnh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUploadAnh.BorderRadius = 0;
            this.btnUploadAnh.BorderSize = 0;
            this.btnUploadAnh.FlatAppearance.BorderSize = 0;
            this.btnUploadAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadAnh.ForeColor = System.Drawing.Color.White;
            this.btnUploadAnh.Image = global::GUI.Properties.Resources.icons8_upload_32;
            this.btnUploadAnh.Location = new System.Drawing.Point(31, 48);
            this.btnUploadAnh.Margin = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.btnUploadAnh.Name = "btnUploadAnh";
            this.btnUploadAnh.Size = new System.Drawing.Size(39, 39);
            this.btnUploadAnh.TabIndex = 3;
            this.btnUploadAnh.TextColor = System.Drawing.Color.White;
            this.btnUploadAnh.UseVisualStyleBackColor = false;
            this.btnUploadAnh.Click += new System.EventHandler(this.btnUploadAnh_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaSP);
            this.flowLayoutPanel2.Controls.Add(this.lblErrMaSP);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtTenSP);
            this.flowLayoutPanel2.Controls.Add(this.lblErrTenSP);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtTonKho);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtGiaNhap);
            this.flowLayoutPanel2.Controls.Add(this.lblErrGiaNhap);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.txtGiaBan);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.cbxDonViTinh);
            this.flowLayoutPanel2.Controls.Add(this.lblErrDonViTinh);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.cbxTrangThai);
            this.flowLayoutPanel2.Controls.Add(this.lblErrTrangThai);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.txtMaLoai);
            this.flowLayoutPanel2.Controls.Add(this.btnMaLoai);
            this.flowLayoutPanel2.Controls.Add(this.lblErrMaLoai);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.txtMaNSX);
            this.flowLayoutPanel2.Controls.Add(this.btnMaNSX);
            this.flowLayoutPanel2.Controls.Add(this.lblErrMaNSX);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.txtMaNCC);
            this.flowLayoutPanel2.Controls.Add(this.btnMaNCC);
            this.flowLayoutPanel2.Controls.Add(this.lblErrMaNCC);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 223);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 614);
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
            this.label2.Text = "Mã SP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaSP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaSP.BorderRadius = 0;
            this.txtMaSP.BorderSize = 2;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(140, 5);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaSP.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtMaSP.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtMaSP.Multiline = false;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Padding = new System.Windows.Forms.Padding(5, 5, 3, 2);
            this.txtMaSP.PasswordChar = false;
            this.txtMaSP.PlaceholderColor = System.Drawing.Color.Black;
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.ReadOnly = false;
            this.txtMaSP.Size = new System.Drawing.Size(228, 34);
            this.txtMaSP.TabIndex = 1;
            this.txtMaSP.Texts = "";
            this.txtMaSP.UnderlinedStyle = false;
            // 
            // lblErrMaSP
            // 
            this.lblErrMaSP.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrMaSP.Location = new System.Drawing.Point(4, 44);
            this.lblErrMaSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrMaSP.Name = "lblErrMaSP";
            this.lblErrMaSP.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.lblErrMaSP.Size = new System.Drawing.Size(336, 21);
            this.lblErrMaSP.TabIndex = 21;
            this.lblErrMaSP.Text = "* Bạn phải nhập Mã SP";
            this.lblErrMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrMaSP.Click += new System.EventHandler(this.lblErrMaSP_Click);
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
            this.label3.Text = "Tên SP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenSP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenSP.BorderRadius = 0;
            this.txtTenSP.BorderSize = 2;
            this.txtTenSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.Location = new System.Drawing.Point(140, 70);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenSP.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtTenSP.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtTenSP.Multiline = false;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Padding = new System.Windows.Forms.Padding(9);
            this.txtTenSP.PasswordChar = false;
            this.txtTenSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.ReadOnly = false;
            this.txtTenSP.Size = new System.Drawing.Size(228, 34);
            this.txtTenSP.TabIndex = 3;
            this.txtTenSP.Texts = "";
            this.txtTenSP.UnderlinedStyle = false;
            this.txtTenSP._TextChanged += new System.EventHandler(this.txtTenSP__TextChanged);
            // 
            // lblErrTenSP
            // 
            this.lblErrTenSP.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrTenSP.Location = new System.Drawing.Point(4, 109);
            this.lblErrTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrTenSP.Name = "lblErrTenSP";
            this.lblErrTenSP.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.lblErrTenSP.Size = new System.Drawing.Size(336, 21);
            this.lblErrTenSP.TabIndex = 22;
            this.lblErrTenSP.Text = "* Bạn phải nhập Tên SP";
            this.lblErrTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label4.Text = "Tồn kho";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTonKho
            // 
            this.txtTonKho.BackColor = System.Drawing.SystemColors.Window;
            this.txtTonKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTonKho.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTonKho.BorderRadius = 0;
            this.txtTonKho.BorderSize = 2;
            this.txtTonKho.Enabled = false;
            this.txtTonKho.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKho.ForeColor = System.Drawing.Color.Black;
            this.txtTonKho.Location = new System.Drawing.Point(140, 135);
            this.txtTonKho.Margin = new System.Windows.Forms.Padding(5);
            this.txtTonKho.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtTonKho.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtTonKho.Multiline = false;
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Padding = new System.Windows.Forms.Padding(9);
            this.txtTonKho.PasswordChar = false;
            this.txtTonKho.PlaceholderColor = System.Drawing.Color.Black;
            this.txtTonKho.PlaceholderText = "";
            this.txtTonKho.ReadOnly = false;
            this.txtTonKho.Size = new System.Drawing.Size(228, 34);
            this.txtTonKho.TabIndex = 5;
            this.txtTonKho.Texts = "0";
            this.txtTonKho.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(5, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 34);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giá nhập";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtGiaNhap.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtGiaNhap.BorderRadius = 0;
            this.txtGiaNhap.BorderSize = 2;
            this.txtGiaNhap.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.ForeColor = System.Drawing.Color.Black;
            this.txtGiaNhap.Location = new System.Drawing.Point(140, 179);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaNhap.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtGiaNhap.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtGiaNhap.Multiline = false;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Padding = new System.Windows.Forms.Padding(9);
            this.txtGiaNhap.PasswordChar = false;
            this.txtGiaNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.ReadOnly = false;
            this.txtGiaNhap.Size = new System.Drawing.Size(228, 34);
            this.txtGiaNhap.TabIndex = 29;
            this.txtGiaNhap.Texts = "";
            this.txtGiaNhap.UnderlinedStyle = false;
            this.txtGiaNhap._TextChanged += new System.EventHandler(this.txtGiaNhap__TextChanged_1);
            // 
            // lblErrGiaNhap
            // 
            this.lblErrGiaNhap.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrGiaNhap.Location = new System.Drawing.Point(4, 218);
            this.lblErrGiaNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrGiaNhap.Name = "lblErrGiaNhap";
            this.lblErrGiaNhap.Size = new System.Drawing.Size(367, 21);
            this.lblErrGiaNhap.TabIndex = 33;
            this.lblErrGiaNhap.Text = "* Bạn phải nhập Giá nhập hàng";
            this.lblErrGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(5, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 34);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá bán";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtGiaBan.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtGiaBan.BorderRadius = 0;
            this.txtGiaBan.BorderSize = 2;
            this.txtGiaBan.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.ForeColor = System.Drawing.Color.Black;
            this.txtGiaBan.Location = new System.Drawing.Point(140, 244);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(5);
            this.txtGiaBan.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtGiaBan.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtGiaBan.Multiline = false;
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Padding = new System.Windows.Forms.Padding(9);
            this.txtGiaBan.PasswordChar = false;
            this.txtGiaBan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaBan.PlaceholderText = "";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(228, 34);
            this.txtGiaBan.TabIndex = 30;
            this.txtGiaBan.Texts = "";
            this.txtGiaBan.UnderlinedStyle = false;
            this.txtGiaBan.Click += new System.EventHandler(this.txtGiaBan_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(5, 288);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 34);
            this.label7.TabIndex = 10;
            this.label7.Text = "Đơn vị tính";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxDonViTinh
            // 
            this.cbxDonViTinh.BackColor = System.Drawing.Color.White;
            this.cbxDonViTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxDonViTinh.BorderSize = 2;
            this.cbxDonViTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxDonViTinh.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDonViTinh.ForeColor = System.Drawing.Color.Black;
            this.cbxDonViTinh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxDonViTinh.Items.AddRange(new object[] {
            "Cái",
            "Gói",
            "Chai",
            "Hộp",
            "Lọ",
            "Thùng"});
            this.cbxDonViTinh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxDonViTinh.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxDonViTinh.Location = new System.Drawing.Point(139, 287);
            this.cbxDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDonViTinh.MinimumSize = new System.Drawing.Size(133, 6);
            this.cbxDonViTinh.Name = "cbxDonViTinh";
            this.cbxDonViTinh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDonViTinh.Size = new System.Drawing.Size(228, 34);
            this.cbxDonViTinh.TabIndex = 31;
            this.cbxDonViTinh.Texts = "--Chọn đơn vị--";
            this.cbxDonViTinh.OnSelectedIndexChanged += new System.EventHandler(this.cbxDonViTinh_OnSelectedIndexChanged);
            // 
            // lblErrDonViTinh
            // 
            this.lblErrDonViTinh.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrDonViTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrDonViTinh.Location = new System.Drawing.Point(4, 327);
            this.lblErrDonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrDonViTinh.Name = "lblErrDonViTinh";
            this.lblErrDonViTinh.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.lblErrDonViTinh.Size = new System.Drawing.Size(367, 21);
            this.lblErrDonViTinh.TabIndex = 46;
            this.lblErrDonViTinh.Text = "* Bạn phải chọn Đơn vị tính";
            this.lblErrDonViTinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(5, 353);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 34);
            this.label9.TabIndex = 14;
            this.label9.Text = "Trạng thái";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxTrangThai
            // 
            this.cbxTrangThai.BackColor = System.Drawing.Color.White;
            this.cbxTrangThai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxTrangThai.BorderSize = 2;
            this.cbxTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxTrangThai.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbxTrangThai.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxTrangThai.Items.AddRange(new object[] {
            "Hoạt động",
            "Không hoạt động"});
            this.cbxTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxTrangThai.Location = new System.Drawing.Point(139, 352);
            this.cbxTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTrangThai.MinimumSize = new System.Drawing.Size(133, 6);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTrangThai.Size = new System.Drawing.Size(228, 34);
            this.cbxTrangThai.TabIndex = 28;
            this.cbxTrangThai.Texts = "--Chọn trạng thái--";
            this.cbxTrangThai.OnSelectedIndexChanged += new System.EventHandler(this.cbxTrangThai_OnSelectedIndexChanged);
            // 
            // lblErrTrangThai
            // 
            this.lblErrTrangThai.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrTrangThai.Location = new System.Drawing.Point(4, 392);
            this.lblErrTrangThai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrTrangThai.Name = "lblErrTrangThai";
            this.lblErrTrangThai.Padding = new System.Windows.Forms.Padding(0, 0, 13, 0);
            this.lblErrTrangThai.Size = new System.Drawing.Size(367, 21);
            this.lblErrTrangThai.TabIndex = 48;
            this.lblErrTrangThai.Text = "* Bạn phải chọn Trạng thái";
            this.lblErrTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(5, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 34);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mã loại";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaLoai.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaLoai.BorderRadius = 0;
            this.txtMaLoai.BorderSize = 2;
            this.txtMaLoai.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoai.ForeColor = System.Drawing.Color.Black;
            this.txtMaLoai.Location = new System.Drawing.Point(140, 418);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.txtMaLoai.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtMaLoai.MinimumSize = new System.Drawing.Size(67, 34);
            this.txtMaLoai.Multiline = false;
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Padding = new System.Windows.Forms.Padding(9);
            this.txtMaLoai.PasswordChar = false;
            this.txtMaLoai.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaLoai.PlaceholderText = "";
            this.txtMaLoai.ReadOnly = false;
            this.txtMaLoai.Size = new System.Drawing.Size(163, 34);
            this.txtMaLoai.TabIndex = 35;
            this.txtMaLoai.Texts = "";
            this.txtMaLoai.UnderlinedStyle = false;
            this.txtMaLoai._TextChanged += new System.EventHandler(this.txtMaLoai__TextChanged);
            // 
            // btnMaLoai
            // 
            this.btnMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.btnMaLoai.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMaLoai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnMaLoai.BorderRadius = 0;
            this.btnMaLoai.BorderSize = 2;
            this.btnMaLoai.CausesValidation = false;
            this.btnMaLoai.FlatAppearance.BorderSize = 0;
            this.btnMaLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaLoai.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaLoai.ForeColor = System.Drawing.Color.Black;
            this.btnMaLoai.Location = new System.Drawing.Point(310, 418);
            this.btnMaLoai.Margin = new System.Windows.Forms.Padding(7, 5, 0, 4);
            this.btnMaLoai.Name = "btnMaLoai";
            this.btnMaLoai.Size = new System.Drawing.Size(59, 34);
            this.btnMaLoai.TabIndex = 40;
            this.btnMaLoai.Text = "...";
            this.btnMaLoai.TextColor = System.Drawing.Color.Black;
            this.btnMaLoai.UseVisualStyleBackColor = false;
            this.btnMaLoai.Click += new System.EventHandler(this.btnMaLoai_Click);
            // 
            // lblErrMaLoai
            // 
            this.lblErrMaLoai.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMaLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrMaLoai.Location = new System.Drawing.Point(4, 457);
            this.lblErrMaLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrMaLoai.Name = "lblErrMaLoai";
            this.lblErrMaLoai.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.lblErrMaLoai.Size = new System.Drawing.Size(336, 21);
            this.lblErrMaLoai.TabIndex = 43;
            this.lblErrMaLoai.Text = "* Bạn phải nhập Mã loại";
            this.lblErrMaLoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(5, 483);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 34);
            this.label10.TabIndex = 33;
            this.label10.Text = "Mã NSX";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtMaNSX.Location = new System.Drawing.Point(140, 483);
            this.txtMaNSX.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.txtMaNSX.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtMaNSX.MinimumSize = new System.Drawing.Size(67, 34);
            this.txtMaNSX.Multiline = false;
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Padding = new System.Windows.Forms.Padding(9);
            this.txtMaNSX.PasswordChar = false;
            this.txtMaNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNSX.PlaceholderText = "";
            this.txtMaNSX.ReadOnly = false;
            this.txtMaNSX.Size = new System.Drawing.Size(163, 34);
            this.txtMaNSX.TabIndex = 36;
            this.txtMaNSX.Texts = "";
            this.txtMaNSX.UnderlinedStyle = false;
            this.txtMaNSX._TextChanged += new System.EventHandler(this.txtMaNSX__TextChanged);
            // 
            // btnMaNSX
            // 
            this.btnMaNSX.BackColor = System.Drawing.Color.Transparent;
            this.btnMaNSX.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMaNSX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnMaNSX.BorderRadius = 0;
            this.btnMaNSX.BorderSize = 2;
            this.btnMaNSX.CausesValidation = false;
            this.btnMaNSX.FlatAppearance.BorderSize = 0;
            this.btnMaNSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaNSX.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaNSX.ForeColor = System.Drawing.Color.Black;
            this.btnMaNSX.Location = new System.Drawing.Point(310, 483);
            this.btnMaNSX.Margin = new System.Windows.Forms.Padding(7, 5, 0, 4);
            this.btnMaNSX.Name = "btnMaNSX";
            this.btnMaNSX.Size = new System.Drawing.Size(59, 34);
            this.btnMaNSX.TabIndex = 42;
            this.btnMaNSX.Text = "...";
            this.btnMaNSX.TextColor = System.Drawing.Color.Black;
            this.btnMaNSX.UseVisualStyleBackColor = false;
            this.btnMaNSX.Click += new System.EventHandler(this.btnMaNSX_Click);
            // 
            // lblErrMaNSX
            // 
            this.lblErrMaNSX.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMaNSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrMaNSX.Location = new System.Drawing.Point(4, 522);
            this.lblErrMaNSX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrMaNSX.Name = "lblErrMaNSX";
            this.lblErrMaNSX.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.lblErrMaNSX.Size = new System.Drawing.Size(336, 21);
            this.lblErrMaNSX.TabIndex = 44;
            this.lblErrMaNSX.Text = "* Bạn phải nhập Mã NSX";
            this.lblErrMaNSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(5, 548);
            this.label11.Margin = new System.Windows.Forms.Padding(5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 34);
            this.label11.TabIndex = 34;
            this.label11.Text = "Mã NCC";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaNCC.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaNCC.BorderRadius = 0;
            this.txtMaNCC.BorderSize = 2;
            this.txtMaNCC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.ForeColor = System.Drawing.Color.Black;
            this.txtMaNCC.Location = new System.Drawing.Point(140, 548);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.txtMaNCC.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtMaNCC.MinimumSize = new System.Drawing.Size(67, 34);
            this.txtMaNCC.Multiline = false;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Padding = new System.Windows.Forms.Padding(9);
            this.txtMaNCC.PasswordChar = false;
            this.txtMaNCC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNCC.PlaceholderText = "";
            this.txtMaNCC.ReadOnly = false;
            this.txtMaNCC.Size = new System.Drawing.Size(163, 34);
            this.txtMaNCC.TabIndex = 37;
            this.txtMaNCC.Texts = "";
            this.txtMaNCC.UnderlinedStyle = false;
            this.txtMaNCC._TextChanged += new System.EventHandler(this.txtMaNCC__TextChanged);
            // 
            // btnMaNCC
            // 
            this.btnMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.btnMaNCC.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMaNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnMaNCC.BorderRadius = 0;
            this.btnMaNCC.BorderSize = 2;
            this.btnMaNCC.CausesValidation = false;
            this.btnMaNCC.FlatAppearance.BorderSize = 0;
            this.btnMaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaNCC.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaNCC.ForeColor = System.Drawing.Color.Black;
            this.btnMaNCC.Location = new System.Drawing.Point(310, 548);
            this.btnMaNCC.Margin = new System.Windows.Forms.Padding(7, 5, 0, 4);
            this.btnMaNCC.Name = "btnMaNCC";
            this.btnMaNCC.Size = new System.Drawing.Size(59, 34);
            this.btnMaNCC.TabIndex = 41;
            this.btnMaNCC.Text = "...";
            this.btnMaNCC.TextColor = System.Drawing.Color.Black;
            this.btnMaNCC.UseVisualStyleBackColor = false;
            this.btnMaNCC.Click += new System.EventHandler(this.btnMaNCC_Click);
            // 
            // lblErrMaNCC
            // 
            this.lblErrMaNCC.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrMaNCC.Location = new System.Drawing.Point(4, 587);
            this.lblErrMaNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrMaNCC.Name = "lblErrMaNCC";
            this.lblErrMaNCC.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.lblErrMaNCC.Size = new System.Drawing.Size(336, 21);
            this.lblErrMaNCC.TabIndex = 45;
            this.lblErrMaNCC.Text = "* Bạn phải nhập Mã NCC";
            this.lblErrMaNCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(11, 839);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 1, 4, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(387, 53);
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
            this.btnThem.Location = new System.Drawing.Point(27, 1);
            this.btnThem.Margin = new System.Windows.Forms.Padding(27, 1, 4, 4);
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
            this.btnSua.Location = new System.Drawing.Point(117, 1);
            this.btnSua.Margin = new System.Windows.Forms.Padding(27, 1, 4, 4);
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
            this.btnXoa.Location = new System.Drawing.Point(207, 1);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(27, 1, 4, 4);
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
            this.btnReset.Location = new System.Drawing.Point(297, 1);
            this.btnReset.Margin = new System.Windows.Forms.Padding(27, 1, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 49);
            this.btnReset.TabIndex = 3;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SanPhamGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1573, 908);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SanPhamGUI";
            this.Text = "SanPhamGUI";
            this.Load += new System.EventHandler(this.SanPhamGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.flpFilter.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkGioiTinh;
        private System.Windows.Forms.Label label12;
        private MyCustom.BiggerCheckBox chkNam;
        private System.Windows.Forms.Label label21;
        private MyCustom.BiggerCheckBox chkNu;
        private System.Windows.Forms.Label label22;
        private MyCustom.BiggerCheckBox chkTuoi;
        private System.Windows.Forms.Label label23;
        private MyCustom.RJTextBox txtTuoiStart;
        private System.Windows.Forms.Label label24;
        private MyCustom.RJTextBox txtTuoiEnd;
        private MyCustom.BiggerCheckBox chkDiemTL;
        private System.Windows.Forms.Label label25;
        private MyCustom.RJTextBox txtDiemTLStart;
        private System.Windows.Forms.Label label26;
        private MyCustom.RJTextBox txtDiemTLEnd;
        private MyCustom.BiggerCheckBox chkTrangThai;
        private System.Windows.Forms.Label label27;
        private MyCustom.BiggerCheckBox chkHoatDong;
        private System.Windows.Forms.Label label28;
        private MyCustom.BiggerCheckBox chkKoHD;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel panel2;
        private MyCustom.RJButton btnUploadAnh;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaSP;
        private System.Windows.Forms.Label lblErrMaSP;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJTextBox txtTenSP;
        private System.Windows.Forms.Label lblErrTenSP;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtTonKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrGiaNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private MyCustom.RJComboBox cbxTrangThai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.RJButton btnThem;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
        private MyCustom.RJTextBox txtGiaBan;
        private MyCustom.RJComboBox cbxDonViTinh;
        private System.Windows.Forms.Label label8;
        private MyCustom.RJTextBox txtMaLoai;
        private System.Windows.Forms.Label label10;
        private MyCustom.RJTextBox txtMaNSX;
        private System.Windows.Forms.Label label11;
        private MyCustom.RJTextBox txtMaNCC;
        private MyCustom.RJButton btnMaLoai;
        private System.Windows.Forms.Label lblErrMaLoai;
        private MyCustom.RJButton btnMaNSX;
        private System.Windows.Forms.Label lblErrMaNSX;
        private MyCustom.RJButton btnMaNCC;
        private System.Windows.Forms.Label lblErrMaNCC;
        private System.Windows.Forms.Label lblErrDonViTinh;
        private MyCustom.RJButton btnDeleteIMG;
        private System.Windows.Forms.Label lblErrTrangThai;
        private MyCustom.RJTextBox txtGiaNhap;
        private System.Windows.Forms.Label lblErrIMG;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}