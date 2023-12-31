﻿namespace GUI
{
    partial class HoaDonGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExport = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.dgvXemThongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemNhanDuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.chkNgay = new GUI.MyCustom.BiggerCheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpNgayStart = new GUI.MyCustom.RJDatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNgayEnd = new GUI.MyCustom.RJDatePicker();
            this.lblErrTuoiFilter = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemThongTinHoaDon)).BeginInit();
            this.flpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.dgvXemThongTinHoaDon);
            this.panel3.Controls.Add(this.flpFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1180, 738);
            this.panel3.TabIndex = 7;
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = true;
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnExport.BorderRadius = 4;
            this.btnExport.BorderSize = 2;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(977, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(120, 8, 10, 0);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(168, 42);
            this.btnExport.TabIndex = 32;
            this.btnExport.Text = "         Export Excel";
            this.btnExport.TextColor = System.Drawing.Color.Black;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            this.flowLayoutPanel4.Size = new System.Drawing.Size(952, 55);
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
            this.cbxTimKiem.Size = new System.Drawing.Size(172, 33);
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
            this.txtTimKiem.Location = new System.Drawing.Point(184, 8);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(650, 32);
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
            this.btnTimKiem.Location = new System.Drawing.Point(841, 8);
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
            this.btnFilter.Location = new System.Drawing.Point(888, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(44, 37);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvXemThongTinHoaDon
            // 
            this.dgvXemThongTinHoaDon.AllowUserToAddRows = false;
            this.dgvXemThongTinHoaDon.AllowUserToDeleteRows = false;
            this.dgvXemThongTinHoaDon.AllowUserToResizeColumns = false;
            this.dgvXemThongTinHoaDon.AllowUserToResizeRows = false;
            this.dgvXemThongTinHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvXemThongTinHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvXemThongTinHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXemThongTinHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXemThongTinHoaDon.ColumnHeadersHeight = 28;
            this.dgvXemThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayLapHD,
            this.Ten,
            this.DiemSuDung,
            this.TongTien,
            this.DiemNhanDuoc,
            this.TenNV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXemThongTinHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXemThongTinHoaDon.EnableHeadersVisualStyles = false;
            this.dgvXemThongTinHoaDon.GridColor = System.Drawing.Color.Black;
            this.dgvXemThongTinHoaDon.Location = new System.Drawing.Point(8, 64);
            this.dgvXemThongTinHoaDon.Name = "dgvXemThongTinHoaDon";
            this.dgvXemThongTinHoaDon.ReadOnly = true;
            this.dgvXemThongTinHoaDon.RowHeadersVisible = false;
            this.dgvXemThongTinHoaDon.RowHeadersWidth = 51;
            this.dgvXemThongTinHoaDon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvXemThongTinHoaDon.RowTemplate.Height = 30;
            this.dgvXemThongTinHoaDon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvXemThongTinHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXemThongTinHoaDon.Size = new System.Drawing.Size(1160, 662);
            this.dgvXemThongTinHoaDon.TabIndex = 1;
            this.dgvXemThongTinHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXemThongTinHoaDon_CellDoubleClick);
            this.dgvXemThongTinHoaDon.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvXemThongTinHoaDon_CellFormatting);
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HĐ";
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            this.MaHD.Width = 110;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập hóa đơn";
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.ReadOnly = true;
            this.NgayLapHD.Width = 170;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên khách hàng";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 260;
            // 
            // DiemSuDung
            // 
            this.DiemSuDung.DataPropertyName = "DiemSuDung";
            this.DiemSuDung.HeaderText = "Điểm sử dụng";
            this.DiemSuDung.Name = "DiemSuDung";
            this.DiemSuDung.ReadOnly = true;
            this.DiemSuDung.Width = 117;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 195;
            // 
            // DiemNhanDuoc
            // 
            this.DiemNhanDuoc.DataPropertyName = "DiemNhanDuoc";
            this.DiemNhanDuoc.HeaderText = "Điểm nhận được";
            this.DiemNhanDuoc.Name = "DiemNhanDuoc";
            this.DiemNhanDuoc.ReadOnly = true;
            this.DiemNhanDuoc.Width = 135;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenNV.DataPropertyName = "Ten1";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 178;
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.flpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFilter.Controls.Add(this.chkNgay);
            this.flpFilter.Controls.Add(this.label23);
            this.flpFilter.Controls.Add(this.dtpNgayStart);
            this.flpFilter.Controls.Add(this.label1);
            this.flpFilter.Controls.Add(this.dtpNgayEnd);
            this.flpFilter.Controls.Add(this.lblErrTuoiFilter);
            this.flpFilter.Location = new System.Drawing.Point(609, 72);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(466, 88);
            this.flpFilter.TabIndex = 34;
            this.flpFilter.Visible = false;
            // 
            // chkNgay
            // 
            this.chkNgay.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNgay.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkNgay.BoxColor = System.Drawing.Color.Black;
            this.chkNgay.BoxLocationX = 5;
            this.chkNgay.BoxLocationY = 8;
            this.chkNgay.BoxSize = 14;
            this.chkNgay.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNgay.FlatAppearance.BorderSize = 0;
            this.chkNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNgay.Location = new System.Drawing.Point(3, 20);
            this.chkNgay.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.chkNgay.Name = "chkNgay";
            this.chkNgay.Padding = new System.Windows.Forms.Padding(10);
            this.chkNgay.Size = new System.Drawing.Size(24, 29);
            this.chkNgay.TabIndex = 9;
            this.chkNgay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNgay.TextLocationX = 16;
            this.chkNgay.TextLocationY = 1;
            this.chkNgay.TickColor = System.Drawing.Color.Black;
            this.chkNgay.TickLeftPosition = 5F;
            this.chkNgay.TickSize = 11F;
            this.chkNgay.TickTopPosition = 8F;
            this.chkNgay.UseVisualStyleBackColor = true;
            this.chkNgay.CheckedChanged += new System.EventHandler(this.chkNgay_CheckedChanged);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label23.Location = new System.Drawing.Point(33, 20);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 20, 4, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 28);
            this.label23.TabIndex = 8;
            this.label23.Text = "Ngày lập :";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayStart
            // 
            this.dtpNgayStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayStart.BorderSize = 2;
            this.dtpNgayStart.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayStart.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayStart.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayStart.Location = new System.Drawing.Point(129, 20);
            this.dtpNgayStart.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.dtpNgayStart.MaxDate = new System.DateTime(2028, 5, 31, 0, 0, 0, 0);
            this.dtpNgayStart.MaximumSize = new System.Drawing.Size(171, 28);
            this.dtpNgayStart.MinimumSize = new System.Drawing.Size(4, 28);
            this.dtpNgayStart.Name = "dtpNgayStart";
            this.dtpNgayStart.Size = new System.Drawing.Size(136, 28);
            this.dtpNgayStart.SkinColor = System.Drawing.Color.White;
            this.dtpNgayStart.TabIndex = 29;
            this.dtpNgayStart.TextColor = System.Drawing.Color.Black;
            this.dtpNgayStart.Value = new System.DateTime(2023, 11, 12, 21, 49, 47, 0);
            this.dtpNgayStart.ValueChanged += new System.EventHandler(this.dtpNgayStart_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 4, 4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "--";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayEnd
            // 
            this.dtpNgayEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayEnd.BorderSize = 2;
            this.dtpNgayEnd.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayEnd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayEnd.Location = new System.Drawing.Point(317, 20);
            this.dtpNgayEnd.Margin = new System.Windows.Forms.Padding(4, 20, 4, 4);
            this.dtpNgayEnd.MaxDate = new System.DateTime(2028, 5, 31, 0, 0, 0, 0);
            this.dtpNgayEnd.MaximumSize = new System.Drawing.Size(171, 28);
            this.dtpNgayEnd.MinimumSize = new System.Drawing.Size(4, 28);
            this.dtpNgayEnd.Name = "dtpNgayEnd";
            this.dtpNgayEnd.Size = new System.Drawing.Size(132, 28);
            this.dtpNgayEnd.SkinColor = System.Drawing.Color.White;
            this.dtpNgayEnd.TabIndex = 31;
            this.dtpNgayEnd.TextColor = System.Drawing.Color.Black;
            this.dtpNgayEnd.Value = new System.DateTime(2023, 11, 12, 21, 49, 58, 0);
            this.dtpNgayEnd.ValueChanged += new System.EventHandler(this.dtpNgayEnd_ValueChanged);
            // 
            // lblErrTuoiFilter
            // 
            this.lblErrTuoiFilter.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrTuoiFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrTuoiFilter.Location = new System.Drawing.Point(3, 52);
            this.lblErrTuoiFilter.Name = "lblErrTuoiFilter";
            this.lblErrTuoiFilter.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblErrTuoiFilter.Size = new System.Drawing.Size(433, 20);
            this.lblErrTuoiFilter.TabIndex = 28;
            this.lblErrTuoiFilter.Text = "* Bạn phải nhập ngày sau lơn hơn ngày trước";
            this.lblErrTuoiFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrTuoiFilter.Visible = false;
            // 
            // HoaDonGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 738);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HoaDonGUI";
            this.Text = "HoaDonGUI";
            this.Load += new System.EventHandler(this.HoaDonGUI_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemThongTinHoaDon)).EndInit();
            this.flpFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MyCustom.RJButton btnExport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvXemThongTinHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemNhanDuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkNgay;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblErrTuoiFilter;
        private MyCustom.RJDatePicker dtpNgayStart;
        private System.Windows.Forms.Label label1;
        private MyCustom.RJDatePicker dtpNgayEnd;
    }
}