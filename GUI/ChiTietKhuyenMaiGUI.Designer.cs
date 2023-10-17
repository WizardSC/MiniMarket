namespace GUI
{
    partial class ChiTietKhuyenMaiGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChiTietKhuyenMaiGUI));
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvChiTietKM = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.txtMaKM = new GUI.MyCustom.RJTextBox();
            this.txtTenKm = new GUI.MyCustom.RJTextBox();
            this.dtpNgayBD = new GUI.MyCustom.RJDatePicker();
            this.dtpNgayKT = new GUI.MyCustom.RJDatePicker();
            this.txtPhanTramKM = new GUI.MyCustom.RJTextBox();
            this.txtDkKM = new GUI.MyCustom.RJTextBox();
            this.cbxTrangThai = new GUI.MyCustom.RJComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemCTKM = new GUI.MyCustom.RJButton();
            this.btnUpdateKM = new GUI.MyCustom.RJButton();
            this.btnXoaKM = new GUI.MyCustom.RJButton();
            this.btnRS = new GUI.MyCustom.RJButton();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKM)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.dgvChiTietKM);
            this.panel3.Location = new System.Drawing.Point(322, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(676, 482);
            this.panel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(5, 6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(666, 50);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // dgvChiTietKM
            // 
            this.dgvChiTietKM.AllowUserToAddRows = false;
            this.dgvChiTietKM.AllowUserToDeleteRows = false;
            this.dgvChiTietKM.AllowUserToResizeColumns = false;
            this.dgvChiTietKM.AllowUserToResizeRows = false;
            this.dgvChiTietKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvChiTietKM.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietKM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietKM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietKM.ColumnHeadersHeight = 28;
            this.dgvChiTietKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.Masp,
            this.TenKM,
            this.TenSp,
            this.PhanTramKm,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietKM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietKM.EnableHeadersVisualStyles = false;
            this.dgvChiTietKM.GridColor = System.Drawing.Color.Black;
            this.dgvChiTietKM.Location = new System.Drawing.Point(9, 62);
            this.dgvChiTietKM.Name = "dgvChiTietKM";
            this.dgvChiTietKM.ReadOnly = true;
            this.dgvChiTietKM.RowHeadersVisible = false;
            this.dgvChiTietKM.RowHeadersWidth = 51;
            this.dgvChiTietKM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvChiTietKM.RowTemplate.Height = 30;
            this.dgvChiTietKM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvChiTietKM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietKM.Size = new System.Drawing.Size(666, 417);
            this.dgvChiTietKM.TabIndex = 1;
            this.dgvChiTietKM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietKM_CellContentClick);
            // 
            // MaKM
            // 
            this.MaKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaKM.DataPropertyName = "MaKM";
            this.MaKM.Frozen = true;
            this.MaKM.HeaderText = "Mã KM";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.ReadOnly = true;
            this.MaKM.Width = 75;
            // 
            // Masp
            // 
            this.Masp.DataPropertyName = "MaSP";
            this.Masp.HeaderText = "Mã SP";
            this.Masp.Name = "Masp";
            this.Masp.ReadOnly = true;
            this.Masp.Width = 70;
            // 
            // TenKM
            // 
            this.TenKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenKM.DataPropertyName = "TenKM";
            this.TenKM.HeaderText = "Tên KM";
            this.TenKM.MinimumWidth = 6;
            this.TenKM.Name = "TenKM";
            this.TenKM.ReadOnly = true;
            this.TenKM.Width = 150;
            // 
            // TenSp
            // 
            this.TenSp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSp.DataPropertyName = "TenSP";
            this.TenSp.HeaderText = "Tên SP";
            this.TenSp.MinimumWidth = 6;
            this.TenSp.Name = "TenSp";
            this.TenSp.ReadOnly = true;
            this.TenSp.Width = 150;
            // 
            // PhanTramKm
            // 
            this.PhanTramKm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PhanTramKm.DataPropertyName = "PhanTramKM";
            this.PhanTramKm.HeaderText = "Phần trăm KM";
            this.PhanTramKm.MinimumWidth = 6;
            this.PhanTramKm.Name = "PhanTramKm";
            this.PhanTramKm.ReadOnly = true;
            this.PhanTramKm.Width = 121;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 95;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(316, 482);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CHI TIẾT KHUYỄN MÃI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(298, 372);
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
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã KH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label13.Size = new System.Drawing.Size(256, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "* Bạn phải nhập Mã KM";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(3, 146);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label6.Size = new System.Drawing.Size(256, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "* Bạn phải ngày bắt đầu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.label8.Size = new System.Drawing.Size(256, 19);
            this.label8.TabIndex = 30;
            this.label8.Text = "* Bạn phải ngày kết thúc";
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
            this.label10.Size = new System.Drawing.Size(243, 19);
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
            this.label12.Text = "* Bạn phải nhập Dk KM";
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
            this.panel1.Size = new System.Drawing.Size(1002, 486);
            this.panel1.TabIndex = 3;
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
            this.cbxTimKiem.Items.AddRange(new object[] {
            "TenKM"});
            this.cbxTimKiem.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTimKiem.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxTimKiem.Location = new System.Drawing.Point(4, 8);
            this.cbxTimKiem.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.cbxTimKiem.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxTimKiem.Name = "cbxTimKiem";
            this.cbxTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.cbxTimKiem.Size = new System.Drawing.Size(108, 30);
            this.cbxTimKiem.TabIndex = 4;
            this.cbxTimKiem.Texts = "Mã KM";
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
            this.txtTimKiem.Size = new System.Drawing.Size(499, 32);
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
            this.btnTimKiem.Location = new System.Drawing.Point(626, 8);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(29, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.TextColor = System.Drawing.Color.White;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtMaKM
            // 
            this.txtMaKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaKM.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaKM.BorderRadius = 0;
            this.txtMaKM.BorderSize = 2;
            this.txtMaKM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKM.ForeColor = System.Drawing.Color.Black;
            this.txtMaKM.Location = new System.Drawing.Point(106, 4);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKM.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtMaKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaKM.Multiline = false;
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtMaKM.PasswordChar = false;
            this.txtMaKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKM.PlaceholderText = "";
            this.txtMaKM.Size = new System.Drawing.Size(171, 28);
            this.txtMaKM.TabIndex = 2;
            this.txtMaKM.Texts = "";
            this.txtMaKM.UnderlinedStyle = false;
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
            this.txtTenKm.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtTenKm.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTenKm.Multiline = false;
            this.txtTenKm.Name = "txtTenKm";
            this.txtTenKm.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtTenKm.PasswordChar = false;
            this.txtTenKm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKm.PlaceholderText = "";
            this.txtTenKm.Size = new System.Drawing.Size(171, 28);
            this.txtTenKm.TabIndex = 23;
            this.txtTenKm.Texts = "";
            this.txtTenKm.UnderlinedStyle = false;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayBD.BorderSize = 2;
            this.dtpNgayBD.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayBD.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayBD.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBD.Location = new System.Drawing.Point(106, 114);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBD.MaximumSize = new System.Drawing.Size(171, 28);
            this.dtpNgayBD.MinimumSize = new System.Drawing.Size(4, 28);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(171, 28);
            this.dtpNgayBD.SkinColor = System.Drawing.Color.White;
            this.dtpNgayBD.TabIndex = 26;
            this.dtpNgayBD.TextColor = System.Drawing.Color.Black;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayKT.BorderSize = 2;
            this.dtpNgayKT.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayKT.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayKT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKT.Location = new System.Drawing.Point(106, 169);
            this.dtpNgayKT.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayKT.MaximumSize = new System.Drawing.Size(171, 28);
            this.dtpNgayKT.MinimumSize = new System.Drawing.Size(4, 28);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(171, 28);
            this.dtpNgayKT.SkinColor = System.Drawing.Color.White;
            this.dtpNgayKT.TabIndex = 29;
            this.dtpNgayKT.TextColor = System.Drawing.Color.Black;
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
            this.txtPhanTramKM.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtPhanTramKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtPhanTramKM.Multiline = false;
            this.txtPhanTramKM.Name = "txtPhanTramKM";
            this.txtPhanTramKM.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtPhanTramKM.PasswordChar = false;
            this.txtPhanTramKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhanTramKM.PlaceholderText = "";
            this.txtPhanTramKM.Size = new System.Drawing.Size(171, 28);
            this.txtPhanTramKM.TabIndex = 32;
            this.txtPhanTramKM.Texts = "";
            this.txtPhanTramKM.UnderlinedStyle = false;
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
            this.txtDkKM.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtDkKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtDkKM.Multiline = false;
            this.txtDkKM.Name = "txtDkKM";
            this.txtDkKM.Padding = new System.Windows.Forms.Padding(2);
            this.txtDkKM.PasswordChar = false;
            this.txtDkKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDkKM.PlaceholderText = "";
            this.txtDkKM.Size = new System.Drawing.Size(171, 28);
            this.txtDkKM.TabIndex = 35;
            this.txtDkKM.Texts = "";
            this.txtDkKM.UnderlinedStyle = false;
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
            this.cbxTrangThai.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxTrangThai.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxTrangThai.Location = new System.Drawing.Point(105, 333);
            this.cbxTrangThai.MinimumSize = new System.Drawing.Size(100, 5);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbxTrangThai.Size = new System.Drawing.Size(171, 28);
            this.cbxTrangThai.TabIndex = 38;
            this.cbxTrangThai.Texts = "Hoạt động";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.btnThemCTKM);
            this.flowLayoutPanel5.Controls.Add(this.btnUpdateKM);
            this.flowLayoutPanel5.Controls.Add(this.btnXoaKM);
            this.flowLayoutPanel5.Controls.Add(this.btnRS);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(8, 423);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(298, 45);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // btnThemCTKM
            // 
            this.btnThemCTKM.BackColor = System.Drawing.Color.Transparent;
            this.btnThemCTKM.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThemCTKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnThemCTKM.BorderRadius = 20;
            this.btnThemCTKM.BorderSize = 2;
            this.btnThemCTKM.FlatAppearance.BorderSize = 0;
            this.btnThemCTKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTKM.ForeColor = System.Drawing.Color.White;
            this.btnThemCTKM.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTKM.Image")));
            this.btnThemCTKM.Location = new System.Drawing.Point(33, 3);
            this.btnThemCTKM.Margin = new System.Windows.Forms.Padding(33, 3, 15, 3);
            this.btnThemCTKM.Name = "btnThemCTKM";
            this.btnThemCTKM.Size = new System.Drawing.Size(44, 40);
            this.btnThemCTKM.TabIndex = 0;
            this.btnThemCTKM.TextColor = System.Drawing.Color.White;
            this.btnThemCTKM.UseVisualStyleBackColor = false;
            // 
            // btnUpdateKM
            // 
            this.btnUpdateKM.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateKM.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnUpdateKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnUpdateKM.BorderRadius = 20;
            this.btnUpdateKM.BorderSize = 2;
            this.btnUpdateKM.FlatAppearance.BorderSize = 0;
            this.btnUpdateKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateKM.ForeColor = System.Drawing.Color.White;
            this.btnUpdateKM.Image = global::GUI.Properties.Resources.icons8_update_24;
            this.btnUpdateKM.Location = new System.Drawing.Point(102, 3);
            this.btnUpdateKM.Margin = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.btnUpdateKM.Name = "btnUpdateKM";
            this.btnUpdateKM.Size = new System.Drawing.Size(44, 40);
            this.btnUpdateKM.TabIndex = 1;
            this.btnUpdateKM.TextColor = System.Drawing.Color.White;
            this.btnUpdateKM.UseVisualStyleBackColor = false;
            // 
            // btnXoaKM
            // 
            this.btnXoaKM.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaKM.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnXoaKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnXoaKM.BorderRadius = 20;
            this.btnXoaKM.BorderSize = 2;
            this.btnXoaKM.FlatAppearance.BorderSize = 0;
            this.btnXoaKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKM.ForeColor = System.Drawing.Color.White;
            this.btnXoaKM.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKM.Image")));
            this.btnXoaKM.Location = new System.Drawing.Point(171, 3);
            this.btnXoaKM.Margin = new System.Windows.Forms.Padding(10, 3, 15, 3);
            this.btnXoaKM.Name = "btnXoaKM";
            this.btnXoaKM.Size = new System.Drawing.Size(44, 40);
            this.btnXoaKM.TabIndex = 2;
            this.btnXoaKM.TextColor = System.Drawing.Color.White;
            this.btnXoaKM.UseVisualStyleBackColor = false;
            // 
            // btnRS
            // 
            this.btnRS.BackColor = System.Drawing.Color.Transparent;
            this.btnRS.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRS.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnRS.BorderRadius = 20;
            this.btnRS.BorderSize = 2;
            this.btnRS.FlatAppearance.BorderSize = 0;
            this.btnRS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRS.ForeColor = System.Drawing.Color.White;
            this.btnRS.Image = ((System.Drawing.Image)(resources.GetObject("btnRS.Image")));
            this.btnRS.Location = new System.Drawing.Point(240, 3);
            this.btnRS.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnRS.Name = "btnRS";
            this.btnRS.Size = new System.Drawing.Size(44, 40);
            this.btnRS.TabIndex = 3;
            this.btnRS.TextColor = System.Drawing.Color.White;
            this.btnRS.UseVisualStyleBackColor = false;
            // 
            // ChiTietKhuyenMaiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 486);
            this.Controls.Add(this.panel1);
            this.Name = "ChiTietKhuyenMaiGUI";
            this.Text = "ChiTietKhuyenMaiGUI";
            this.Load += new System.EventHandler(this.ChiTietKhuyenMaiGUI_Load);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietKM)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvChiTietKM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaKM;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJTextBox txtTenKm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MyCustom.RJDatePicker dtpNgayBD;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private MyCustom.RJButton btnThemCTKM;
        private MyCustom.RJButton btnUpdateKM;
        private MyCustom.RJButton btnXoaKM;
        private MyCustom.RJButton btnRS;
    }
}