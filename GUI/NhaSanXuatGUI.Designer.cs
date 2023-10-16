namespace GUI
{
    partial class NhaSanXuatGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNSX = new GUI.MyCustom.RJTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNSX = new GUI.MyCustom.RJTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new GUI.MyCustom.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoDT = new GUI.MyCustom.RJTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new GUI.MyCustom.RJButton();
            this.btnSua = new GUI.MyCustom.RJButton();
            this.btnXoa = new GUI.MyCustom.RJButton();
            this.btnReset = new GUI.MyCustom.RJButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbxTimKiem = new GUI.MyCustom.RJComboBox();
            this.txtTimKiem = new GUI.MyCustom.RJTextBox();
            this.btnTimKiem = new GUI.MyCustom.RJButton();
            this.btnFilter = new GUI.MyCustom.RJButton();
            this.dgvNSX = new System.Windows.Forms.DataGridView();
            this.MaNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDTNSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dgvNSX);
            this.panel1.Controls.Add(this.flowLayoutPanel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 755);
            this.panel1.TabIndex = 0;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 754);
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
            this.label1.Text = "THÔNG TIN NHÀ SẢN XUẤT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtMaNSX);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtTenNSX);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtDiaChi);
            this.flowLayoutPanel2.Controls.Add(this.label15);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtSoDT);
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 43);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(290, 239);
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
            this.label2.Text = "Mã NSX";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtMaNSX.Location = new System.Drawing.Point(106, 4);
            this.txtMaNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNSX.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtMaNSX.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtMaNSX.Multiline = false;
            this.txtMaNSX.Name = "txtMaNSX";
            this.txtMaNSX.Padding = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.txtMaNSX.PasswordChar = false;
            this.txtMaNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaNSX.PlaceholderText = "";
            this.txtMaNSX.Size = new System.Drawing.Size(171, 28);
            this.txtMaNSX.TabIndex = 1;
            this.txtMaNSX.Texts = "";
            this.txtMaNSX.UnderlinedStyle = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label13.Size = new System.Drawing.Size(256, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "* Bạn phải nhập Mã NSX";
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
            this.label3.Text = "Tên NSX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenNSX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtTenNSX.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtTenNSX.BorderRadius = 0;
            this.txtTenNSX.BorderSize = 2;
            this.txtTenNSX.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNSX.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenNSX.Location = new System.Drawing.Point(106, 57);
            this.txtTenNSX.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNSX.MaximumSize = new System.Drawing.Size(171, 28);
            this.txtTenNSX.MinimumSize = new System.Drawing.Size(150, 28);
            this.txtTenNSX.Multiline = false;
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNSX.PasswordChar = false;
            this.txtTenNSX.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenNSX.PlaceholderText = "";
            this.txtTenNSX.Size = new System.Drawing.Size(171, 28);
            this.txtTenNSX.TabIndex = 3;
            this.txtTenNSX.Texts = "";
            this.txtTenNSX.UnderlinedStyle = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label14.Location = new System.Drawing.Point(3, 89);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label14.Size = new System.Drawing.Size(256, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "* Bạn phải nhập Tên NSX";
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
            this.label4.Text = "Địa chỉ NSX";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label15.Location = new System.Drawing.Point(3, 142);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label15.Size = new System.Drawing.Size(274, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "* Bạn phải nhập địa chỉ NSX";
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
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoDT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(190)))), ((int)(((byte)(186)))));
            this.txtSoDT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(140)))), ((int)(((byte)(137)))));
            this.txtSoDT.BorderRadius = 0;
            this.txtSoDT.BorderSize = 2;
            this.txtSoDT.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.ForeColor = System.Drawing.Color.DimGray;
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
            this.txtSoDT.TabIndex = 11;
            this.txtSoDT.Texts = "";
            this.txtSoDT.UnderlinedStyle = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Cambria", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(76)))), ((int)(((byte)(89)))));
            this.label18.Location = new System.Drawing.Point(3, 195);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.label18.Size = new System.Drawing.Size(241, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "* Bạn phải nhập số ĐT";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnThem);
            this.flowLayoutPanel3.Controls.Add(this.btnSua);
            this.flowLayoutPanel3.Controls.Add(this.btnXoa);
            this.flowLayoutPanel3.Controls.Add(this.btnReset);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(8, 290);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(290, 45);
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
            this.btnThem.Location = new System.Drawing.Point(23, 3);
            this.btnThem.Margin = new System.Windows.Forms.Padding(23, 3, 10, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(44, 40);
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
            this.btnSua.Location = new System.Drawing.Point(87, 3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(44, 40);
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
            this.btnXoa.Location = new System.Drawing.Point(151, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(44, 40);
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
            this.btnReset.Location = new System.Drawing.Point(215, 3);
            this.btnReset.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(44, 40);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "rjButton5";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.cbxTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.txtTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnTimKiem);
            this.flowLayoutPanel4.Controls.Add(this.btnFilter);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(311, 7);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(974, 50);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // cbxTimKiem
            // 
            this.cbxTimKiem.AutoCompleteCustomSource.AddRange(new string[] {
            "Tên NSX",
            "Địa Chỉ NSX",
            "Số ĐT"});
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
            this.cbxTimKiem.Texts = "Mã NSX";
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
            // dgvNSX
            // 
            this.dgvNSX.AllowUserToAddRows = false;
            this.dgvNSX.AllowUserToDeleteRows = false;
            this.dgvNSX.AllowUserToResizeColumns = false;
            this.dgvNSX.AllowUserToResizeRows = false;
            this.dgvNSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNSX.BackgroundColor = System.Drawing.Color.White;
            this.dgvNSX.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNSX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNSX.ColumnHeadersHeight = 28;
            this.dgvNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNSX,
            this.TenNSX,
            this.DiaChiNSX,
            this.SoDTNSX});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNSX.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNSX.EnableHeadersVisualStyles = false;
            this.dgvNSX.GridColor = System.Drawing.Color.Black;
            this.dgvNSX.Location = new System.Drawing.Point(311, 55);
            this.dgvNSX.Name = "dgvNSX";
            this.dgvNSX.ReadOnly = true;
            this.dgvNSX.RowHeadersVisible = false;
            this.dgvNSX.RowHeadersWidth = 51;
            this.dgvNSX.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvNSX.RowTemplate.Height = 30;
            this.dgvNSX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNSX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNSX.Size = new System.Drawing.Size(974, 683);
            this.dgvNSX.TabIndex = 4;
            // 
            // MaNSX
            // 
            this.MaNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNSX.DataPropertyName = "MaNSX";
            this.MaNSX.Frozen = true;
            this.MaNSX.HeaderText = "Mã NSX";
            this.MaNSX.MinimumWidth = 6;
            this.MaNSX.Name = "MaNSX";
            this.MaNSX.ReadOnly = true;
            this.MaNSX.Width = 200;
            // 
            // TenNSX
            // 
            this.TenNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenNSX.DataPropertyName = "TenNSX";
            this.TenNSX.HeaderText = "Tên NSX";
            this.TenNSX.MinimumWidth = 6;
            this.TenNSX.Name = "TenNSX";
            this.TenNSX.ReadOnly = true;
            this.TenNSX.Width = 200;
            // 
            // DiaChiNSX
            // 
            this.DiaChiNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiaChiNSX.DataPropertyName = "DiaChiNSX";
            this.DiaChiNSX.HeaderText = "Địa chỉ NSX";
            this.DiaChiNSX.MinimumWidth = 6;
            this.DiaChiNSX.Name = "DiaChiNSX";
            this.DiaChiNSX.ReadOnly = true;
            this.DiaChiNSX.Width = 300;
            // 
            // SoDTNSX
            // 
            this.SoDTNSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoDTNSX.DataPropertyName = "SoDTNSX";
            this.SoDTNSX.HeaderText = "Số điện thoại NSX";
            this.SoDTNSX.Name = "SoDTNSX";
            this.SoDTNSX.ReadOnly = true;
            this.SoDTNSX.Width = 300;
            // 
            // NhaSanXuatGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 763);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NhaSanXuatGUI";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "NhaSanXuatGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private MyCustom.RJTextBox txtMaNSX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private MyCustom.RJTextBox txtTenNSX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label4;
        private MyCustom.RJTextBox txtDiaChi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private MyCustom.RJTextBox txtSoDT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MyCustom.RJButton btnThem;
        private MyCustom.RJButton btnSua;
        private MyCustom.RJButton btnXoa;
        private MyCustom.RJButton btnReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MyCustom.RJComboBox cbxTimKiem;
        private MyCustom.RJTextBox txtTimKiem;
        private MyCustom.RJButton btnTimKiem;
        private MyCustom.RJButton btnFilter;
        private System.Windows.Forms.DataGridView dgvNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDTNSX;
    }
}