namespace GUI
{
    partial class KhuyenMaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMaiGUI));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieuKienKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.btnThongTinKM = new GUI.MyCustom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXemChiTietKM = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.chkTuoi = new GUI.MyCustom.BiggerCheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.rjDatePicker1 = new GUI.MyCustom.RJDatePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.rjDatePicker2 = new GUI.MyCustom.RJDatePicker();
            this.chkTrangThai = new GUI.MyCustom.BiggerCheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.chkHoatDong = new GUI.MyCustom.BiggerCheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.chkKoHD = new GUI.MyCustom.BiggerCheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMaKM = new GUI.MyCustom.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenKm = new GUI.MyCustom.RJTextBox();
            this.dtpNgayBD = new GUI.MyCustom.RJDatePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayKT = new GUI.MyCustom.RJDatePicker();
            this.txtPhanTramKM = new GUI.MyCustom.RJTextBox();
            this.txtDkKM = new GUI.MyCustom.RJTextBox();
            this.cbxTrangThai = new GUI.MyCustom.RJComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flpFilter.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã KM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(4, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên KM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label4.Size = new System.Drawing.Size(256, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "* Bạn phải nhập Tên KM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(4, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ngày BĐ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(4, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ngày KT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label8.Location = new System.Drawing.Point(3, 201);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label8.Size = new System.Drawing.Size(299, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "* Ngày kết thúc không được nhỏ hơn ngày bắt đầu";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(4, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 31;
            this.label9.Text = "% KM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label10.Location = new System.Drawing.Point(3, 256);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label10.Size = new System.Drawing.Size(256, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "* Bạn phải nhập % KM";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(4, 279);
            this.label11.Margin = new System.Windows.Forms.Padding(4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 28);
            this.label11.TabIndex = 34;
            this.label11.Text = "Điều Kiện KM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label12.Location = new System.Drawing.Point(3, 311);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label12.Size = new System.Drawing.Size(243, 19);
            this.label12.TabIndex = 36;
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label14.Location = new System.Drawing.Point(4, 334);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 28);
            this.label14.TabIndex = 37;
            this.label14.Text = "Trạng thái";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label1.Size = new System.Drawing.Size(333, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHUYẾN MÃI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            this.dgvKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvKhuyenMai.AllowUserToResizeColumns = false;
            this.dgvKhuyenMai.AllowUserToResizeRows = false;
            this.dgvKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvKhuyenMai.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhuyenMai.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhuyenMai.ColumnHeadersHeight = 28;
            this.dgvKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.TenKM,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.PhanTramKm,
            this.DieuKienKM,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhuyenMai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhuyenMai.EnableHeadersVisualStyles = false;
            this.dgvKhuyenMai.GridColor = System.Drawing.Color.Black;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(5, 60);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKhuyenMai.RowTemplate.Height = 30;
            this.dgvKhuyenMai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(813, 687);
            this.dgvKhuyenMai.TabIndex = 1;
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            this.dgvKhuyenMai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKhuyenMai_CellFormatting);
            // 
            // MaKM
            // 
            this.MaKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaKM.DataPropertyName = "MaKM";
            this.MaKM.Frozen = true;
            this.MaKM.HeaderText = "Mã KM";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.ReadOnly = true;
            this.MaKM.Width = 60;
            // 
            // TenKM
            // 
            this.TenKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenKM.DataPropertyName = "TenKM";
            this.TenKM.HeaderText = "Tên KM";
            this.TenKM.MinimumWidth = 6;
            this.TenKM.Name = "TenKM";
            this.TenKM.ReadOnly = true;
            this.TenKM.Width = 193;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            this.NgayBatDau.Width = 115;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 115;
            // 
            // PhanTramKm
            // 
            this.PhanTramKm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhanTramKm.DataPropertyName = "PhanTramKm";
            this.PhanTramKm.HeaderText = "Phần trăm KM";
            this.PhanTramKm.MinimumWidth = 6;
            this.PhanTramKm.Name = "PhanTramKm";
            this.PhanTramKm.ReadOnly = true;
            this.PhanTramKm.Width = 105;
            // 
            // DieuKienKM
            // 
            this.DieuKienKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DieuKienKM.DataPropertyName = "DieuKienKM";
            this.DieuKienKM.HeaderText = "Điều kiện KM";
            this.DieuKienKM.MinimumWidth = 6;
            this.DieuKienKM.Name = "DieuKienKM";
            this.DieuKienKM.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 123;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Controls.Add(this.btnThongTinKM);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 423);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(327, 45);
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
            this.btnThem.Location = new System.Drawing.Point(10, 3);
            this.btnThem.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
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
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = global::GUI.Properties.Resources.icons8_update_24;
            this.btnSua.Location = new System.Drawing.Point(74, 3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(44, 40);
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
            this.btnXoa.Location = new System.Drawing.Point(138, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(44, 40);
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
            this.btnReset.Location = new System.Drawing.Point(202, 3);
            this.btnReset.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThongTinKM
            // 
            this.btnThongTinKM.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTinKM.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThongTinKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnThongTinKM.BorderRadius = 20;
            this.btnThongTinKM.BorderSize = 2;
            this.btnThongTinKM.FlatAppearance.BorderSize = 0;
            this.btnThongTinKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinKM.ForeColor = System.Drawing.Color.White;
            this.btnThongTinKM.Image = ((System.Drawing.Image)(resources.GetObject("btnThongTinKM.Image")));
            this.btnThongTinKM.Location = new System.Drawing.Point(266, 3);
            this.btnThongTinKM.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnThongTinKM.Name = "btnThongTinKM";
            this.btnThongTinKM.Size = new System.Drawing.Size(44, 40);
            this.btnThongTinKM.TabIndex = 4;
            this.btnThongTinKM.TextColor = System.Drawing.Color.White;
            this.btnThongTinKM.UseVisualStyleBackColor = false;
            this.btnThongTinKM.Click += new System.EventHandler(this.btnThongTinKM_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnXemChiTietKM);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 763);
            this.panel1.TabIndex = 2;
            // 
            // btnXemChiTietKM
            // 
            this.btnXemChiTietKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietKM.Location = new System.Drawing.Point(214, 511);
            this.btnXemChiTietKM.Name = "btnXemChiTietKM";
            this.btnXemChiTietKM.Size = new System.Drawing.Size(75, 28);
            this.btnXemChiTietKM.TabIndex = 6;
            this.btnXemChiTietKM.Text = "Xem";
            this.btnXemChiTietKM.UseVisualStyleBackColor = true;
            this.btnXemChiTietKM.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label15.Location = new System.Drawing.Point(4, 511);
            this.label15.Margin = new System.Windows.Forms.Padding(4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 28);
            this.label15.TabIndex = 5;
            this.label15.Text = "Thông tin sản phẩm KM";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flpFilter);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.dgvKhuyenMai);
            this.panel3.Location = new System.Drawing.Point(345, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 754);
            this.panel3.TabIndex = 4;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.flpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFilter.Controls.Add(this.chkTuoi);
            this.flpFilter.Controls.Add(this.label23);
            this.flpFilter.Controls.Add(this.rjDatePicker1);
            this.flpFilter.Controls.Add(this.label24);
            this.flpFilter.Controls.Add(this.rjDatePicker2);
            this.flpFilter.Controls.Add(this.chkTrangThai);
            this.flpFilter.Controls.Add(this.label27);
            this.flpFilter.Controls.Add(this.chkHoatDong);
            this.flpFilter.Controls.Add(this.label28);
            this.flpFilter.Controls.Add(this.chkKoHD);
            this.flpFilter.Controls.Add(this.label29);
            this.flpFilter.Location = new System.Drawing.Point(402, 56);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(416, 84);
            this.flpFilter.TabIndex = 4;
            this.flpFilter.Visible = false;
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
            this.chkTuoi.Location = new System.Drawing.Point(3, 3);
            this.chkTuoi.Name = "chkTuoi";
            this.chkTuoi.Padding = new System.Windows.Forms.Padding(10);
            this.chkTuoi.Size = new System.Drawing.Size(24, 29);
            this.chkTuoi.TabIndex = 10;
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
            this.label23.Location = new System.Drawing.Point(33, 4);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 28);
            this.label23.TabIndex = 11;
            this.label23.Text = "Ngày KM:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rjDatePicker1
            // 
            this.rjDatePicker1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.rjDatePicker1.BorderSize = 2;
            this.rjDatePicker1.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rjDatePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.rjDatePicker1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker1.Location = new System.Drawing.Point(119, 4);
            this.rjDatePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.rjDatePicker1.MaximumSize = new System.Drawing.Size(250, 28);
            this.rjDatePicker1.MinimumSize = new System.Drawing.Size(4, 28);
            this.rjDatePicker1.Name = "rjDatePicker1";
            this.rjDatePicker1.Size = new System.Drawing.Size(120, 28);
            this.rjDatePicker1.SkinColor = System.Drawing.Color.White;
            this.rjDatePicker1.TabIndex = 27;
            this.rjDatePicker1.TextColor = System.Drawing.Color.Black;
            this.rjDatePicker1.Value = new System.DateTime(2023, 10, 22, 0, 0, 0, 0);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label24.Location = new System.Drawing.Point(246, 4);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 28);
            this.label24.TabIndex = 28;
            this.label24.Text = "-";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rjDatePicker2
            // 
            this.rjDatePicker2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.rjDatePicker2.BorderSize = 2;
            this.rjDatePicker2.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rjDatePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.rjDatePicker2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rjDatePicker2.Location = new System.Drawing.Point(267, 4);
            this.rjDatePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.rjDatePicker2.MaximumSize = new System.Drawing.Size(250, 28);
            this.rjDatePicker2.MinimumSize = new System.Drawing.Size(4, 28);
            this.rjDatePicker2.Name = "rjDatePicker2";
            this.rjDatePicker2.Size = new System.Drawing.Size(120, 28);
            this.rjDatePicker2.SkinColor = System.Drawing.Color.White;
            this.rjDatePicker2.TabIndex = 29;
            this.rjDatePicker2.TextColor = System.Drawing.Color.Black;
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
            this.chkTrangThai.Location = new System.Drawing.Point(3, 39);
            this.chkTrangThai.Name = "chkTrangThai";
            this.chkTrangThai.Padding = new System.Windows.Forms.Padding(10);
            this.chkTrangThai.Size = new System.Drawing.Size(24, 29);
            this.chkTrangThai.TabIndex = 30;
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
            this.label27.Location = new System.Drawing.Point(33, 40);
            this.label27.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 28);
            this.label27.TabIndex = 31;
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
            this.chkHoatDong.Location = new System.Drawing.Point(102, 39);
            this.chkHoatDong.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkHoatDong.Name = "chkHoatDong";
            this.chkHoatDong.Padding = new System.Windows.Forms.Padding(10);
            this.chkHoatDong.Size = new System.Drawing.Size(24, 29);
            this.chkHoatDong.TabIndex = 32;
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
            this.label28.Location = new System.Drawing.Point(130, 40);
            this.label28.Margin = new System.Windows.Forms.Padding(4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 28);
            this.label28.TabIndex = 33;
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
            this.chkKoHD.Location = new System.Drawing.Point(230, 39);
            this.chkKoHD.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chkKoHD.Name = "chkKoHD";
            this.chkKoHD.Padding = new System.Windows.Forms.Padding(10);
            this.chkKoHD.Size = new System.Drawing.Size(24, 29);
            this.chkKoHD.TabIndex = 34;
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
            this.label29.Location = new System.Drawing.Point(258, 40);
            this.label29.Margin = new System.Windows.Forms.Padding(4);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(146, 28);
            this.label29.TabIndex = 35;
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
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(813, 50);
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
            this.cbxTimKiem.Size = new System.Drawing.Size(173, 30);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "";
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
            this.txtTimKiem.Location = new System.Drawing.Point(185, 8);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(475, 32);
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
            this.btnTimKiem.Location = new System.Drawing.Point(667, 8);
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
            this.btnFilter.Location = new System.Drawing.Point(714, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(44, 36);
            this.btnFilter.TabIndex = 5;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 475);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaKM);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtTenKm);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.dtpNgayBD);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.dtpNgayKT);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.txtPhanTramKM);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.txtDkKM);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.cbxTrangThai);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 43);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(327, 372);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // txtMaKM
            // 
            this.txtMaKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaKM.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaKM.BorderRadius = 0;
            this.txtMaKM.BorderSize = 2;
            this.txtMaKM.Enabled = false;
            this.txtMaKM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKM.ForeColor = System.Drawing.Color.Black;
            this.txtMaKM.Location = new System.Drawing.Point(106, 4);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKM.MaximumSize = new System.Drawing.Size(250, 28);
            this.txtMaKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaKM.Multiline = false;
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtMaKM.PasswordChar = false;
            this.txtMaKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKM.PlaceholderText = "";
            this.txtMaKM.ReadOnly = false;
            this.txtMaKM.Size = new System.Drawing.Size(196, 28);
            this.txtMaKM.TabIndex = 2;
            this.txtMaKM.Texts = "";
            this.txtMaKM.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label13.Size = new System.Drawing.Size(256, 19);
            this.label13.TabIndex = 39;
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenKm
            // 
            this.txtTenKm.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenKm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenKm.BorderRadius = 0;
            this.txtTenKm.BorderSize = 2;
            this.txtTenKm.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKm.ForeColor = System.Drawing.Color.Black;
            this.txtTenKm.Location = new System.Drawing.Point(106, 59);
            this.txtTenKm.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKm.MaximumSize = new System.Drawing.Size(250, 28);
            this.txtTenKm.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTenKm.Multiline = false;
            this.txtTenKm.Name = "txtTenKm";
            this.txtTenKm.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtTenKm.PasswordChar = false;
            this.txtTenKm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKm.PlaceholderText = "";
            this.txtTenKm.ReadOnly = false;
            this.txtTenKm.Size = new System.Drawing.Size(196, 28);
            this.txtTenKm.TabIndex = 23;
            this.txtTenKm.Texts = "";
            this.txtTenKm.UnderlinedStyle = false;
            this.txtTenKm._TextChanged += new System.EventHandler(this.txtTenKm__TextChanged);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayBD.BorderSize = 2;
            this.dtpNgayBD.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayBD.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(106, 114);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBD.MaximumSize = new System.Drawing.Size(250, 28);
            this.dtpNgayBD.MinimumSize = new System.Drawing.Size(4, 28);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(196, 28);
            this.dtpNgayBD.SkinColor = System.Drawing.Color.White;
            this.dtpNgayBD.TabIndex = 26;
            this.dtpNgayBD.TextColor = System.Drawing.Color.Black;
            this.dtpNgayBD.ValueChanged += new System.EventHandler(this.dtpNgayBD_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label6.Size = new System.Drawing.Size(256, 19);
            this.label6.TabIndex = 27;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayKT.BorderSize = 2;
            this.dtpNgayKT.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayKT.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(106, 169);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKT.MaximumSize = new System.Drawing.Size(250, 28);
            this.dtpNgayKT.MinimumSize = new System.Drawing.Size(4, 28);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(196, 28);
            this.dtpNgayKT.SkinColor = System.Drawing.Color.White;
            this.dtpNgayKT.TabIndex = 29;
            this.dtpNgayKT.TextColor = System.Drawing.Color.Black;
            this.dtpNgayKT.ValueChanged += new System.EventHandler(this.dtpNgayKT_ValueChanged);
            // 
            // txtPhanTramKM
            // 
            this.txtPhanTramKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhanTramKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtPhanTramKM.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtPhanTramKM.BorderRadius = 0;
            this.txtPhanTramKM.BorderSize = 2;
            this.txtPhanTramKM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramKM.ForeColor = System.Drawing.Color.Black;
            this.txtPhanTramKM.Location = new System.Drawing.Point(106, 224);
            this.txtPhanTramKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhanTramKM.MaximumSize = new System.Drawing.Size(250, 28);
            this.txtPhanTramKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtPhanTramKM.Multiline = false;
            this.txtPhanTramKM.Name = "txtPhanTramKM";
            this.txtPhanTramKM.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtPhanTramKM.PasswordChar = false;
            this.txtPhanTramKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhanTramKM.PlaceholderText = "";
            this.txtPhanTramKM.ReadOnly = false;
            this.txtPhanTramKM.Size = new System.Drawing.Size(196, 28);
            this.txtPhanTramKM.TabIndex = 32;
            this.txtPhanTramKM.Texts = "";
            this.txtPhanTramKM.UnderlinedStyle = false;
            this.txtPhanTramKM._TextChanged += new System.EventHandler(this.txtPhanTramKM__TextChanged);
            // 
            // txtDkKM
            // 
            this.txtDkKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtDkKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtDkKM.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtDkKM.BorderRadius = 0;
            this.txtDkKM.BorderSize = 2;
            this.txtDkKM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDkKM.ForeColor = System.Drawing.Color.Black;
            this.txtDkKM.Location = new System.Drawing.Point(106, 279);
            this.txtDkKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtDkKM.MaximumSize = new System.Drawing.Size(250, 28);
            this.txtDkKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtDkKM.Multiline = false;
            this.txtDkKM.Name = "txtDkKM";
            this.txtDkKM.Padding = new System.Windows.Forms.Padding(2);
            this.txtDkKM.PasswordChar = false;
            this.txtDkKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDkKM.PlaceholderText = "";
            this.txtDkKM.ReadOnly = false;
            this.txtDkKM.Size = new System.Drawing.Size(196, 28);
            this.txtDkKM.TabIndex = 35;
            this.txtDkKM.Texts = "";
            this.txtDkKM.UnderlinedStyle = false;
            this.txtDkKM._TextChanged += new System.EventHandler(this.txtDkKM__TextChanged);
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
            this.cbxTrangThai.Location = new System.Drawing.Point(105, 333);
            this.cbxTrangThai.MinimumSize = new System.Drawing.Size(100, 5);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbxTrangThai.Size = new System.Drawing.Size(197, 28);
            this.cbxTrangThai.TabIndex = 38;
            this.cbxTrangThai.Texts = "";
            // 
            // KhuyenMaiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhuyenMaiGUI";
            this.Text = "KhuyenMaiGUI";
            this.Load += new System.EventHandler(this.KhuyenMaiGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.flpFilter.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaKM;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJTextBox txtTenKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MyCustom.RJDatePicker dtpNgayBD;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJDatePicker dtpNgayKT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MyCustom.RJTextBox txtPhanTramKM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private MyCustom.RJTextBox txtDkKM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private MyCustom.RJComboBox cbxTrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.RJButton btnThem;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnXemChiTietKM;
        private System.Windows.Forms.Label label15;
        private MyCustom.RJButton btnFilter;
        private MyCustom.RJButton btnThongTinKM;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkTuoi;
        private System.Windows.Forms.Label label23;
        private MyCustom.RJDatePicker rjDatePicker1;
        private System.Windows.Forms.Label label24;
        private MyCustom.RJDatePicker rjDatePicker2;
        private MyCustom.BiggerCheckBox chkTrangThai;
        private System.Windows.Forms.Label label27;
        private MyCustom.BiggerCheckBox chkHoatDong;
        private System.Windows.Forms.Label label28;
        private MyCustom.BiggerCheckBox chkKoHD;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieuKienKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
    }
}