namespace GUI
{
    partial class NhaCCGUI
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
<<<<<<< Updated upstream
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
=======
            this.chkGioiTinh = new GUI.MyCustom.BiggerCheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkNam = new GUI.MyCustom.BiggerCheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
>>>>>>> Stashed changes
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
<<<<<<< Updated upstream
            this.chkGioiTinh = new GUI.MyCustom.BiggerCheckBox();
            this.chkNam = new GUI.MyCustom.BiggerCheckBox();
            this.chkNu = new GUI.MyCustom.BiggerCheckBox();
            this.chkTuoi = new GUI.MyCustom.BiggerCheckBox();
            this.txtTuoiStart = new GUI.MyCustom.RJTextBox();
            this.txtTuoiEnd = new GUI.MyCustom.RJTextBox();
            this.chkDiemTL = new GUI.MyCustom.BiggerCheckBox();
            this.txtDiemTLStart = new GUI.MyCustom.RJTextBox();
            this.txtDiemTLEnd = new GUI.MyCustom.RJTextBox();
            this.chkTrangThai = new GUI.MyCustom.BiggerCheckBox();
            this.chkHoatDong = new GUI.MyCustom.BiggerCheckBox();
            this.chkKoHD = new GUI.MyCustom.BiggerCheckBox();
            this.txtMaNCC = new GUI.MyCustom.RJTextBox();
            this.txtHo = new GUI.MyCustom.RJTextBox();
            this.txtDiaChi = new GUI.MyCustom.RJTextBox();
            this.txtSoDT = new GUI.MyCustom.RJTextBox();
            this.txtSoFax = new GUI.MyCustom.RJTextBox();
            this.btnFolder = new GUI.MyCustom.RJButton();
            this.rjTextBox1 = new GUI.MyCustom.RJTextBox();
            this.btnImport = new GUI.MyCustom.RJButton();
            this.btnExport = new GUI.MyCustom.RJButton();
=======
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SdtNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNCC = new GUI.MyCustom.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTen = new GUI.MyCustom.RJTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new GUI.MyCustom.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDT = new GUI.MyCustom.RJTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoFax = new GUI.MyCustom.RJTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFolder = new GUI.MyCustom.RJButton();
            this.txtNameFile = new GUI.MyCustom.RJTextBox();
            this.btnImport = new GUI.MyCustom.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExport = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
>>>>>>> Stashed changes
            this.btnThem = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
<<<<<<< Updated upstream
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flpFilter.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
=======
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.flpFilter.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
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
            this.chkGioiTinh.Location = new System.Drawing.Point(3, 3);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Padding = new System.Windows.Forms.Padding(10);
            this.chkGioiTinh.Size = new System.Drawing.Size(24, 29);
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
            this.label12.Location = new System.Drawing.Point(33, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 28);
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
            this.chkNam.Location = new System.Drawing.Point(128, 3);
            this.chkNam.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkNam.Name = "chkNam";
            this.chkNam.Padding = new System.Windows.Forms.Padding(10);
            this.chkNam.Size = new System.Drawing.Size(24, 29);
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
            this.label21.Location = new System.Drawing.Point(156, 4);
            this.label21.Margin = new System.Windows.Forms.Padding(4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 28);
            this.label21.TabIndex = 6;
            this.label21.Text = "Nam";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 797);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Controls.Add(this.flpFilter);
            this.panel3.Location = new System.Drawing.Point(316, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 754);
            this.panel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(974, 50);
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
            this.cbxTimKiem.Location = new System.Drawing.Point(4, 8);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.cbxTimKiem.Size = new System.Drawing.Size(108, 30);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "Mã NCC";
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
            this.txtTimKiem.Size = new System.Drawing.Size(730, 32);
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
            this.btnTimKiem.Location = new System.Drawing.Point(857, 8);
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
            this.btnFilter.Location = new System.Drawing.Point(904, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(44, 36);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
>>>>>>> Stashed changes
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AllowUserToResizeColumns = false;
            this.dgvKhachHang.AllowUserToResizeRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.ColumnHeadersHeight = 28;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
<<<<<<< Updated upstream
            this.DiaChi,
            this.SoDT,
=======
            this.SdtNV,
            this.DiaChiNV,
>>>>>>> Stashed changes
            this.SoFax});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.Color.Black;
<<<<<<< Updated upstream
            this.dgvKhachHang.Location = new System.Drawing.Point(7, 76);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.dgvKhachHang.Location = new System.Drawing.Point(5, 62);
