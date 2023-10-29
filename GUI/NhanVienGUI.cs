using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhanVienGUI : Form
    {

        private NhanVienBLL nvBLL;
        private DataTable dt;
        public NhanVienGUI()
        {
            nvBLL = new NhanVienBLL();
            dt = nvBLL.getListNhanVien();
            InitializeComponent();
            unhideError();
            loadMaNV();
        }
        private void NhanViennGUI_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();
        }
        private string CheckAndSetColor(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                label.ForeColor = string.IsNullOrWhiteSpace(text) ? Color.FromArgb(230, 76, 89) : Color.Transparent;
                return text;
            }
            else if (control is RJComboBox comboBox)
            {
                string selectedValue = comboBox.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(selectedValue))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                }
                return selectedValue;
            }

            return null; // Nếu kiểu dữ liệu không hợp lệ.
        }
        private void loadMaNV()
        {
            string lastMaKH = dt.AsEnumerable()
                .Select(row => row.Field<string>("MaNV"))
                .LastOrDefault();

            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastMaKH) && lastMaKH.Length >= 5)
            {
                int.TryParse(lastMaKH.Substring(2), out nextNum);
                nextNum++;
            }
            txtMaNV.Texts = "MaNV" + nextNum.ToString("D3");
        }

        private void unhideError()
        {
            lblErrMaNV.ForeColor = Color.Transparent;
            lblErrHo.ForeColor = Color.Transparent;
            lblErrTen.ForeColor = Color.Transparent;
            lblErrGioiTinh.ForeColor = Color.Transparent;
            lblErrSoDT.ForeColor = Color.Transparent;
            lblErrDiaChi.ForeColor = Color.Transparent;
            lblErrTrangThai.ForeColor = Color.Transparent;
            lblErrChucVu.ForeColor = Color.Transparent;
            lblErrIMG.ForeColor = Color.Transparent;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = CheckAndSetColor(txtMaNV, lblErrMaNV);
            string ho = CheckAndSetColor(txtHo, lblErrHo);
            string ten = CheckAndSetColor(txtTen, lblErrTen);
            string soDT = CheckAndSetColor(txtSoDT, lblErrSoDT);
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = CheckAndSetColor(txtDiaChi, lblErrDiaChi);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            string chucVu = CheckAndSetColor(cbxChucVu,lblErrChucVu);
            string valueChucVu = (chucVu == "Nhân viên bán hàng" ? "CV001" : "CV002");
            //byte[] img = convertImageToBinaryString(pbImage.Image, pbImage.Tag.ToString());
            string gioiTinh = "";
            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                lblErrGioiTinh.ForeColor = Color.FromArgb(230, 76, 89); // Đổi màu nếu cả hai CheckBox đều không được chọn
                return;
            }
            else if (rdbNam.Checked)
            {
                gioiTinh = Convert.ToString(rdbNam.Text);
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn
            }
            else if (rdbNu.Checked)
            {
                gioiTinh = Convert.ToString(rdbNu.Text);
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn

            }

            if (!(maNV != "" && ho != "" && ten != "" && soDT != "" && diaChi != "" && trangThai != ""))
            {
                return;
            }
            NhanVienDTO nv = new NhanVienDTO(maNV, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue, valueChucVu);
            int result = nvBLL.insertNhanVien(nv) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void txtHo__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtHo, lblErrHo);
        }

        private void txtTen__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtTen, lblErrTen);
        }

        private void txtSoDT__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtSoDT, lblErrSoDT);
        }

        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtDiaChi, lblErrDiaChi);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }
        private void cbxChucVu_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxChucVu, lblErrChucVu);
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                lblErrGioiTinh.ForeColor = Color.FromArgb(230, 76, 89); // Đổi màu nếu cả hai CheckBox đều không được chọn
            }
            else
            {
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn
            }
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                lblErrGioiTinh.ForeColor = Color.FromArgb(230, 76, 89); // Đổi màu nếu cả hai CheckBox đều không được chọn
            }
            else
            {
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn
            }
        }


        private void btnUploadIMG_Click(object sender, EventArgs e)
        {
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "NhanVien");
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = System.Drawing.Image.FromFile(open.FileName);

                this.Text = open.FileName;

                pbImage.Tag = txtMaNV.Texts;
                Console.WriteLine(pbImage.Tag);

            }
        }

        private void btnDeleteIMG_Click(object sender, EventArgs e)
        {
            pbImage.Image = pbImage.InitialImage;
            pbImage.Tag = "Placeholder";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Texts = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHo.Texts = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtTen.Texts = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse((dgvNhanVien.Rows[i].Cells[3].Value.ToString()));
            string gioiTinh = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            rdbNam.Checked = (gioiTinh == "Nam");
            rdbNu.Checked = (gioiTinh == "Nữ");
            txtSoDT.Texts = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Texts = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            int trangThai = int.Parse(dgvNhanVien.Rows[i].Cells[7].Value.ToString());
            string chucVu = dgvNhanVien.Rows[i].Cells[8].Value.ToString();
            //byte[] imageBytes = (byte[])dgvNhanVien.Rows[i].Cells[9].Value;
            //pbImage.Image = convertBinaryStringToImage(imageBytes);
            //pbImage.Tag = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            cbxTrangThai.SelectedItem = (trangThai == 1) ? "Hoạt động" : "Không hoạt động";

            cbxChucVu.SelectedItem = (chucVu == "CV001") ? "Nhân viên bán hàng" : "Nhân viên quản lý";
        }
        private byte[] convertImageToBinaryString(System.Drawing.Image img, string tag)
        {

            if (tag == "Placeholder")
            {
                lblErrIMG.ForeColor = Color.FromArgb(230, 76, 89);
                return null;
            }
            else
            {
                lblErrIMG.ForeColor = Color.Transparent;

            }

            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            return ms.ToArray();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
