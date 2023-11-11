namespace GUI
{
    partial class TaiKhoanGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.rjButton1 = new GUI.MyCustom.RJButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuyen = new GUI.MyCustom.RJTextBox();
            this.txtNhanVien = new GUI.MyCustom.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayLap = new GUI.MyCustom.RJDatePicker();
            this.cbxTrangThai = new GUI.MyCustom.RJComboBox();
            this.lblErrMK = new System.Windows.Forms.Label();
            this.btnRandomPassword = new GUI.MyCustom.RJButton();
            this.lblErrGiaNhap = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatKhau = new GUI.MyCustom.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new GUI.MyCustom.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTK = new GUI.MyCustom.RJTextBox();
            this.btnThayDoiTrangThai = new GUI.MyCustom.RJButton();
            this.btnThayDoiMK = new GUI.MyCustom.RJButton();
            this.btnTaoTK = new GUI.MyCustom.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnThayDoiTrangThai);
            this.panel1.Controls.Add(this.btnThayDoiMK);
            this.panel1.Controls.Add(this.btnTaoTK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 699);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dgvNhanVien);
            this.panel2.Controls.Add(this.rjButton1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtQuyen);
            this.panel2.Controls.Add(this.txtNhanVien);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpNgayLap);
            this.panel2.Controls.Add(this.cbxTrangThai);
            this.panel2.Controls.Add(this.lblErrMK);
            this.panel2.Controls.Add(this.btnRandomPassword);
            this.panel2.Controls.Add(this.lblErrGiaNhap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMatKhau);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTenDangNhap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtMaTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1164, 626);
            this.panel2.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label10.Location = new System.Drawing.Point(597, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(418, 23);
            this.label10.TabIndex = 47;
            this.label10.Text = "DANH SÁCH NHÂN VIÊN CHƯA CÓ TÀI KHOẢN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AllowUserToResizeColumns = false;
            this.dgvNhanVien.AllowUserToResizeRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhanVien.ColumnHeadersHeight = 28;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Ho,
            this.Ten,
            this.MaTK,
            this.MaCV});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.GridColor = System.Drawing.Color.Black;
            this.dgvNhanVien.Location = new System.Drawing.Point(417, 35);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNhanVien.RowTemplate.Height = 30;
            this.dgvNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(735, 579);
            this.dgvNhanVien.TabIndex = 46;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(19, 452);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(384, 49);
            this.rjButton1.TabIndex = 45;
            this.rjButton1.Text = "ĐĂNG NHẬP";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(13, 384);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 28);
            this.label9.TabIndex = 44;
            this.label9.Text = "Trạng thái";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(15, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 28);
            this.label8.TabIndex = 43;
            this.label8.Text = "Quyền";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(13, 266);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 28);
            this.label7.TabIndex = 42;
            this.label7.Text = "Nhân viên";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuyen
            // 
            this.txtQuyen.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuyen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtQuyen.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtQuyen.BorderRadius = 0;
            this.txtQuyen.BorderSize = 2;
            this.txtQuyen.Enabled = false;
            this.txtQuyen.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuyen.ForeColor = System.Drawing.Color.Black;
            this.txtQuyen.Location = new System.Drawing.Point(159, 323);
            this.txtQuyen.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuyen.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtQuyen.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtQuyen.Multiline = false;
            this.txtQuyen.Name = "txtQuyen";
            this.txtQuyen.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtQuyen.PasswordChar = false;
            this.txtQuyen.PlaceholderColor = System.Drawing.Color.Black;
            this.txtQuyen.PlaceholderText = "";
            this.txtQuyen.ReadOnly = false;
            this.txtQuyen.Size = new System.Drawing.Size(205, 30);
            this.txtQuyen.TabIndex = 41;
            this.txtQuyen.Texts = "";
            this.txtQuyen.UnderlinedStyle = false;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.BackColor = System.Drawing.SystemColors.Window;
            this.txtNhanVien.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtNhanVien.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtNhanVien.BorderRadius = 0;
            this.txtNhanVien.BorderSize = 2;
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtNhanVien.Location = new System.Drawing.Point(159, 266);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanVien.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtNhanVien.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtNhanVien.Multiline = false;
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtNhanVien.PasswordChar = false;
            this.txtNhanVien.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNhanVien.PlaceholderText = "";
            this.txtNhanVien.ReadOnly = false;
            this.txtNhanVien.Size = new System.Drawing.Size(205, 30);
            this.txtNhanVien.TabIndex = 40;
            this.txtNhanVien.Texts = "";
            this.txtNhanVien.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(15, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ngày lập";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.dtpNgayLap.BorderSize = 2;
            this.dtpNgayLap.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtpNgayLap.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.dtpNgayLap.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(159, 214);
            this.dtpNgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLap.MaxDate = new System.DateTime(2028, 5, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MaximumSize = new System.Drawing.Size(300, 30);
            this.dtpNgayLap.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(205, 30);
            this.dtpNgayLap.SkinColor = System.Drawing.Color.White;
            this.dtpNgayLap.TabIndex = 38;
            this.dtpNgayLap.TextColor = System.Drawing.Color.Black;
            this.dtpNgayLap.Value = new System.DateTime(2023, 10, 24, 0, 0, 0, 0);
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
            this.cbxTrangThai.Location = new System.Drawing.Point(159, 382);
            this.cbxTrangThai.MinimumSize = new System.Drawing.Size(100, 5);
            this.cbxTrangThai.Name = "cbxTrangThai";
            this.cbxTrangThai.Padding = new System.Windows.Forms.Padding(2);
            this.cbxTrangThai.Size = new System.Drawing.Size(205, 30);
            this.cbxTrangThai.TabIndex = 37;
            this.cbxTrangThai.Texts = "--Chọn trạng thái--";
            // 
            // lblErrMK
            // 
            this.lblErrMK.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrMK.Location = new System.Drawing.Point(89, 193);
            this.lblErrMK.Name = "lblErrMK";
            this.lblErrMK.Size = new System.Drawing.Size(275, 17);
            this.lblErrMK.TabIndex = 36;
            this.lblErrMK.Text = "* Bạn phải nhập Tên đăng nhập";
            this.lblErrMK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRandomPassword
            // 
            this.btnRandomPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnRandomPassword.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRandomPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnRandomPassword.BorderRadius = 0;
            this.btnRandomPassword.BorderSize = 2;
            this.btnRandomPassword.FlatAppearance.BorderSize = 0;
            this.btnRandomPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomPassword.ForeColor = System.Drawing.Color.White;
            this.btnRandomPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnRandomPassword.Image")));
            this.btnRandomPassword.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRandomPassword.Location = new System.Drawing.Point(371, 160);
            this.btnRandomPassword.Name = "btnRandomPassword";
            this.btnRandomPassword.Size = new System.Drawing.Size(40, 30);
            this.btnRandomPassword.TabIndex = 35;
            this.btnRandomPassword.TextColor = System.Drawing.Color.White;
            this.btnRandomPassword.UseVisualStyleBackColor = false;
            this.btnRandomPassword.Click += new System.EventHandler(this.btnRandomPassword_Click);
            // 
            // lblErrGiaNhap
            // 
            this.lblErrGiaNhap.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.lblErrGiaNhap.Location = new System.Drawing.Point(89, 138);
            this.lblErrGiaNhap.Name = "lblErrGiaNhap";
            this.lblErrGiaNhap.Size = new System.Drawing.Size(275, 17);
            this.lblErrGiaNhap.TabIndex = 34;
            this.lblErrGiaNhap.Text = "* Bạn phải nhập Tên đăng nhập";
            this.lblErrGiaNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mật khẩu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMatKhau.BorderRadius = 0;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(159, 159);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtMatKhau.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.Black;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.ReadOnly = false;
            this.txtMatKhau.Size = new System.Drawing.Size(205, 30);
            this.txtMatKhau.TabIndex = 8;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(15, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên đăng nhập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenDangNhap.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenDangNhap.BorderRadius = 0;
            this.txtTenDangNhap.BorderSize = 2;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.Location = new System.Drawing.Point(159, 102);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtTenDangNhap.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtTenDangNhap.Multiline = false;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtTenDangNhap.PasswordChar = false;
            this.txtTenDangNhap.PlaceholderColor = System.Drawing.Color.Black;
            this.txtTenDangNhap.PlaceholderText = "";
            this.txtTenDangNhap.ReadOnly = false;
            this.txtTenDangNhap.Size = new System.Drawing.Size(205, 30);
            this.txtTenDangNhap.TabIndex = 6;
            this.txtTenDangNhap.Texts = "";
            this.txtTenDangNhap.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "TẠO TÀI KHOẢN MỚI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã TK";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaTK
            // 
            this.txtMaTK.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtMaTK.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtMaTK.BorderRadius = 0;
            this.txtMaTK.BorderSize = 2;
            this.txtMaTK.Enabled = false;
            this.txtMaTK.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTK.ForeColor = System.Drawing.Color.Black;
            this.txtMaTK.Location = new System.Drawing.Point(159, 45);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTK.MaximumSize = new System.Drawing.Size(400, 50);
            this.txtMaTK.MinimumSize = new System.Drawing.Size(150, 30);
            this.txtMaTK.Multiline = false;
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Padding = new System.Windows.Forms.Padding(4, 4, 2, 2);
            this.txtMaTK.PasswordChar = false;
            this.txtMaTK.PlaceholderColor = System.Drawing.Color.Black;
            this.txtMaTK.PlaceholderText = "";
            this.txtMaTK.ReadOnly = false;
            this.txtMaTK.Size = new System.Drawing.Size(205, 30);
            this.txtMaTK.TabIndex = 3;
            this.txtMaTK.Texts = "";
            this.txtMaTK.UnderlinedStyle = false;
            // 
            // btnThayDoiTrangThai
            // 
            this.btnThayDoiTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoiTrangThai.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThayDoiTrangThai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnThayDoiTrangThai.BorderRadius = 20;
            this.btnThayDoiTrangThai.BorderSize = 2;
            this.btnThayDoiTrangThai.FlatAppearance.BorderSize = 0;
            this.btnThayDoiTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoiTrangThai.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoiTrangThai.ForeColor = System.Drawing.Color.Black;
            this.btnThayDoiTrangThai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiTrangThai.Location = new System.Drawing.Point(548, 9);
            this.btnThayDoiTrangThai.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnThayDoiTrangThai.Name = "btnThayDoiTrangThai";
            this.btnThayDoiTrangThai.Size = new System.Drawing.Size(160, 40);
            this.btnThayDoiTrangThai.TabIndex = 7;
            this.btnThayDoiTrangThai.Text = "Thay đổi trạng thái";
            this.btnThayDoiTrangThai.TextColor = System.Drawing.Color.Black;
            this.btnThayDoiTrangThai.UseVisualStyleBackColor = false;
            this.btnThayDoiTrangThai.Click += new System.EventHandler(this.btnThayDoiTrangThai_Click);
            // 
            // btnThayDoiMK
            // 
            this.btnThayDoiMK.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoiMK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThayDoiMK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnThayDoiMK.BorderRadius = 20;
            this.btnThayDoiMK.BorderSize = 2;
            this.btnThayDoiMK.FlatAppearance.BorderSize = 0;
            this.btnThayDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThayDoiMK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThayDoiMK.ForeColor = System.Drawing.Color.Black;
            this.btnThayDoiMK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThayDoiMK.Location = new System.Drawing.Point(366, 9);
            this.btnThayDoiMK.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnThayDoiMK.Name = "btnThayDoiMK";
            this.btnThayDoiMK.Size = new System.Drawing.Size(160, 40);
            this.btnThayDoiMK.TabIndex = 6;
            this.btnThayDoiMK.Text = "Thay đổi mật khẩu";
            this.btnThayDoiMK.TextColor = System.Drawing.Color.Black;
            this.btnThayDoiMK.UseVisualStyleBackColor = false;
            this.btnThayDoiMK.Click += new System.EventHandler(this.btnThayDoiMK_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoTK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTaoTK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.btnTaoTK.BorderRadius = 20;
            this.btnTaoTK.BorderSize = 2;
            this.btnTaoTK.FlatAppearance.BorderSize = 0;
            this.btnTaoTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoTK.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.ForeColor = System.Drawing.Color.Black;
            this.btnTaoTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoTK.Location = new System.Drawing.Point(219, 9);
            this.btnTaoTK.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(126, 40);
            this.btnTaoTK.TabIndex = 3;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.TextColor = System.Drawing.Color.Black;
            this.btnTaoTK.UseVisualStyleBackColor = false;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHỌN CHỨC NĂNG:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.Frozen = true;
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 73;
            // 
            // Ho
            // 
            this.Ho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ho.DataPropertyName = "Ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.MinimumWidth = 6;
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // MaTK
            // 
            this.MaTK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaTK.DataPropertyName = "MaTK";
            this.MaTK.HeaderText = "Mã TK";
            this.MaTK.Name = "MaTK";
            this.MaTK.ReadOnly = true;
            this.MaTK.Width = 72;
            // 
            // MaCV
            // 
            this.MaCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Chức vụ";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            this.MaCV.ReadOnly = true;
            this.MaCV.Width = 83;
            // 
            // TaiKhoanGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 699);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoanGUI";
            this.Text = "TaiKhoanGUI";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MyCustom.RJButton btnThayDoiTrangThai;
        private MyCustom.RJButton btnThayDoiMK;
        private MyCustom.RJButton btnTaoTK;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MyCustom.RJTextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtTenDangNhap;
        private MyCustom.RJButton btnRandomPassword;
        private System.Windows.Forms.Label lblErrGiaNhap;
        private System.Windows.Forms.Label lblErrMK;
        private MyCustom.RJComboBox cbxTrangThai;
        private MyCustom.RJTextBox txtQuyen;
        private MyCustom.RJTextBox txtNhanVien;
        private System.Windows.Forms.Label label6;
        private MyCustom.RJDatePicker dtpNgayLap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJButton rjButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
    }
}