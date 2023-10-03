namespace GUI
{
    partial class GiaoDienGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienGUI));
            this.pnSidebar = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new CustomControls.RJControls.RJButton();
            this.btnClose = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnImage = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnSidebar.SuspendLayout();
            this.pnHeader.SuspendLayout();
            this.pnForm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSidebar
            // 
            this.pnSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            this.pnSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSidebar.Controls.Add(this.panel2);
            this.pnSidebar.Controls.Add(this.pnImage);
            this.pnSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSidebar.Location = new System.Drawing.Point(0, 35);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Size = new System.Drawing.Size(190, 763);
            this.pnSidebar.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(190, 35);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1208, 35);
            this.pnMenu.TabIndex = 2;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.pnHeader.Controls.Add(this.btnMinimize);
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Controls.Add(this.btnClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1398, 35);
            this.pnHeader.TabIndex = 3;
            // 
            // pnForm
            // 
            this.pnForm.BackColor = System.Drawing.Color.White;
            this.pnForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnForm.Controls.Add(this.pictureBox2);
            this.pnForm.Controls.Add(this.button1);
            this.pnForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForm.Location = new System.Drawing.Point(0, 0);
            this.pnForm.Name = "pnForm";
            this.pnForm.Size = new System.Drawing.Size(1398, 798);
            this.pnForm.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1220, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnMenu);
            this.panel3.Controls.Add(this.pnSidebar);
            this.panel3.Controls.Add(this.pnHeader);
            this.panel3.Controls.Add(this.pnForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 800);
            this.panel3.TabIndex = 0;
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
            this.btnMinimize.Location = new System.Drawing.Point(1306, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 35);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
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
            this.btnClose.Location = new System.Drawing.Point(1355, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1349, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 35);
            this.panel1.TabIndex = 3;
            // 
            // pnImage
            // 
            this.pnImage.Controls.Add(this.pictureBox1);
            this.pnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnImage.Location = new System.Drawing.Point(0, 0);
            this.pnImage.Name = "pnImage";
            this.pnImage.Size = new System.Drawing.Size(188, 144);
            this.pnImage.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 40);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 40);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(328, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(8, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 40);
            this.panel5.TabIndex = 1;
            // 
            // GiaoDienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GiaoDienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GiaoDienGUI";
            this.pnSidebar.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnForm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private CustomControls.RJControls.RJButton btnClose;
        private CustomControls.RJControls.RJButton btnMinimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}