>>>>>>> Stashed changes
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKhachHang.RowTemplate.Height = 30;
            this.dgvKhachHang.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
<<<<<<< Updated upstream
            this.dgvKhachHang.Size = new System.Drawing.Size(1299, 841);
            this.dgvKhachHang.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(395, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(194, 137);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(159, 34);
            this.label28.TabIndex = 22;
            this.label28.Text = "Hoạt động";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(411, 928);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaNCC);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtHo);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtDiaChi);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtSoDT);
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.txtSoFax);
            this.flowLayoutPanel2.Controls.Add(this.label20);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.btnFolder);
            this.flowLayoutPanel2.Controls.Add(this.rjTextBox1);
            this.flowLayoutPanel2.Controls.Add(this.btnImport);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.btnExport);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 112);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 737);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NCC";
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
            this.label13.Size = new System.Drawing.Size(336, 21);
            this.label13.TabIndex = 21;
            this.label13.Text = "* Bạn phải nhập Mã NV";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
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
            this.label14.Size = new System.Drawing.Size(336, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "* Bạn phải nhập Mã NV";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(5, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 34);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ ";
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
            this.label15.Size = new System.Drawing.Size(336, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "* Bạn phải nhập Mã NV";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(5, 200);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.label18.Size = new System.Drawing.Size(336, 21);
            this.label18.TabIndex = 25;
            this.label18.Text = "* Bạn phải nhập Mã NV";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(5, 265);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 34);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số Fax";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(11, 859);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(387, 55);
            this.flowLayoutPanel3.TabIndex = 1;
=======
            this.dgvKhachHang.Size = new System.Drawing.Size(974, 683);
            this.dgvKhachHang.TabIndex = 1;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.Frozen = true;
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 80;
            // 
            // TenNCC
            // 
            this.TenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            this.TenNCC.Width = 120;
            // 
            // SdtNV
            // 
            this.SdtNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SdtNV.DataPropertyName = "SdtNV";
            this.SdtNV.HeaderText = "Số DT";
            this.SdtNV.MinimumWidth = 6;
            this.SdtNV.Name = "SdtNV";
            this.SdtNV.ReadOnly = true;
            this.SdtNV.Width = 69;
            // 
            // DiaChiNV
            // 
            this.DiaChiNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChiNV.DataPropertyName = "DiaChiNV";
            this.DiaChiNV.HeaderText = "Địa chỉ";
            this.DiaChiNV.MinimumWidth = 6;
            this.DiaChiNV.Name = "DiaChiNV";
            this.DiaChiNV.ReadOnly = true;
            // 
            // SoFax
            // 
            this.SoFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoFax.DataPropertyName = "SoFax";
            this.SoFax.HeaderText = "Số Fax";
            this.SoFax.MinimumWidth = 6;
            this.SoFax.Name = "SoFax";
            this.SoFax.ReadOnly = true;
            this.SoFax.Width = 71;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.flpFilter.Location = new System.Drawing.Point(901, 68);
            this.flpFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(385, 226);
            this.flpFilter.TabIndex = 3;
            this.flpFilter.Visible = false;
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
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label21.Location = new System.Drawing.Point(207, 5);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 34);
            this.label21.TabIndex = 6;
            this.label21.Text = "Nam";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label22.Location = new System.Drawing.Point(318, 5);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 34);
            this.label22.TabIndex = 7;
            this.label22.Text = "Nữ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label29.Location = new System.Drawing.Point(170, 181);
            this.label29.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(196, 34);
            this.label29.TabIndex = 23;
            this.label29.Text = "Không hoạt động";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(7, 7);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1298, 61);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.dgvKhachHang);
            this.panel3.Controls.Add(this.flpFilter);
            this.panel3.Location = new System.Drawing.Point(421, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1314, 928);
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1845, 951);
            this.panel1.TabIndex = 2;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label20.Location = new System.Drawing.Point(4, 304);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label20.Size = new System.Drawing.Size(336, 21);
            this.label20.TabIndex = 26;
            this.label20.Text = "* Bạn phải nhập Mã NV";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(5, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 163);
            this.label5.TabIndex = 27;
            this.label5.Text = "  Import file Excel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(5, 582);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 34);
            this.label6.TabIndex = 31;
            this.label6.Text = "                           Export file Excel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label9.Location = new System.Drawing.Point(4, 556);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 27, 0);
            this.label9.Size = new System.Drawing.Size(262, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "* Bạn chọn file ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cbxTimKiem.Texts = "Mã NCC";
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
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(9);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.Size = new System.Drawing.Size(973, 41);
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
            this.btnTimKiem.Location = new System.Drawing.Point(1141, 10);
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
            this.btnFilter.Location = new System.Drawing.Point(1204, 10);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(20, 10, 13, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(59, 46);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
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
=======
            this.flpFilter.Location = new System.Drawing.Point(676, 55);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(289, 184);
            this.flpFilter.TabIndex = 3;
            this.flpFilter.Visible = false;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.chkNu.Location = new System.Drawing.Point(281, 4);
            this.chkNu.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.chkNu.Name = "chkNu";
            this.chkNu.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkNu.Size = new System.Drawing.Size(32, 36);
=======
            this.chkNu.Location = new System.Drawing.Point(212, 3);
            this.chkNu.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkNu.Name = "chkNu";
            this.chkNu.Padding = new System.Windows.Forms.Padding(10);
            this.chkNu.Size = new System.Drawing.Size(24, 29);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label22.Location = new System.Drawing.Point(240, 4);
            this.label22.Margin = new System.Windows.Forms.Padding(4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 28);
            this.label22.TabIndex = 7;
            this.label22.Text = "Nữ";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.chkTuoi.Location = new System.Drawing.Point(4, 48);
            this.chkTuoi.Margin = new System.Windows.Forms.Padding(4);
            this.chkTuoi.Name = "chkTuoi";
            this.chkTuoi.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkTuoi.Size = new System.Drawing.Size(32, 36);
=======
            this.chkTuoi.Location = new System.Drawing.Point(3, 39);
            this.chkTuoi.Name = "chkTuoi";
            this.chkTuoi.Padding = new System.Windows.Forms.Padding(10);
            this.chkTuoi.Size = new System.Drawing.Size(24, 29);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label23.Location = new System.Drawing.Point(33, 40);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 28);
            this.label23.TabIndex = 8;
            this.label23.Text = "Tuổi:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.txtTuoiStart.Location = new System.Drawing.Point(158, 49);
            this.txtTuoiStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtTuoiStart.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtTuoiStart.Multiline = false;
            this.txtTuoiStart.Name = "txtTuoiStart";
            this.txtTuoiStart.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtTuoiStart.PasswordChar = false;
            this.txtTuoiStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTuoiStart.PlaceholderText = "Từ";
            this.txtTuoiStart.Size = new System.Drawing.Size(79, 34);
=======
            this.txtTuoiStart.Location = new System.Drawing.Point(119, 40);
            this.txtTuoiStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuoiStart.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtTuoiStart.Multiline = false;
            this.txtTuoiStart.Name = "txtTuoiStart";
            this.txtTuoiStart.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtTuoiStart.PasswordChar = false;
            this.txtTuoiStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTuoiStart.PlaceholderText = "Từ";
            this.txtTuoiStart.Size = new System.Drawing.Size(59, 28);
>>>>>>> Stashed changes
            this.txtTuoiStart.TabIndex = 10;
            this.txtTuoiStart.Texts = "";
            this.txtTuoiStart.UnderlinedStyle = false;
            // 
<<<<<<< Updated upstream
=======
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label24.Location = new System.Drawing.Point(185, 40);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 28);
            this.label24.TabIndex = 12;
            this.label24.Text = "-";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.txtTuoiEnd.Location = new System.Drawing.Point(273, 49);
            this.txtTuoiEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtTuoiEnd.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtTuoiEnd.Multiline = false;
            this.txtTuoiEnd.Name = "txtTuoiEnd";
            this.txtTuoiEnd.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtTuoiEnd.PasswordChar = false;
            this.txtTuoiEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTuoiEnd.PlaceholderText = "Đến";
            this.txtTuoiEnd.Size = new System.Drawing.Size(79, 34);
