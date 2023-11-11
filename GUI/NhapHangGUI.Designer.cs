namespace GUI
{
    partial class NhapHangGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHangGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGioHangNhap = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpNhaCungCap = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblErrGiaFilter = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblErrTonKhoFilter = new System.Windows.Forms.Label();
            this.pnThongTinSP = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new GUI.MyCustom.GradientPanel();
            this.rjButton2 = new GUI.MyCustom.RJButton();
            this.lblMaPN = new System.Windows.Forms.Label();
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new GUI.MyCustom.GradientPanel();
            this.btnInHoaDon = new GUI.MyCustom.RJButton();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnThanhToan = new GUI.MyCustom.RJButton();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.chkGia = new GUI.MyCustom.BiggerCheckBox();
            this.txtGiaStart = new GUI.MyCustom.RJTextBox();
            this.txtGiaEnd = new GUI.MyCustom.RJTextBox();
            this.chkTonKho = new GUI.MyCustom.BiggerCheckBox();
            this.txtTonKhoStart = new GUI.MyCustom.RJTextBox();
            this.txtTonKhoEnd = new GUI.MyCustom.RJTextBox();
            this.btnChonSanPham = new GUI.MyCustom.RJButton();
            this.nudSoLuongMua = new GUI.MyCustom.CustomNumericUpDown();
            this.txtMaSP = new GUI.MyCustom.RJTextBox();
            this.txtTenSP = new GUI.MyCustom.RJTextBox();
            this.txtTonKho = new GUI.MyCustom.RJTextBox();
            this.txtDonGia = new GUI.MyCustom.RJTextBox();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.flpFilter.SuspendLayout();
            this.pnThongTinSP.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 718);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.gradientPanel1);
            this.flowLayoutPanel3.Controls.Add(this.flpGioHangNhap);
            this.flowLayoutPanel3.Controls.Add(this.gradientPanel2);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(790, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(382, 758);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // flpGioHangNhap
            // 
            this.flpGioHangNhap.AutoScroll = true;
            this.flpGioHangNhap.Location = new System.Drawing.Point(0, 147);
            this.flpGioHangNhap.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.flpGioHangNhap.Name = "flpGioHangNhap";
            this.flpGioHangNhap.Size = new System.Drawing.Size(377, 475);
            this.flpGioHangNhap.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.flpNhaCungCap);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.pnThongTinSP);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 734);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flpNhaCungCap
            // 
            this.flpNhaCungCap.AutoScroll = true;
            this.flpNhaCungCap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpNhaCungCap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flpNhaCungCap.Location = new System.Drawing.Point(3, 3);
            this.flpNhaCungCap.Name = "flpNhaCungCap";
            this.flpNhaCungCap.Size = new System.Drawing.Size(775, 64);
            this.flpNhaCungCap.TabIndex = 3;
            this.flpNhaCungCap.WrapContents = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 70);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(775, 50);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSanPham);
            this.panel2.Controls.Add(this.flpFilter);
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 434);
            this.panel2.TabIndex = 9;
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
            this.MaSP,
            this.TenSP,
            this.SoLuong,
            this.DonGiaNhap,
            this.TenLoai,
            this.TenNCC,
            this.TrangThai});
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
            this.dgvSanPham.Location = new System.Drawing.Point(6, 8);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSanPham.RowTemplate.Height = 30;
            this.dgvSanPham.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(758, 413);
            this.dgvSanPham.TabIndex = 10;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // flpFilter
            // 
            this.flpFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.flpFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFilter.Controls.Add(this.chkGia);
            this.flpFilter.Controls.Add(this.label23);
            this.flpFilter.Controls.Add(this.txtGiaStart);
            this.flpFilter.Controls.Add(this.label7);
            this.flpFilter.Controls.Add(this.txtGiaEnd);
            this.flpFilter.Controls.Add(this.lblErrGiaFilter);
            this.flpFilter.Controls.Add(this.chkTonKho);
            this.flpFilter.Controls.Add(this.label25);
            this.flpFilter.Controls.Add(this.txtTonKhoStart);
            this.flpFilter.Controls.Add(this.label12);
            this.flpFilter.Controls.Add(this.txtTonKhoEnd);
            this.flpFilter.Controls.Add(this.lblErrTonKhoFilter);
            this.flpFilter.Location = new System.Drawing.Point(475, 3);
            this.flpFilter.Name = "flpFilter";
            this.flpFilter.Size = new System.Drawing.Size(289, 116);
            this.flpFilter.TabIndex = 11;
            this.flpFilter.Visible = false;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label23.Location = new System.Drawing.Point(33, 4);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 28);
            this.label23.TabIndex = 8;
            this.label23.Text = "Giá:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(185, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "-";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrGiaFilter
            // 
            this.lblErrGiaFilter.Font = new System.Drawing.Font("Cambria", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrGiaFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrGiaFilter.Location = new System.Drawing.Point(3, 36);
            this.lblErrGiaFilter.Name = "lblErrGiaFilter";
            this.lblErrGiaFilter.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblErrGiaFilter.Size = new System.Drawing.Size(262, 17);
            this.lblErrGiaFilter.TabIndex = 28;
            this.lblErrGiaFilter.Text = "* Bạn phải giá kết thúc lớn hơn giá bắt đầu ";
            this.lblErrGiaFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrGiaFilter.Visible = false;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label25.Location = new System.Drawing.Point(33, 57);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 28);
            this.label25.TabIndex = 13;
            this.label25.Text = "Tồn kho";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label12.Location = new System.Drawing.Point(185, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 28);
            this.label12.TabIndex = 30;
            this.label12.Text = "-";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblErrTonKhoFilter
            // 
            this.lblErrTonKhoFilter.Font = new System.Drawing.Font("Cambria", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrTonKhoFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrTonKhoFilter.Location = new System.Drawing.Point(3, 89);
            this.lblErrTonKhoFilter.Name = "lblErrTonKhoFilter";
            this.lblErrTonKhoFilter.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.lblErrTonKhoFilter.Size = new System.Drawing.Size(262, 17);
            this.lblErrTonKhoFilter.TabIndex = 32;
            this.lblErrTonKhoFilter.Text = "* Bạn phải SL kết thúc lớn hơn SL bắt đầu ";
            this.lblErrTonKhoFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblErrTonKhoFilter.Visible = false;
            // 
            // pnThongTinSP
            // 
            this.pnThongTinSP.Controls.Add(this.btnChonSanPham);
            this.pnThongTinSP.Controls.Add(this.label5);
            this.pnThongTinSP.Controls.Add(this.label6);
            this.pnThongTinSP.Controls.Add(this.nudSoLuongMua);
            this.pnThongTinSP.Controls.Add(this.label1);
            this.pnThongTinSP.Controls.Add(this.txtMaSP);
            this.pnThongTinSP.Controls.Add(this.label2);
            this.pnThongTinSP.Controls.Add(this.txtTenSP);
            this.pnThongTinSP.Controls.Add(this.label3);
            this.pnThongTinSP.Controls.Add(this.txtTonKho);
            this.pnThongTinSP.Controls.Add(this.label4);
            this.pnThongTinSP.Controls.Add(this.txtDonGia);
            this.pnThongTinSP.Location = new System.Drawing.Point(3, 563);
            this.pnThongTinSP.Name = "pnThongTinSP";
            this.pnThongTinSP.Size = new System.Drawing.Size(775, 164);
            this.pnThongTinSP.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(110, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(40, 5, 3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(649, 2);
            this.label5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(30, 4, 3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nhập số lượng:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(40, 20, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã SP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(40, 4, 3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên SP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(404, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(40, 4, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tồn kho";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(404, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(40, 4, 3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đơn giá";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BottomColor = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.rjButton2);
            this.gradientPanel1.Controls.Add(this.lblMaPN);
            this.gradientPanel1.Controls.Add(this.lblNhaCungCap);
            this.gradientPanel1.Controls.Add(this.lblNhanVien);
            this.gradientPanel1.Controls.Add(this.lblNgayLap);
            this.gradientPanel1.Controls.Add(this.label11);
            this.gradientPanel1.Controls.Add(this.label10);
            this.gradientPanel1.Controls.Add(this.label9);
            this.gradientPanel1.Controls.Add(this.label8);
            this.gradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(374, 144);
            this.gradientPanel1.TabIndex = 3;
            this.gradientPanel1.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(250, 87);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(60, 31);
            this.rjButton2.TabIndex = 12;
            this.rjButton2.Text = "rjButton2";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // lblMaPN
            // 
            this.lblMaPN.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPN.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaPN.Location = new System.Drawing.Point(125, 0);
            this.lblMaPN.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.lblMaPN.Name = "lblMaPN";
            this.lblMaPN.Size = new System.Drawing.Size(76, 32);
            this.lblMaPN.TabIndex = 10;
            this.lblMaPN.Text = "#HD001";
            this.lblMaPN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(125, 106);
            this.lblNhaCungCap.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(161, 32);
            this.lblNhaCungCap.TabIndex = 8;
            this.lblNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.lblNhanVien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(125, 69);
            this.lblNhanVien.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(161, 32);
            this.lblNhanVien.TabIndex = 7;
            this.lblNhanVien.Text = "Lee Changsub";
            this.lblNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.BackColor = System.Drawing.Color.Transparent;
            this.lblNgayLap.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLap.Location = new System.Drawing.Point(125, 32);
            this.lblNgayLap.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(161, 32);
            this.lblNgayLap.TabIndex = 6;
            this.lblNgayLap.Text = "12/10/2023";
            this.lblNgayLap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 32);
            this.label11.TabIndex = 5;
            this.label11.Text = "Nhà cung cấp:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nhân viên: ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "Ngày lập: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 32);
            this.label8.TabIndex = 2;
            this.label8.Text = "PHIẾU NHẬP";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            this.gradientPanel2.Controls.Add(this.btnInHoaDon);
            this.gradientPanel2.Controls.Add(this.lblTongTien);
            this.gradientPanel2.Controls.Add(this.label24);
            this.gradientPanel2.Controls.Add(this.btnThanhToan);
            this.gradientPanel2.Location = new System.Drawing.Point(3, 628);
            this.gradientPanel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(374, 109);
            this.gradientPanel2.TabIndex = 7;
            this.gradientPanel2.TopColor = System.Drawing.Color.Empty;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.White;
            this.btnInHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.btnInHoaDon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(77)))), ((int)(((byte)(89)))));
            this.btnInHoaDon.BorderRadius = 10;
            this.btnInHoaDon.BorderSize = 2;
            this.btnInHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnInHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnInHoaDon.Image = global::GUI.Properties.Resources.icons8_print_28;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(24, 51);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(150, 41);
            this.btnInHoaDon.TabIndex = 16;
            this.btnInHoaDon.Text = "         IN HÓA ĐƠN";
            this.btnInHoaDon.TextColor = System.Drawing.Color.Black;
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.BackColor = System.Drawing.Color.Transparent;
            this.lblTongTien.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(190, 13);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(137, 21);
            this.lblTongTien.TabIndex = 15;
            this.lblTongTien.Text = "0đ";
            this.lblTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 13);
            this.label24.Margin = new System.Windows.Forms.Padding(15, 10, 3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(158, 21);
            this.label24.TabIndex = 14;
            this.label24.Text = "Tổng tiền:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.btnThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.BorderSize = 2;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnThanhToan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Image = global::GUI.Properties.Resources.icons8_checkout_28;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(201, 51);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 41);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "         THANH TOÁN";
            this.btnThanhToan.TextColor = System.Drawing.Color.Black;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
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
            this.cbxTimKiem.Texts = "Mã SP";
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
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(545, 32);
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
            this.btnTimKiem.Location = new System.Drawing.Point(672, 8);
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
            this.btnFilter.Location = new System.Drawing.Point(719, 8);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(15, 8, 10, 0);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(44, 36);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.TextColor = System.Drawing.Color.White;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // chkGia
            // 
            this.chkGia.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGia.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkGia.BoxColor = System.Drawing.Color.Black;
            this.chkGia.BoxLocationX = 5;
            this.chkGia.BoxLocationY = 8;
            this.chkGia.BoxSize = 14;
            this.chkGia.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGia.FlatAppearance.BorderSize = 0;
            this.chkGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGia.Location = new System.Drawing.Point(3, 3);
            this.chkGia.Name = "chkGia";
            this.chkGia.Padding = new System.Windows.Forms.Padding(10);
            this.chkGia.Size = new System.Drawing.Size(24, 29);
            this.chkGia.TabIndex = 9;
            this.chkGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkGia.TextLocationX = 16;
            this.chkGia.TextLocationY = 1;
            this.chkGia.TickColor = System.Drawing.Color.Black;
            this.chkGia.TickLeftPosition = 5F;
            this.chkGia.TickSize = 11F;
            this.chkGia.TickTopPosition = 8F;
            this.chkGia.UseVisualStyleBackColor = true;
            this.chkGia.CheckedChanged += new System.EventHandler(this.chkGia_CheckedChanged);
            // 
            // txtGiaStart
            // 
            this.txtGiaStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtGiaStart.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtGiaStart.BorderRadius = 0;
            this.txtGiaStart.BorderSize = 2;
            this.txtGiaStart.Enabled = false;
            this.txtGiaStart.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaStart.ForeColor = System.Drawing.Color.Black;
            this.txtGiaStart.Location = new System.Drawing.Point(119, 4);
            this.txtGiaStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaStart.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtGiaStart.Multiline = false;
            this.txtGiaStart.Name = "txtGiaStart";
            this.txtGiaStart.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtGiaStart.PasswordChar = false;
            this.txtGiaStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtGiaStart.PlaceholderText = "Từ";
            this.txtGiaStart.ReadOnly = false;
            this.txtGiaStart.Size = new System.Drawing.Size(59, 28);
            this.txtGiaStart.TabIndex = 10;
            this.txtGiaStart.Texts = "";
            this.txtGiaStart.UnderlinedStyle = false;
            this.txtGiaStart._TextChanged += new System.EventHandler(this.txtGiaStart__TextChanged);
            // 
            // txtGiaEnd
            // 
            this.txtGiaEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtGiaEnd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtGiaEnd.BorderRadius = 0;
            this.txtGiaEnd.BorderSize = 2;
            this.txtGiaEnd.Enabled = false;
            this.txtGiaEnd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaEnd.ForeColor = System.Drawing.Color.Black;
            this.txtGiaEnd.Location = new System.Drawing.Point(206, 4);
            this.txtGiaEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaEnd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtGiaEnd.Multiline = false;
            this.txtGiaEnd.Name = "txtGiaEnd";
            this.txtGiaEnd.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtGiaEnd.PasswordChar = false;
            this.txtGiaEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtGiaEnd.PlaceholderText = "Đến";
            this.txtGiaEnd.ReadOnly = false;
            this.txtGiaEnd.Size = new System.Drawing.Size(59, 28);
            this.txtGiaEnd.TabIndex = 11;
            this.txtGiaEnd.Texts = "";
            this.txtGiaEnd.UnderlinedStyle = false;
            this.txtGiaEnd._TextChanged += new System.EventHandler(this.txtGiaEnd__TextChanged);
            // 
            // chkTonKho
            // 
            this.chkTonKho.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTonKho.BoxBackColor = System.Drawing.Color.Transparent;
            this.chkTonKho.BoxColor = System.Drawing.Color.Black;
            this.chkTonKho.BoxLocationX = 5;
            this.chkTonKho.BoxLocationY = 8;
            this.chkTonKho.BoxSize = 14;
            this.chkTonKho.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTonKho.FlatAppearance.BorderSize = 0;
            this.chkTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTonKho.Location = new System.Drawing.Point(3, 56);
            this.chkTonKho.Name = "chkTonKho";
            this.chkTonKho.Padding = new System.Windows.Forms.Padding(10);
            this.chkTonKho.Size = new System.Drawing.Size(24, 29);
            this.chkTonKho.TabIndex = 14;
            this.chkTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkTonKho.TextLocationX = 16;
            this.chkTonKho.TextLocationY = 1;
            this.chkTonKho.TickColor = System.Drawing.Color.Black;
            this.chkTonKho.TickLeftPosition = 5F;
            this.chkTonKho.TickSize = 11F;
            this.chkTonKho.TickTopPosition = 8F;
            this.chkTonKho.UseVisualStyleBackColor = true;
            this.chkTonKho.CheckedChanged += new System.EventHandler(this.chkTonKho_CheckedChanged);
            this.chkTonKho.TextChanged += new System.EventHandler(this.chkTonKho_CheckedChanged);
            // 
            // txtTonKhoStart
            // 
            this.txtTonKhoStart.BackColor = System.Drawing.SystemColors.Window;
            this.txtTonKhoStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTonKhoStart.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTonKhoStart.BorderRadius = 0;
            this.txtTonKhoStart.BorderSize = 2;
            this.txtTonKhoStart.Enabled = false;
            this.txtTonKhoStart.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKhoStart.ForeColor = System.Drawing.Color.Black;
            this.txtTonKhoStart.Location = new System.Drawing.Point(119, 57);
            this.txtTonKhoStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtTonKhoStart.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtTonKhoStart.Multiline = false;
            this.txtTonKhoStart.Name = "txtTonKhoStart";
            this.txtTonKhoStart.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtTonKhoStart.PasswordChar = false;
            this.txtTonKhoStart.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTonKhoStart.PlaceholderText = "Từ";
            this.txtTonKhoStart.ReadOnly = false;
            this.txtTonKhoStart.Size = new System.Drawing.Size(59, 28);
            this.txtTonKhoStart.TabIndex = 29;
            this.txtTonKhoStart.Texts = "";
            this.txtTonKhoStart.UnderlinedStyle = false;
            this.txtTonKhoStart._TextChanged += new System.EventHandler(this.txtTonKhoStart__TextChanged);
            // 
            // txtTonKhoEnd
            // 
            this.txtTonKhoEnd.BackColor = System.Drawing.SystemColors.Window;
            this.txtTonKhoEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTonKhoEnd.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTonKhoEnd.BorderRadius = 0;
            this.txtTonKhoEnd.BorderSize = 2;
            this.txtTonKhoEnd.Enabled = false;
            this.txtTonKhoEnd.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKhoEnd.ForeColor = System.Drawing.Color.Black;
            this.txtTonKhoEnd.Location = new System.Drawing.Point(206, 57);
            this.txtTonKhoEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtTonKhoEnd.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtTonKhoEnd.Multiline = false;
            this.txtTonKhoEnd.Name = "txtTonKhoEnd";
            this.txtTonKhoEnd.Padding = new System.Windows.Forms.Padding(8, 4, 2, 2);
            this.txtTonKhoEnd.PasswordChar = false;
            this.txtTonKhoEnd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTonKhoEnd.PlaceholderText = "Đến";
            this.txtTonKhoEnd.ReadOnly = false;
            this.txtTonKhoEnd.Size = new System.Drawing.Size(59, 28);
            this.txtTonKhoEnd.TabIndex = 31;
            this.txtTonKhoEnd.Texts = "";
            this.txtTonKhoEnd.UnderlinedStyle = false;
            this.txtTonKhoEnd._TextChanged += new System.EventHandler(this.txtTonKhoEnd__TextChanged);
            // 
            // btnChonSanPham
            // 
            this.btnChonSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.btnChonSanPham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.btnChonSanPham.BorderColor = System.Drawing.Color.Black;
            this.btnChonSanPham.BorderRadius = 10;
            this.btnChonSanPham.BorderSize = 2;
            this.btnChonSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChonSanPham.FlatAppearance.BorderSize = 0;
            this.btnChonSanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnChonSanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.btnChonSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonSanPham.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonSanPham.ForeColor = System.Drawing.Color.Black;
            this.btnChonSanPham.Image = ((System.Drawing.Image)(resources.GetObject("btnChonSanPham.Image")));
            this.btnChonSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonSanPham.Location = new System.Drawing.Point(592, 113);
            this.btnChonSanPham.Name = "btnChonSanPham";
            this.btnChonSanPham.Size = new System.Drawing.Size(150, 41);
            this.btnChonSanPham.TabIndex = 22;
            this.btnChonSanPham.Text = "         CHỌN SẢN PHẨM";
            this.btnChonSanPham.TextColor = System.Drawing.Color.Black;
            this.btnChonSanPham.UseVisualStyleBackColor = false;
            this.btnChonSanPham.Click += new System.EventHandler(this.btnChonSanPham_Click);
            // 
            // nudSoLuongMua
            // 
            this.nudSoLuongMua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.nudSoLuongMua.BorderSize = 2;
            this.nudSoLuongMua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudSoLuongMua.CustomHeight = 28;
            this.nudSoLuongMua.CustomPadding = new System.Windows.Forms.Padding(4);
            this.nudSoLuongMua.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuongMua.Location = new System.Drawing.Point(211, 124);
            this.nudSoLuongMua.Name = "nudSoLuongMua";
            this.nudSoLuongMua.Size = new System.Drawing.Size(289, 27);
            this.nudSoLuongMua.TabIndex = 21;
            // 
            // txtMaSP
            // 
            this.txtMaSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaSP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaSP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaSP.BorderRadius = 0;
            this.txtMaSP.BorderSize = 2;
            this.txtMaSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.Black;
            this.txtMaSP.Location = new System.Drawing.Point(110, 15);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4, 20, 4, 10);
            this.txtMaSP.MaximumSize = new System.Drawing.Size(500, 28);
            this.txtMaSP.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaSP.Multiline = false;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtMaSP.PasswordChar = false;
            this.txtMaSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaSP.PlaceholderText = "";
            this.txtMaSP.ReadOnly = false;
            this.txtMaSP.Size = new System.Drawing.Size(270, 28);
            this.txtMaSP.TabIndex = 12;
            this.txtMaSP.Texts = "";
            this.txtMaSP.UnderlinedStyle = false;
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
            this.txtTenSP.Location = new System.Drawing.Point(110, 57);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.txtTenSP.MaximumSize = new System.Drawing.Size(500, 28);
            this.txtTenSP.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTenSP.Multiline = false;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtTenSP.PasswordChar = false;
            this.txtTenSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.ReadOnly = false;
            this.txtTenSP.Size = new System.Drawing.Size(270, 28);
            this.txtTenSP.TabIndex = 16;
            this.txtTenSP.Texts = "";
            this.txtTenSP.UnderlinedStyle = false;
            // 
            // txtTonKho
            // 
            this.txtTonKho.BackColor = System.Drawing.SystemColors.Window;
            this.txtTonKho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTonKho.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTonKho.BorderRadius = 0;
            this.txtTonKho.BorderSize = 2;
            this.txtTonKho.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTonKho.ForeColor = System.Drawing.Color.Black;
            this.txtTonKho.Location = new System.Drawing.Point(489, 15);
            this.txtTonKho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 10);
            this.txtTonKho.MaximumSize = new System.Drawing.Size(500, 28);
            this.txtTonKho.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTonKho.Multiline = false;
            this.txtTonKho.Name = "txtTonKho";
            this.txtTonKho.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtTonKho.PasswordChar = false;
            this.txtTonKho.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTonKho.PlaceholderText = "";
            this.txtTonKho.ReadOnly = false;
            this.txtTonKho.Size = new System.Drawing.Size(270, 28);
            this.txtTonKho.TabIndex = 17;
            this.txtTonKho.Texts = "";
            this.txtTonKho.UnderlinedStyle = false;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtDonGia.BorderRadius = 0;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.Location = new System.Drawing.Point(489, 57);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 45, 10);
            this.txtDonGia.MaximumSize = new System.Drawing.Size(500, 28);
            this.txtDonGia.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.ReadOnly = false;
            this.txtDonGia.Size = new System.Drawing.Size(270, 28);
            this.txtDonGia.TabIndex = 18;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.Frozen = true;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 70;
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Tồn kho";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 83;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            this.DonGiaNhap.Width = 80;
            // 
            // TenLoai
            // 
            this.TenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TenLoai.DataPropertyName = "TenLoai";
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.MinimumWidth = 6;
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            this.TenLoai.Width = 81;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "TenNCC";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            this.TenNCC.Visible = false;
            this.TenNCC.Width = 81;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Visible = false;
            this.TrangThai.Width = 99;
            // 
            // NhapHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 718);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhapHangGUI";
            this.Text = "NhapHangGUI";
            this.Load += new System.EventHandler(this.NhapHangGUI_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.flpFilter.ResumeLayout(false);
            this.pnThongTinSP.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label lblMaPN;
        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flpGioHangNhap;
        private MyCustom.GradientPanel gradientPanel2;
        private MyCustom.RJButton btnInHoaDon;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label24;
        private MyCustom.RJButton btnThanhToan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.FlowLayoutPanel flpNhaCungCap;
        private System.Windows.Forms.Panel pnThongTinSP;
        private System.Windows.Forms.Label label1;
        private MyCustom.RJTextBox txtMaSP;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJTextBox txtTonKho;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MyCustom.CustomNumericUpDown nudSoLuongMua;
        private MyCustom.RJButton btnChonSanPham;
        private MyCustom.RJButton rjButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.FlowLayoutPanel flpFilter;
        private MyCustom.BiggerCheckBox chkGia;
        private System.Windows.Forms.Label label23;
        private MyCustom.RJTextBox txtGiaStart;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJTextBox txtGiaEnd;
        private System.Windows.Forms.Label lblErrGiaFilter;
        private MyCustom.BiggerCheckBox chkTonKho;
        private System.Windows.Forms.Label label25;
        private MyCustom.RJTextBox txtTonKhoStart;
        private System.Windows.Forms.Label label12;
        private MyCustom.RJTextBox txtTonKhoEnd;
        private System.Windows.Forms.Label lblErrTonKhoFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}