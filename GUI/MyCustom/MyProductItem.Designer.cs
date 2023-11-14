using System;

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
            this.pnItem = new System.Windows.Forms.Panel();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.pbxIMG = new System.Windows.Forms.PictureBox();
            this.pnItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // pnItem
            // 
            this.pnItem.BackColor = System.Drawing.Color.White;
            this.pnItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnItem.Controls.Add(this.lblMaSP);
            this.pnItem.Controls.Add(this.lblDonGia);
            this.pnItem.Controls.Add(this.lblTenSP);
            this.pnItem.Controls.Add(this.pbxIMG);
            this.pnItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnItem.Location = new System.Drawing.Point(0, 0);
            this.pnItem.Name = "pnItem";
            this.pnItem.Size = new System.Drawing.Size(245, 108);
            this.pnItem.TabIndex = 0;
            // 
            // lblMaSP
            // 
            this.lblMaSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(8, 4);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(57, 23);
            this.lblMaSP.TabIndex = 8;
            this.lblMaSP.Text = "SP001";
            this.lblMaSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(154, 7);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(84, 23);
            this.lblDonGia.TabIndex = 9;
            this.lblDonGia.Text = "45000đ";
            this.lblDonGia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoEllipsis = true;
            this.lblTenSP.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(96, 31);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(142, 64);
            this.lblTenSP.TabIndex = 10;
            this.lblTenSP.Text = "Bánh quy Cosy MarieBánh quy Cosy Marie";
            this.lblTenSP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxIMG
            // 
            this.pbxIMG.Image = global::GUI.Properties.Resources.placeholder_image;
            this.pbxIMG.Location = new System.Drawing.Point(11, 30);
            this.pbxIMG.Name = "pbxIMG";
            this.pbxIMG.Size = new System.Drawing.Size(77, 65);
            this.pbxIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIMG.TabIndex = 11;
            this.pbxIMG.TabStop = false;
            // 
            // MyProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnItem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MyProductItem";
            this.Size = new System.Drawing.Size(245, 108);
            this.pnItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnItem;
        public System.Windows.Forms.Label lblMaSP;
        public System.Windows.Forms.Label lblDonGia;
        public System.Windows.Forms.Label lblTenSP;
        public System.Windows.Forms.PictureBox pbxIMG;
    }
}
