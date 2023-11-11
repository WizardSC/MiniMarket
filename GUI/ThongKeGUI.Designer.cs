namespace GUI
{
    partial class ThongKeGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.chartSPTheoGioiTinh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtHienThi = new GUI.MyCustom.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTopSPBanChay = new System.Windows.Forms.DataGridView();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBanRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.pnBoxThongKe = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSelectThangNam = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxChonNam = new GUI.MyCustom.RJComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxChonThang = new GUI.MyCustom.RJComboBox();
            this.panel1.SuspendLayout();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSPTheoGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSPBanChay)).BeginInit();
            this.pnBoxThongKe.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnSelectThangNam.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnMain);
            this.panel1.Controls.Add(this.pnBoxThongKe);
            this.panel1.Controls.Add(this.pnSelectThangNam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 738);
            this.panel1.TabIndex = 0;
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.chartSPTheoGioiTinh);
            this.pnMain.Controls.Add(this.txtHienThi);
            this.pnMain.Controls.Add(this.label13);
            this.pnMain.Controls.Add(this.chartDoanhThu);
            this.pnMain.Controls.Add(this.dgvTopSPBanChay);
            this.pnMain.Controls.Add(this.label10);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 223);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1180, 515);
            this.pnMain.TabIndex = 5;
            // 
            // chartSPTheoGioiTinh
            // 
            chartArea3.Name = "chartSPTheoGioiTinh";
            this.chartSPTheoGioiTinh.ChartAreas.Add(chartArea3);
            legend2.BorderWidth = 2;
            legend2.Name = "Legend1";
            this.chartSPTheoGioiTinh.Legends.Add(legend2);
            this.chartSPTheoGioiTinh.Location = new System.Drawing.Point(927, 303);
            this.chartSPTheoGioiTinh.Name = "chartSPTheoGioiTinh";
            this.chartSPTheoGioiTinh.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartSPTheoGioiTinh.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(255)))), ((int)(((byte)(225))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(191)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))))};
            series3.ChartArea = "chartSPTheoGioiTinh";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "chartSPTheoGioiTinh";
            this.chartSPTheoGioiTinh.Series.Add(series3);
            this.chartSPTheoGioiTinh.Size = new System.Drawing.Size(248, 204);
            this.chartSPTheoGioiTinh.TabIndex = 11;
            title3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            title3.Name = "Title1";
            title3.Text = "Theo giới tính";
            this.chartSPTheoGioiTinh.Titles.Add(title3);
            // 
            // txtHienThi
            // 
            this.txtHienThi.BackColor = System.Drawing.SystemColors.Window;
            this.txtHienThi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtHienThi.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtHienThi.BorderRadius = 0;
            this.txtHienThi.BorderSize = 2;
            this.txtHienThi.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienThi.ForeColor = System.Drawing.Color.Black;
            this.txtHienThi.Location = new System.Drawing.Point(1123, 3);
            this.txtHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHienThi.MaximumSize = new System.Drawing.Size(1000, 26);
            this.txtHienThi.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtHienThi.Multiline = false;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtHienThi.PasswordChar = false;
            this.txtHienThi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHienThi.PlaceholderText = "";
            this.txtHienThi.ReadOnly = false;
            this.txtHienThi.Size = new System.Drawing.Size(52, 26);
            this.txtHienThi.TabIndex = 9;
            this.txtHienThi.Texts = "";
            this.txtHienThi.UnderlinedStyle = false;
            this.txtHienThi._TextChanged += new System.EventHandler(this.txtHienThi__TextChanged);
            this.txtHienThi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHienThi_KeyPress);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1046, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 24);
            this.label13.TabIndex = 9;
            this.label13.Text = "Hiển thị:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartDoanhThu
            // 
            chartArea4.Name = "chartDoanhThu";
            this.chartDoanhThu.ChartAreas.Add(chartArea4);
            this.chartDoanhThu.Location = new System.Drawing.Point(3, 0);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "chartDoanhThu";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Name = "chartDoanhThu";
            this.chartDoanhThu.Series.Add(series4);
            this.chartDoanhThu.Size = new System.Drawing.Size(551, 343);
            this.chartDoanhThu.TabIndex = 1;
            title4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            title4.Name = "Title1";
            title4.Text = "DOANH THU THEO THÁNG";
            this.chartDoanhThu.Titles.Add(title4);
            // 
            // dgvTopSPBanChay
            // 
            this.dgvTopSPBanChay.AllowUserToAddRows = false;
            this.dgvTopSPBanChay.AllowUserToDeleteRows = false;
            this.dgvTopSPBanChay.AllowUserToResizeColumns = false;
            this.dgvTopSPBanChay.AllowUserToResizeRows = false;
            this.dgvTopSPBanChay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTopSPBanChay.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSPBanChay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopSPBanChay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTopSPBanChay.ColumnHeadersHeight = 28;
            this.dgvTopSPBanChay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSP,
            this.SoLuongBanRa});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopSPBanChay.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTopSPBanChay.EnableHeadersVisualStyles = false;
            this.dgvTopSPBanChay.GridColor = System.Drawing.Color.Black;
            this.dgvTopSPBanChay.Location = new System.Drawing.Point(637, 30);
            this.dgvTopSPBanChay.Name = "dgvTopSPBanChay";
            this.dgvTopSPBanChay.ReadOnly = true;
            this.dgvTopSPBanChay.RowHeadersVisible = false;
            this.dgvTopSPBanChay.RowHeadersWidth = 51;
            this.dgvTopSPBanChay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTopSPBanChay.RowTemplate.Height = 30;
            this.dgvTopSPBanChay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTopSPBanChay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSPBanChay.Size = new System.Drawing.Size(538, 267);
            this.dgvTopSPBanChay.TabIndex = 2;
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
            // SoLuongBanRa
            // 
            this.SoLuongBanRa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SoLuongBanRa.DataPropertyName = "SoLuongBanRa";
            this.SoLuongBanRa.HeaderText = "Số lượng bán ra";
            this.SoLuongBanRa.MinimumWidth = 6;
            this.SoLuongBanRa.Name = "SoLuongBanRa";
            this.SoLuongBanRa.ReadOnly = true;
            this.SoLuongBanRa.Width = 129;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label10.Location = new System.Drawing.Point(818, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "SẢN PHẨM BÁN CHẠY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBoxThongKe
            // 
            this.pnBoxThongKe.Controls.Add(this.panel6);
            this.pnBoxThongKe.Controls.Add(this.panel5);
            this.pnBoxThongKe.Controls.Add(this.panel4);
            this.pnBoxThongKe.Controls.Add(this.panel3);
            this.pnBoxThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBoxThongKe.Location = new System.Drawing.Point(0, 35);
            this.pnBoxThongKe.Name = "pnBoxThongKe";
            this.pnBoxThongKe.Size = new System.Drawing.Size(1180, 188);
            this.pnBoxThongKe.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(927, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 147);
            this.panel6.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(3, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 44);
            this.label8.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(97, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 47);
            this.label5.TabIndex = 4;
            this.label5.Text = "SẢN PHẨM BÁN RA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(630, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 147);
            this.panel5.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 44);
            this.label7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(93, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 47);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐƠN HÀNG THÁNG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(333, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 147);
            this.panel4.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 44);
            this.label6.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(82, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "DOANH THU THÁNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblKhachHang);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(36, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 147);
            this.panel3.TabIndex = 0;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.BackColor = System.Drawing.Color.White;
            this.lblKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKhachHang.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.ForeColor = System.Drawing.Color.Black;
            this.lblKhachHang.Location = new System.Drawing.Point(128, 86);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(72, 46);
            this.lblKhachHang.TabIndex = 7;
            this.lblKhachHang.Text = "20";
            this.lblKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 44);
            this.label9.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(92, -2);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "KHÁCH HÀNG ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 36);
            this.label1.TabIndex = 0;
            // 
            // pnSelectThangNam
            // 
            this.pnSelectThangNam.Controls.Add(this.label12);
            this.pnSelectThangNam.Controls.Add(this.cbxChonNam);
            this.pnSelectThangNam.Controls.Add(this.label11);
            this.pnSelectThangNam.Controls.Add(this.cbxChonThang);
            this.pnSelectThangNam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSelectThangNam.Location = new System.Drawing.Point(0, 0);
            this.pnSelectThangNam.Name = "pnSelectThangNam";
            this.pnSelectThangNam.Size = new System.Drawing.Size(1180, 35);
            this.pnSelectThangNam.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label12.Location = new System.Drawing.Point(205, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "Năm:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxChonNam
            // 
            this.cbxChonNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxChonNam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxChonNam.BorderSize = 2;
            this.cbxChonNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxChonNam.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChonNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxChonNam.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxChonNam.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxChonNam.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxChonNam.Location = new System.Drawing.Point(278, 2);
            this.cbxChonNam.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.cbxChonNam.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxChonNam.Name = "cbxChonNam";
            this.cbxChonNam.Padding = new System.Windows.Forms.Padding(2);
            this.cbxChonNam.Size = new System.Drawing.Size(108, 30);
            this.cbxChonNam.TabIndex = 7;
            this.cbxChonNam.Texts = "--Chọn--";
            this.cbxChonNam.OnSelectedIndexChanged += new System.EventHandler(this.cbxChonNam_OnSelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label11.Location = new System.Drawing.Point(0, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 24);
            this.label11.TabIndex = 6;
            this.label11.Text = "Tháng:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxChonThang
            // 
            this.cbxChonThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxChonThang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxChonThang.BorderSize = 2;
            this.cbxChonThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxChonThang.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChonThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxChonThang.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.cbxChonThang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.cbxChonThang.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.cbxChonThang.Location = new System.Drawing.Point(73, 2);
            this.cbxChonThang.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.cbxChonThang.MinimumSize = new System.Drawing.Size(100, 30);
            this.cbxChonThang.Name = "cbxChonThang";
            this.cbxChonThang.Padding = new System.Windows.Forms.Padding(2);
            this.cbxChonThang.Size = new System.Drawing.Size(108, 30);
            this.cbxChonThang.TabIndex = 5;
            this.cbxChonThang.Texts = "--Chọn--";
            this.cbxChonThang.OnSelectedIndexChanged += new System.EventHandler(this.cbxChonThang_OnSelectedIndexChanged);
            // 
            // ThongKeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 738);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKeGUI";
            this.panel1.ResumeLayout(false);
            this.pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSPTheoGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSPBanChay)).EndInit();
            this.pnBoxThongKe.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnSelectThangNam.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnBoxThongKe;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataGridView dgvTopSPBanChay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBanRa;
        private System.Windows.Forms.Panel pnSelectThangNam;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label label12;
        private MyCustom.RJComboBox cbxChonNam;
        private System.Windows.Forms.Label label11;
        private MyCustom.RJComboBox cbxChonThang;
        private System.Windows.Forms.Label label13;
        private MyCustom.RJTextBox txtHienThi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSPTheoGioiTinh;
        private System.Windows.Forms.Label lblKhachHang;
    }
}