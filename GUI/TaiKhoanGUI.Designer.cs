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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoanGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrGiaNhap = new System.Windows.Forms.Label();
            this.lblErrMK = new System.Windows.Forms.Label();
            this.btnRandomPassword = new GUI.MyCustom.RJButton();
            this.txtMatKhau = new GUI.MyCustom.RJTextBox();
            this.txtTenDangNhap = new GUI.MyCustom.RJTextBox();
            this.txtMaTK = new GUI.MyCustom.RJTextBox();
            this.btnThayDoiTrangThai = new GUI.MyCustom.RJButton();
            this.btnThayDoiMK = new GUI.MyCustom.RJButton();
            this.btnTaoTK = new GUI.MyCustom.RJButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
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
            this.btnRandomPassword.Location = new System.Drawing.Point(371, 159);
            this.btnRandomPassword.Name = "btnRandomPassword";
            this.btnRandomPassword.Size = new System.Drawing.Size(40, 30);
            this.btnRandomPassword.TabIndex = 35;
            this.btnRandomPassword.TextColor = System.Drawing.Color.White;
            this.btnRandomPassword.UseVisualStyleBackColor = false;
            this.btnRandomPassword.Click += new System.EventHandler(this.btnRandomPassword_Click);
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
    }
}