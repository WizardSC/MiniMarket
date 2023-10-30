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

        private string textSearchCondition = "";
        private string currentSearch;
        private NhanVienBLL nvBLL;
        private DataTable dt;
        public NhanVienGUI()
        {
            nvBLL = new NhanVienBLL();
            dt = nvBLL.getListNhanVien();
            InitializeComponent();
            unhideError();
            loadMaNV();
            loadCbxTimKiem();
        }
        private void load_Form()
        {
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();
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
            txtMaNV.Texts = "NV" + nextNum.ToString("D3");
        }
        private void loadCbxTimKiem()
        {
            cbxTimKiem.Items.Add("Mã NV");
            cbxTimKiem.Items.Add("Họ");
            cbxTimKiem.Items.Add("Tên");
            cbxTimKiem.Items.Add("Ngày sinh");
            cbxTimKiem.Items.Add("Giới tính");
            cbxTimKiem.Items.Add("Số SĐT");
            cbxTimKiem.Items.Add("Địa chỉ");
            cbxTimKiem.Items.Add("Trạng thái");
            cbxTimKiem.Items.Add("Chức vụ");
            cbxTimKiem.SelectedItem = 0;
        }
        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxTimKiem.SelectedIndex)
            {
                case 0:
                    return returnDieuKien($"MaNV like '%{searchText}%'");
                case 1:
                    return returnDieuKien($"Ho like '%{searchText}%'");
                case 2:
                    return returnDieuKien($"Ten like '%{searchText}%'");
                case 3:
                    return returnDieuKien($"NgaySinh like '%{searchText}%'");
                case 4:
                    return returnDieuKien($"GioiTinh like '%{searchText}%'");
                case 5:
                    return returnDieuKien($"SoDT like '%{searchText}%'");
                case 6:
                    return returnDieuKien($"DiaChi like '%{searchText}%'");
                case 7:
                    return returnDieuKien($"TrangThai like '%{searchText}%'");
                case 8:
                    return returnDieuKien($"MaCV like '%{searchText}%'");
                default:
                    return returnDieuKien($"MaNV like '%{searchText}%'"); ;
            }
        }
        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvNhanVien = nvBLL.getListNhanVien().DefaultView;
            dvNhanVien.RowFilter = currentSearch;
            dgvNhanVien.DataSource = dvNhanVien.ToTable();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            applySearchs(textSearchCondition);
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
            //string maTK = null;
            byte[] img = null;
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
            NhanVienDTO nv = new NhanVienDTO(maNV, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue ,valueChucVu);
            if (nvBLL.insertNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                    load_Form();
            }
            else
            {
                MessageBox.Show("Thêm thất bại" ,
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
            string chucVu = dgvNhanVien.Rows[i].Cells[10].Value.ToString();
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
            loadMaNV();
            txtHo.Texts = "";
            txtTen.Texts = "";
            txtSoDT.Texts = "";
            txtDiaChi.Texts = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            cbxChucVu.SelectedIndex = -1;
            cbxChucVu.Texts = "--Chọn chức vụ--";
            cbxTrangThai.SelectedIndex = -1;
            cbxTrangThai.Texts = "--Chọn trạng thái--";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Texts;
            string ho = txtHo.Texts;
            string ten = txtTen.Texts;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = rdbNam.Checked ? rdbNam.Text : (rdbNu.Checked ? rdbNu.Text : "");
            string soDT = txtSoDT.Texts;
            string diaChi = txtDiaChi.Texts;
            int trangThaiValue = (cbxTrangThai.SelectedItem == "Hoạt động") ? 1 : 0;
            string valueChucVu = (cbxChucVu.SelectedItem == "Nhân viên bán hàng") ? "CV001" : "CV002";
            byte[] img = convertImageToBinaryString(pbImage.Image, pbImage.Tag.ToString());

            NhanVienDTO nv = new NhanVienDTO(maNV, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue,valueChucVu );
            if (nvBLL.updateNhanVien(nv))
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    load_Form();

            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                if (nvBLL.deleteNhanVien(maNV, out isLoiKhoaNgoai))
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                        load_Form();

                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa nhân viên này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    if (nvBLL.updateTrangThai(trangThai, maNV))
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        load_Form();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                                else if (result1 == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                            else return;

                        }

                    }

                }
            }
        }

        
    }
}