=======
            this.txtTuoiEnd.Location = new System.Drawing.Point(206, 40);
            this.txtTuoiEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuoiEnd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtTuoiEnd.Multiline = false;
            this.txtTuoiEnd.Name = "txtTuoiEnd";
            this.txtTuoiEnd.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtTuoiEnd.PasswordChar = false;
            this.txtTuoiEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTuoiEnd.PlaceholderText = "Đến";
            this.txtTuoiEnd.Size = new System.Drawing.Size(59, 28);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.chkDiemTL.Location = new System.Drawing.Point(4, 92);
            this.chkDiemTL.Margin = new System.Windows.Forms.Padding(4);
            this.chkDiemTL.Name = "chkDiemTL";
            this.chkDiemTL.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkDiemTL.Size = new System.Drawing.Size(32, 36);
=======
            this.chkDiemTL.Location = new System.Drawing.Point(3, 75);
            this.chkDiemTL.Name = "chkDiemTL";
            this.chkDiemTL.Padding = new System.Windows.Forms.Padding(10);
            this.chkDiemTL.Size = new System.Drawing.Size(24, 29);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label25.Location = new System.Drawing.Point(33, 76);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 28);
            this.label25.TabIndex = 13;
            this.label25.Text = "Điểm TL:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.txtDiemTLStart.Location = new System.Drawing.Point(158, 93);
            this.txtDiemTLStart.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiemTLStart.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtDiemTLStart.Multiline = false;
            this.txtDiemTLStart.Name = "txtDiemTLStart";
            this.txtDiemTLStart.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtDiemTLStart.PasswordChar = false;
            this.txtDiemTLStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDiemTLStart.PlaceholderText = "Từ";
            this.txtDiemTLStart.Size = new System.Drawing.Size(79, 34);
