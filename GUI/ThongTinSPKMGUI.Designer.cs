namespace GUI
{
    partial class ThongTinSPKMGUI
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
            this.dgvThongTinSPKM = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanTramKm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSPKM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinSPKM
            // 
            this.dgvThongTinSPKM.AllowUserToAddRows = false;
            this.dgvThongTinSPKM.AllowUserToDeleteRows = false;
            this.dgvThongTinSPKM.AllowUserToResizeColumns = false;
            this.dgvThongTinSPKM.AllowUserToResizeRows = false;
            this.dgvThongTinSPKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvThongTinSPKM.BackgroundColor = System.Drawing.Color.White;
            this.dgvThongTinSPKM.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(254)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(191)))), ((int)(((byte)(186)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinSPKM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinSPKM.ColumnHeadersHeight = 28;
            this.dgvThongTinSPKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.Masp,
            this.TenSp,
            this.Column1,
            this.NgayKT,
            this.PhanTramKm,
            this.TrangThai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(252)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongTinSPKM.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongTinSPKM.EnableHeadersVisualStyles = false;
            this.dgvThongTinSPKM.GridColor = System.Drawing.Color.Black;
            this.dgvThongTinSPKM.Location = new System.Drawing.Point(0, 2);
            this.dgvThongTinSPKM.Name = "dgvThongTinSPKM";
            this.dgvThongTinSPKM.ReadOnly = true;
            this.dgvThongTinSPKM.RowHeadersVisible = false;
            this.dgvThongTinSPKM.RowHeadersWidth = 51;
            this.dgvThongTinSPKM.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvThongTinSPKM.RowTemplate.Height = 30;
            this.dgvThongTinSPKM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvThongTinSPKM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongTinSPKM.Size = new System.Drawing.Size(903, 128);
            this.dgvThongTinSPKM.TabIndex = 2;
            this.dgvThongTinSPKM.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvThongTinSPKM_CellFormatting);
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
            this.MaKM.Width = 72;
            // 
            // Masp
            // 
            this.Masp.DataPropertyName = "MaSP";
            this.Masp.HeaderText = "Mã SP";
            this.Masp.Name = "Masp";
            this.Masp.ReadOnly = true;
            this.Masp.Width = 71;
            // 
            // TenSp
            // 
            this.TenSp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenSp.DataPropertyName = "TenSP";
            this.TenSp.HeaderText = "Tên SP";
            this.TenSp.MinimumWidth = 6;
            this.TenSp.Name = "TenSp";
            this.TenSp.ReadOnly = true;
            this.TenSp.Width = 315;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "NgayBatDau";
            this.Column1.HeaderText = "Ngày bắt đầu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 108;
            // 
            // NgayKT
            // 
            this.NgayKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NgayKT.DataPropertyName = "NgayKetThuc";
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.ReadOnly = true;
            this.NgayKT.Width = 108;
            // 
            // PhanTramKm
            // 
            this.PhanTramKm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PhanTramKm.DataPropertyName = "PhanTramKM";
            this.PhanTramKm.HeaderText = "Phần trăm KM";
            this.PhanTramKm.MinimumWidth = 6;
            this.PhanTramKm.Name = "PhanTramKm";
            this.PhanTramKm.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 125;
            // 
            // ThongTinSPKMGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 130);
            this.Controls.Add(this.dgvThongTinSPKM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongTinSPKMGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết sản phẩm khuyến mãi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinSPKM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinSPKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanTramKm;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}