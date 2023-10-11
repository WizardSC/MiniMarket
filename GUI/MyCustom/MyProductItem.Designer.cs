namespace GUI.MyCustom
{
    partial class MyProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.pbxIMG = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblMaSP);
            this.panel1.Controls.Add(this.lblDonGia);
            this.panel1.Controls.Add(this.lblTenSP);
            this.panel1.Controls.Add(this.pbxIMG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 162);
            this.panel1.TabIndex = 0;
            // 
            // lblMaSP
            // 
            this.lblMaSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(2, 0);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(57, 23);
            this.lblMaSP.TabIndex = 8;
            this.lblMaSP.Text = "SP001";
            // 
            // lblDonGia
            // 
            this.lblDonGia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(65, 0);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(84, 23);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.Text = "45000đ";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoEllipsis = true;
            this.lblTenSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(2, 23);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblTenSP.Size = new System.Drawing.Size(147, 23);
            this.lblTenSP.TabIndex = 10;
            this.lblTenSP.Text = "Bánh quy Cosy Marie";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxIMG
            // 
            this.pbxIMG.Image = global::GUI.Properties.Resources.placeholder_image;
            this.pbxIMG.Location = new System.Drawing.Point(17, 49);
            this.pbxIMG.Name = "pbxIMG";
            this.pbxIMG.Size = new System.Drawing.Size(115, 93);
            this.pbxIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIMG.TabIndex = 11;
            this.pbxIMG.TabStop = false;
            // 
            // MyProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MyProductItem";
            this.Size = new System.Drawing.Size(149, 162);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label lblDonGia;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.PictureBox pbxIMG;
    }
}