=======
            this.txtDiemTLStart.Location = new System.Drawing.Point(119, 76);
            this.txtDiemTLStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTLStart.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtDiemTLStart.Multiline = false;
            this.txtDiemTLStart.Name = "txtDiemTLStart";
            this.txtDiemTLStart.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtDiemTLStart.PasswordChar = false;
            this.txtDiemTLStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDiemTLStart.PlaceholderText = "Từ";
            this.txtDiemTLStart.Size = new System.Drawing.Size(59, 28);
>>>>>>> Stashed changes
            this.txtDiemTLStart.TabIndex = 15;
            this.txtDiemTLStart.Texts = "";
            this.txtDiemTLStart.UnderlinedStyle = false;
            // 
<<<<<<< Updated upstream
=======
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label26.Location = new System.Drawing.Point(185, 76);
            this.label26.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 28);
            this.label26.TabIndex = 17;
            this.label26.Text = "-";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.txtDiemTLEnd.Location = new System.Drawing.Point(273, 93);
            this.txtDiemTLEnd.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiemTLEnd.MinimumSize = new System.Drawing.Size(0, 34);
            this.txtDiemTLEnd.Multiline = false;
            this.txtDiemTLEnd.Name = "txtDiemTLEnd";
            this.txtDiemTLEnd.Padding = new System.Windows.Forms.Padding(11, 5, 3, 2);
            this.txtDiemTLEnd.PasswordChar = false;
            this.txtDiemTLEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDiemTLEnd.PlaceholderText = "Đến";
            this.txtDiemTLEnd.Size = new System.Drawing.Size(79, 34);
=======
            this.txtDiemTLEnd.Location = new System.Drawing.Point(206, 76);
            this.txtDiemTLEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiemTLEnd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtDiemTLEnd.Multiline = false;
            this.txtDiemTLEnd.Name = "txtDiemTLEnd";
            this.txtDiemTLEnd.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtDiemTLEnd.PasswordChar = false;
            this.txtDiemTLEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDiemTLEnd.PlaceholderText = "Đến";
            this.txtDiemTLEnd.Size = new System.Drawing.Size(59, 28);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.chkTrangThai.Location = new System.Drawing.Point(4, 136);
            this.chkTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkTrangThai.Size = new System.Drawing.Size(32, 36);
=======
            this.chkTrangThai.Location = new System.Drawing.Point(3, 111);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Padding = new System.Windows.Forms.Padding(10);
            this.chkTrangThai.Size = new System.Drawing.Size(24, 29);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label27.Location = new System.Drawing.Point(33, 112);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 28);
            this.label27.TabIndex = 18;
            this.label27.Text = "T.Thái:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.chkHoatDong.Location = new System.Drawing.Point(157, 136);
            this.chkHoatDong.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkHoatDong.Size = new System.Drawing.Size(32, 36);
