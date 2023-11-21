namespace GUI.MyCustom
{
    partial class MySuppiler
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
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.pbNhaCungCap = new System.Windows.Forms.PictureBox();
            this.pnItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // pnItem
            // 
            this.pnItem.BackColor = System.Drawing.Color.White;
            this.pnItem.Controls.Add(this.lblNhaCungCap);
            this.pnItem.Controls.Add(this.pbNhaCungCap);
            this.pnItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnItem.Location = new System.Drawing.Point(0, 0);
            this.pnItem.Name = "pnItem";
            this.pnItem.Size = new System.Drawing.Size(142, 48);
            this.pnItem.TabIndex = 0;
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoEllipsis = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.Location = new System.Drawing.Point(55, 4);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(84, 41);
            this.lblNhaCungCap.TabIndex = 1;
            this.lblNhaCungCap.Text = "Vinamilk";
            this.lblNhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbNhaCungCap
            // 
            this.pbNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNhaCungCap.InitialImage = global::GUI.Properties.Resources.placeholder_image;
            this.pbNhaCungCap.Location = new System.Drawing.Point(4, 4);
            this.pbNhaCungCap.Name = "pbNhaCungCap";
            this.pbNhaCungCap.Size = new System.Drawing.Size(45, 41);
            this.pbNhaCungCap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNhaCungCap.TabIndex = 0;
            this.pbNhaCungCap.TabStop = false;
            // 
            // MySuppiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnItem);
            this.Name = "MySuppiler";
            this.Size = new System.Drawing.Size(142, 48);
            this.pnItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbNhaCungCap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnItem;
        public System.Windows.Forms.Label lblNhaCungCap;
        public System.Windows.Forms.PictureBox pbNhaCungCap;
    }
}
