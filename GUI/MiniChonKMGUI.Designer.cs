namespace GUI
{
    partial class MiniChonKMGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiniChonKMGUI));
            this.panel3 = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new GUI.MyCustom.GradientPanel();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKhongApDungKM = new GUI.MyCustom.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXacNhan = new GUI.MyCustom.RJButton();
            this.btnHuyBo = new GUI.MyCustom.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKM = new GUI.MyCustom.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKM = new GUI.MyCustom.RJTextBox();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMinimize = new GUI.MyCustom.RJButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new GUI.MyCustom.RJButton();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieuKienKMCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 426);
            this.panel3.TabIndex = 6;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoScroll = true;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            this.gradientPanel1.Controls.Add(this.dgvKhuyenMai);
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 35);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(815, 389);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.TopColor = System.Drawing.Color.White;
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
            this.PhanTramKM,
            this.DieuKienKMCol,
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
            this.dgvKhuyenMai.Location = new System.Drawing.Point(12, 13);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvKhuyenMai.RowTemplate.Height = 30;
            this.dgvKhuyenMai.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvKhuyenMai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(792, 243);
            this.dgvKhuyenMai.TabIndex = 5;
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            this.dgvKhuyenMai.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvKhuyenMai_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnKhongApDungKM);
            this.panel2.Location = new System.Drawing.Point(611, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 112);
            this.panel2.TabIndex = 4;
            // 
            // btnKhongApDungKM
            // 
            this.btnKhongApDungKM.BackColor = System.Drawing.Color.Transparent;
            this.btnKhongApDungKM.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnKhongApDungKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnKhongApDungKM.BorderRadius = 20;
            this.btnKhongApDungKM.BorderSize = 2;
            this.btnKhongApDungKM.FlatAppearance.BorderSize = 0;
            this.btnKhongApDungKM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhongApDungKM.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongApDungKM.ForeColor = System.Drawing.Color.Black;
            this.btnKhongApDungKM.Image = ((System.Drawing.Image)(resources.GetObject("btnKhongApDungKM.Image")));
            this.btnKhongApDungKM.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnKhongApDungKM.Location = new System.Drawing.Point(20, 26);
            this.btnKhongApDungKM.Margin = new System.Windows.Forms.Padding(30, 3, 10, 3);
            this.btnKhongApDungKM.Name = "btnKhongApDungKM";
            this.btnKhongApDungKM.Size = new System.Drawing.Size(149, 64);
            this.btnKhongApDungKM.TabIndex = 3;
            this.btnKhongApDungKM.Text = "        Không áp dụng khuyến mãi";
            this.btnKhongApDungKM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhongApDungKM.TextColor = System.Drawing.Color.Black;
            this.btnKhongApDungKM.UseVisualStyleBackColor = false;
            this.btnKhongApDungKM.Click += new System.EventHandler(this.btnKhongApDungKM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTenKM);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaKM);
            this.panel1.Location = new System.Drawing.Point(12, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 112);
            this.panel1.TabIndex = 3;
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
            this.btnXacNhan.Location = new System.Drawing.Point(428, 11);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(120, 40);
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
            this.btnHuyBo.Location = new System.Drawing.Point(428, 57);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(120, 40);
            this.btnHuyBo.TabIndex = 1;
            this.btnHuyBo.Text = "       Hủy bỏ";
            this.btnHuyBo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.TextColor = System.Drawing.Color.Black;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ tên KH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenKM
            // 
            this.txtTenKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenKM.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenKM.BorderRadius = 0;
            this.txtTenKM.BorderSize = 2;
            this.txtTenKM.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKM.ForeColor = System.Drawing.Color.Black;
            this.txtTenKM.Location = new System.Drawing.Point(114, 62);
            this.txtTenKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKM.MaximumSize = new System.Drawing.Size(300, 28);
            this.txtTenKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTenKM.Multiline = false;
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtTenKM.PasswordChar = false;
            this.txtTenKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKM.PlaceholderText = "";
            this.txtTenKM.ReadOnly = false;
            this.txtTenKM.Size = new System.Drawing.Size(300, 28);
            this.txtTenKM.TabIndex = 5;
            this.txtTenKM.Texts = "";
            this.txtTenKM.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã KH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtMaKM.Location = new System.Drawing.Point(114, 17);
            this.txtMaKM.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKM.MaximumSize = new System.Drawing.Size(300, 28);
            this.txtMaKM.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaKM.Multiline = false;
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtMaKM.PasswordChar = false;
            this.txtMaKM.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKM.PlaceholderText = "";
            this.txtMaKM.ReadOnly = false;
            this.txtMaKM.Size = new System.Drawing.Size(300, 28);
            this.txtMaKM.TabIndex = 3;
            this.txtMaKM.Texts = "";
            this.txtMaKM.UnderlinedStyle = false;
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
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(815, 35);
            this.pnHeader.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(292, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "       CHỌN KHUYẾN MÃI";
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
            this.btnMinimize.Location = new System.Drawing.Point(723, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(766, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 35);
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
            this.btnClose.Location = new System.Drawing.Point(772, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MaKM
            // 
            this.MaKM.DataPropertyName = "MaKM";
            this.MaKM.HeaderText = "Mã KM";
            this.MaKM.Name = "MaKM";
            this.MaKM.ReadOnly = true;
            this.MaKM.Width = 75;
            // 
            // TenKM
            // 
            this.TenKM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKM.DataPropertyName = "TenKM";
            this.TenKM.HeaderText = "Tên KM";
            this.TenKM.MinimumWidth = 6;
            this.TenKM.Name = "TenKM";
            this.TenKM.ReadOnly = true;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.ReadOnly = true;
            this.NgayBatDau.Width = 113;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.ReadOnly = true;
            this.NgayKetThuc.Width = 118;
            // 
            // PhanTramKM
            // 
            this.PhanTramKM.DataPropertyName = "PhanTramKM";
            this.PhanTramKM.HeaderText = "Phần trăm KM";
            this.PhanTramKM.Name = "PhanTramKM";
            this.PhanTramKM.ReadOnly = true;
            this.PhanTramKM.Width = 121;
            // 
            // DieuKienKMCol
            // 
            this.DieuKienKMCol.DataPropertyName = "DieuKienKM";
            this.DieuKienKMCol.HeaderText = "Điều kiện KM";
            this.DieuKienKMCol.Name = "DieuKienKMCol";
            this.DieuKienKMCol.ReadOnly = true;
            this.DieuKienKMCol.Width = 115;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 95;
            // 
            // MiniChonKMGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 426);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MiniChonKMGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniChonKMGUI";
            this.Load += new System.EventHandler(this.MiniChonKMGUI_Load);
            this.panel3.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private MyCustom.RJTextBox txtTenKM;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaKM;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJButton btnMinimize;
        private System.Windows.Forms.Panel panel4;
        private MyCustom.RJButton btnClose;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private MyCustom.RJButton btnKhongApDungKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieuKienKMCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}