=======
            this.chkHoatDong.Location = new System.Drawing.Point(118, 111);
            this.chkHoatDong.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Padding = new System.Windows.Forms.Padding(10);
            this.chkHoatDong.Size = new System.Drawing.Size(24, 29);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label28.Location = new System.Drawing.Point(146, 112);
            this.label28.Margin = new System.Windows.Forms.Padding(4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(119, 28);
            this.label28.TabIndex = 22;
            this.label28.Text = "Hoạt động";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.chkKoHD.Location = new System.Drawing.Point(133, 180);
            this.chkKoHD.Margin = new System.Windows.Forms.Padding(133, 4, 0, 4);
            this.chkKoHD.Name = "chkKoHD";
            this.chkKoHD.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.chkKoHD.Size = new System.Drawing.Size(32, 36);
=======
            this.chkKoHD.Location = new System.Drawing.Point(100, 147);
            this.chkKoHD.Margin = new System.Windows.Forms.Padding(100, 3, 0, 3);
            this.chkKoHD.Name = "chkKoHD";
            this.chkKoHD.Padding = new System.Windows.Forms.Padding(10);
            this.chkKoHD.Size = new System.Drawing.Size(24, 29);
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label29.Location = new System.Drawing.Point(128, 148);
            this.label29.Margin = new System.Windows.Forms.Padding(4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(147, 28);
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
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 754);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(296, 119);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN NHÀ CUNG CẤP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaNCC);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtTen);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtDiaChi);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtSoDT);
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.txtSoFax);
            this.flowLayoutPanel2.Controls.Add(this.label19);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.btnFolder);
            this.flowLayoutPanel2.Controls.Add(this.txtNameFile);
            this.flowLayoutPanel2.Controls.Add(this.btnImport);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.btnExport);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 127);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(290, 560);
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
            this.label2.Text = "Mã NCC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
>>>>>>> Stashed changes
            // txtMaNCC
            // 
            this.txtMaNCC.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaNCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaNCC.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaNCC.BorderRadius = 0;
            this.txtMaNCC.BorderSize = 2;
            this.txtMaNCC.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.ForeColor = System.Drawing.Color.Black;
<<<<<<< Updated upstream
            this.txtMaNCC.Location = new System.Drawing.Point(140, 5);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaNCC.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtMaNCC.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtMaNCC.Multiline = false;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Padding = new System.Windows.Forms.Padding(3, 5, 3, 2);
            this.txtMaNCC.PasswordChar = false;
            this.txtMaNCC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNCC.PlaceholderText = "";
            this.txtMaNCC.Size = new System.Drawing.Size(228, 34);
=======
            this.txtMaNCC.Location = new System.Drawing.Point(106, 4);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNCC.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtMaNCC.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaNCC.Multiline = false;
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtMaNCC.PasswordChar = false;
            this.txtMaNCC.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNCC.PlaceholderText = "";
            this.txtMaNCC.Size = new System.Drawing.Size(171, 28);
>>>>>>> Stashed changes
            this.txtMaNCC.TabIndex = 1;
            this.txtMaNCC.Texts = "";
            this.txtMaNCC.UnderlinedStyle = false;
            // 
<<<<<<< Updated upstream
            // txtHo
            // 
            this.txtHo.BackColor = System.Drawing.SystemColors.Window;
            this.txtHo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtHo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtHo.BorderRadius = 0;
            this.txtHo.BorderSize = 2;
            this.txtHo.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHo.ForeColor = System.Drawing.Color.DimGray;
            this.txtHo.Location = new System.Drawing.Point(140, 70);
            this.txtHo.Margin = new System.Windows.Forms.Padding(5);
            this.txtHo.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtHo.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtHo.Multiline = false;
            this.txtHo.Name = "txtHo";
            this.txtHo.Padding = new System.Windows.Forms.Padding(9);
            this.txtHo.PasswordChar = false;
            this.txtHo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHo.PlaceholderText = "";
            this.txtHo.Size = new System.Drawing.Size(228, 34);
            this.txtHo.TabIndex = 3;
            this.txtHo.Texts = "";
            this.txtHo.UnderlinedStyle = false;
=======
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label13.Size = new System.Drawing.Size(252, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "* Bạn phải nhập Mã NCC";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.SystemColors.Window;
            this.txtTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTen.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTen.BorderRadius = 0;
            this.txtTen.BorderSize = 2;
            this.txtTen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.DimGray;
            this.txtTen.Location = new System.Drawing.Point(106, 57);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtTen.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTen.Multiline = false;
            this.txtTen.Name = "txtTen";
            this.txtTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtTen.PasswordChar = false;
            this.txtTen.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTen.PlaceholderText = "";
            this.txtTen.Size = new System.Drawing.Size(171, 28);
            this.txtTen.TabIndex = 3;
            this.txtTen.Texts = "";
            this.txtTen.UnderlinedStyle = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label14.Size = new System.Drawing.Size(252, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "* Bạn phải nhập Mã NCC";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(4, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
>>>>>>> Stashed changes
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDiaChi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtDiaChi.BorderRadius = 0;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.DimGray;
<<<<<<< Updated upstream
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
            this.txtDiaChi.Size = new System.Drawing.Size(228, 34);
=======
            this.txtDiaChi.Location = new System.Drawing.Point(106, 110);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtDiaChi.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(171, 28);
>>>>>>> Stashed changes
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
<<<<<<< Updated upstream
=======
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label15.Location = new System.Drawing.Point(3, 142);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label15.Size = new System.Drawing.Size(252, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "* Bạn phải nhập Mã NCC";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(4, 163);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số ĐT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtSoDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtSoDT.BorderRadius = 0;
            this.txtSoDT.BorderSize = 2;
            this.txtSoDT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.DimGray;
<<<<<<< Updated upstream
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
            this.txtSoDT.Size = new System.Drawing.Size(228, 34);
=======
            this.txtSoDT.Location = new System.Drawing.Point(106, 163);
            this.txtSoDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDT.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtSoDT.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtSoDT.Multiline = false;
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoDT.PasswordChar = false;
            this.txtSoDT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoDT.PlaceholderText = "";
            this.txtSoDT.Size = new System.Drawing.Size(171, 28);
>>>>>>> Stashed changes
            this.txtSoDT.TabIndex = 11;
            this.txtSoDT.Texts = "";
            this.txtSoDT.UnderlinedStyle = false;
            // 
<<<<<<< Updated upstream
=======
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label18.Location = new System.Drawing.Point(3, 195);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label18.Size = new System.Drawing.Size(252, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "* Bạn phải nhập Mã NCC";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(4, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Số Fax";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
>>>>>>> Stashed changes
            // txtSoFax
            // 
            this.txtSoFax.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoFax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtSoFax.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtSoFax.BorderRadius = 0;
            this.txtSoFax.BorderSize = 2;
            this.txtSoFax.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoFax.ForeColor = System.Drawing.Color.DimGray;
<<<<<<< Updated upstream
            this.txtSoFax.Location = new System.Drawing.Point(140, 265);
            this.txtSoFax.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoFax.MaximumSize = new System.Drawing.Size(228, 34);
            this.txtSoFax.MinimumSize = new System.Drawing.Size(200, 34);
            this.txtSoFax.Multiline = false;
            this.txtSoFax.Name = "txtSoFax";
            this.txtSoFax.Padding = new System.Windows.Forms.Padding(9);
            this.txtSoFax.PasswordChar = false;
            this.txtSoFax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoFax.PlaceholderText = "";
            this.txtSoFax.Size = new System.Drawing.Size(228, 34);
=======
            this.txtSoFax.Location = new System.Drawing.Point(106, 216);
            this.txtSoFax.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoFax.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtSoFax.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtSoFax.Multiline = false;
            this.txtSoFax.Name = "txtSoFax";
            this.txtSoFax.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoFax.PasswordChar = false;
            this.txtSoFax.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoFax.PlaceholderText = "";
            this.txtSoFax.Size = new System.Drawing.Size(171, 28);
>>>>>>> Stashed changes
            this.txtSoFax.TabIndex = 13;
            this.txtSoFax.Texts = "";
            this.txtSoFax.UnderlinedStyle = false;
            // 
<<<<<<< Updated upstream
=======
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label19.Location = new System.Drawing.Point(3, 252);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label19.Size = new System.Drawing.Size(252, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "* Bạn phải nhập Mã NCC";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 269);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label5.Size = new System.Drawing.Size(274, 63);
            this.label5.TabIndex = 30;
            this.label5.Text = "     Import file excel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
>>>>>>> Stashed changes
            // btnFolder
            // 
            this.btnFolder.AutoSize = true;
            this.btnFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnFolder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnFolder.BorderRadius = 0;
            this.btnFolder.BorderSize = 2;
            this.btnFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.ForeColor = System.Drawing.Color.White;
            this.btnFolder.Image = global::GUI.Properties.Resources.icons8_folder_32;
<<<<<<< Updated upstream
            this.btnFolder.Location = new System.Drawing.Point(20, 503);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(20, 5, 5, 5);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(59, 48);
            this.btnFolder.TabIndex = 28;
            this.btnFolder.TextColor = System.Drawing.Color.White;
            this.btnFolder.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(89, 503);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.rjTextBox1.MaximumSize = new System.Drawing.Size(228, 48);
            this.rjTextBox1.MinimumSize = new System.Drawing.Size(200, 48);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(9);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(200, 48);
            this.rjTextBox1.TabIndex = 29;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
=======
            this.btnFolder.Location = new System.Drawing.Point(15, 340);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(44, 46);
            this.btnFolder.TabIndex = 31;
            this.btnFolder.TextColor = System.Drawing.Color.White;
            this.btnFolder.UseVisualStyleBackColor = false;
            // 
            // txtNameFile
            // 
            this.txtNameFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtNameFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtNameFile.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtNameFile.BorderRadius = 0;
            this.txtNameFile.BorderSize = 2;
            this.txtNameFile.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFile.ForeColor = System.Drawing.Color.DimGray;
            this.txtNameFile.Location = new System.Drawing.Point(73, 340);
            this.txtNameFile.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txtNameFile.MaximumSize = new System.Drawing.Size(171, 42);
            this.txtNameFile.MinimumSize = new System.Drawing.Size(100, 42);
            this.txtNameFile.Multiline = false;
            this.txtNameFile.Name = "txtNameFile";
            this.txtNameFile.Padding = new System.Windows.Forms.Padding(7);
            this.txtNameFile.PasswordChar = false;
            this.txtNameFile.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNameFile.PlaceholderText = "";
            this.txtNameFile.Size = new System.Drawing.Size(122, 42);
            this.txtNameFile.TabIndex = 32;
            this.txtNameFile.Texts = "";
            this.txtNameFile.UnderlinedStyle = false;
>>>>>>> Stashed changes
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
            this.btnImport.Image = global::GUI.Properties.Resources.icons8_import_32_;
<<<<<<< Updated upstream
            this.btnImport.Location = new System.Drawing.Point(299, 503);
            this.btnImport.Margin = new System.Windows.Forms.Padding(5);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(59, 48);
            this.btnImport.TabIndex = 30;
            this.btnImport.TextColor = System.Drawing.Color.White;
            this.btnImport.UseVisualStyleBackColor = false;
            // 
=======
            this.btnImport.Location = new System.Drawing.Point(214, 340);
            this.btnImport.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(44, 46);
            this.btnImport.TabIndex = 33;
            this.btnImport.TextColor = System.Drawing.Color.White;
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(3, 386);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label6.Size = new System.Drawing.Size(274, 36);
            this.label6.TabIndex = 34;
            this.label6.Text = "     Export file excel";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
>>>>>>> Stashed changes
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
            this.btnExport.Image = global::GUI.Properties.Resources.icons8_export_32;
<<<<<<< Updated upstream
            this.btnExport.Location = new System.Drawing.Point(160, 626);
            this.btnExport.Margin = new System.Windows.Forms.Padding(160, 5, 5, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(59, 48);
            this.btnExport.TabIndex = 32;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
=======
            this.btnExport.Location = new System.Drawing.Point(120, 430);
            this.btnExport.Margin = new System.Windows.Forms.Padding(120, 8, 10, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(44, 46);
            this.btnExport.TabIndex = 35;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 695);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(290, 45);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.btnThem.Location = new System.Drawing.Point(31, 4);
            this.btnThem.Margin = new System.Windows.Forms.Padding(31, 4, 13, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 49);
=======
            this.btnThem.Location = new System.Drawing.Point(23, 3);
            this.btnThem.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(44, 40);
>>>>>>> Stashed changes
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "rjButton2";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
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
<<<<<<< Updated upstream
            this.btnSua.Location = new System.Drawing.Point(116, 4);
            this.btnSua.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 49);
=======
            this.btnSua.Location = new System.Drawing.Point(87, 3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(44, 40);
>>>>>>> Stashed changes
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "rjButton3";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
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
<<<<<<< Updated upstream
            this.btnXoa.Location = new System.Drawing.Point(201, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(59, 49);
=======
            this.btnXoa.Location = new System.Drawing.Point(151, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(44, 40);
>>>>>>> Stashed changes
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "rjButton4";
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.UseVisualStyleBackColor = false;
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
<<<<<<< Updated upstream
            this.btnReset.Location = new System.Drawing.Point(286, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(13, 4, 13, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 49);
=======
            this.btnReset.Location = new System.Drawing.Point(215, 3);
            this.btnReset.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 40);
>>>>>>> Stashed changes
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "rjButton5";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
<<<<<<< Updated upstream
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.Frozen = true;
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 152;
            // 
            // TenNCC
            // 
            this.TenNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            this.TenNCC.Width = 200;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 300;
            // 
            // SoDT
            // 
            this.SoDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoDT.DataPropertyName = "SoDT";
            this.SoDT.HeaderText = "Số DT";
            this.SoDT.MinimumWidth = 6;
            this.SoDT.Name = "SoDT";
            this.SoDT.ReadOnly = true;
            this.SoDT.Width = 200;
            // 
            // SoFax
            // 
            this.SoFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoFax.HeaderText = "Số Fax";
            this.SoFax.MinimumWidth = 6;
            this.SoFax.Name = "SoFax";
            this.SoFax.ReadOnly = true;
            this.SoFax.Width = 120;
            // 
            // NhaCCGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1845, 951);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhaCCGUI";
            this.Text = "NhaCCGUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
=======
            // NhaCCGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 797);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhaCCGUI";
            this.Text = "NhaCCGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.flpFilter.ResumeLayout(false);
>>>>>>> Stashed changes
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
<<<<<<< Updated upstream
            this.flpFilter.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
=======
>>>>>>> Stashed changes
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< Updated upstream

        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label1;
=======
        private MyCustom.BiggerCheckBox chkGioiTinh;
        private System.Windows.Forms.Label label12;
        private MyCustom.RJButton btnFilter;
        private MyCustom.BiggerCheckBox chkNam;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkNu;
        private System.Windows.Forms.Label label22;
        private MyCustom.BiggerCheckBox chkTuoi;
        private System.Windows.Forms.Label label23;
>>>>>>> Stashed changes
        private MyCustom.RJTextBox txtTuoiStart;
        private System.Windows.Forms.Label label24;
        private MyCustom.RJTextBox txtTuoiEnd;
        private MyCustom.BiggerCheckBox chkDiemTL;
        private System.Windows.Forms.Label label25;
        private MyCustom.RJTextBox txtDiemTLStart;
        private System.Windows.Forms.Label label26;
        private MyCustom.RJTextBox txtDiemTLEnd;
<<<<<<< Updated upstream
        private System.Windows.Forms.Label label27;
        private MyCustom.BiggerCheckBox chkHoatDong;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
=======
        private MyCustom.BiggerCheckBox chkTrangThai;
        private System.Windows.Forms.Label label27;
        private MyCustom.BiggerCheckBox chkHoatDong;
        private System.Windows.Forms.Label label28;
        private MyCustom.BiggerCheckBox chkKoHD;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
>>>>>>> Stashed changes
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaNCC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
<<<<<<< Updated upstream
        private MyCustom.RJTextBox txtHo;
=======
        private MyCustom.RJTextBox txtTen;
>>>>>>> Stashed changes
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtDiaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJTextBox txtSoDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label8;
        private MyCustom.RJTextBox txtSoFax;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Label label19;
>>>>>>> Stashed changes
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.RJButton btnThem;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
<<<<<<< Updated upstream
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkGioiTinh;
        private System.Windows.Forms.Label label12;
        private MyCustom.BiggerCheckBox chkNam;
        private System.Windows.Forms.Label label21;
        private MyCustom.BiggerCheckBox chkNu;
        private System.Windows.Forms.Label label22;
        private MyCustom.BiggerCheckBox chkTuoi;
        private System.Windows.Forms.Label label23;
        private MyCustom.BiggerCheckBox chkTrangThai;
        private MyCustom.BiggerCheckBox chkKoHD;
        private System.Windows.Forms.Label label29;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private MyCustom.RJButton btnFolder;
        private MyCustom.RJTextBox rjTextBox1;
        private MyCustom.RJButton btnImport;
        private System.Windows.Forms.Label label9;
=======
        private System.Windows.Forms.Label label5;
        private MyCustom.RJButton btnFolder;
        private MyCustom.RJTextBox txtNameFile;
        private MyCustom.RJButton btnImport;
>>>>>>> Stashed changes
        private System.Windows.Forms.Label label6;
        private MyCustom.RJButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
<<<<<<< Updated upstream
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn SdtNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNV;
>>>>>>> Stashed changes
        private System.Windows.Forms.DataGridViewTextBoxColumn SoFax;
    }
}