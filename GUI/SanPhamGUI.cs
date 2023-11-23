using BLL;
using DTO;
using GUI.MyCustom;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace GUI
{
    public partial class SanPhamGUI : Form
    {
        private bool isFormFilter = false;
        private string cbxItemsMacDinh;
        private string statusCondition = "";
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string genderCondition = ""; // Biến để lưu trữ điều kiện từ checkbox "Giới Tính"
        private string currentSearch;
        private bool isTrangThai = false;
        private bool isHoatDong = false;
        private bool isKoHD = false;
        // Don Gia Nhap  ------------------------
        private bool isDonNhap = false;
        private int DonGiaTu = 0;
        private int DonGiaDen = 0;


        // Don Gia Ban  ------------------------
        private bool isDonBan = false;
        private int DonGiaBanTu = 0;
        private int DonGiaBanDen = 0;


        // Don Gia Ban  ------------------------
        private bool isSoLuong = false;
        private int SoLuongTu = 0;
        private int SoLuongDen = 0;

        private bool isGioiTinh = false;
        private bool isTuoi = false;
        private SanPhamBLL spBLL;
        private DataTable dtSanPham;

        private string fileName;
        private int quyenSanPham;
        public SanPhamGUI(int isSanPham)
        {
            spBLL = new SanPhamBLL();
            dtSanPham = spBLL.getListSanPham();
            InitializeComponent();
            loadMaSP();
            unhideError();
            quyenSanPham = isSanPham;

            loadBtn();
            checkQuyen(isSanPham);
        }

        private void loadBtn()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtTonKho.Enabled = false;
            txtMaSP.Enabled = false;
        }
        private void SanPhamGUI_Load(object sender, EventArgs e)
        {
            loadDataToCBX(cbxTimKiem);
            dgvSanPham.DataSource = dtSanPham;

        }
        private void checkQuyen(int quyen)
        {
            if (quyen == 1)
            {
                btnDeleteIMG.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                cbxDonViTinh.Enabled = false;
                cbxTrangThai.Enabled = false;
                btnMaLoai.Enabled = false;
                btnMaNCC.Enabled = false;
                btnMaNSX.Enabled = false;
                btnUploadAnh.Enabled = false;
                btnDeleteIMG.Enabled = false;
            }
        }
        private void clearForm()
        {

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            checkQuyen(quyenSanPham);
            txtTonKho.Enabled = false;
            txtMaSP.Enabled = false;
            txtMaSP.Texts = "";
            loadMaSP();
            txtTenSP.Texts = "";
            txtTonKho.Texts = 0.ToString();
            txtGiaNhap.Texts = 0.ToString();
            pbImage.Image = GUI.Properties.Resources.placeholder_image;
            txtGiaBan.Texts = 0.ToString();
            cbxDonViTinh.Texts = "--Chọn đơn vị--";
            cbxTrangThai.Text = "--Chọn trạng thái--";
            txtMaLoai.Texts = "";
            txtMaNCC.Texts = "";
            txtMaNSX.Texts = "";
            dtSanPham = spBLL.getListSanPham();
            dgvSanPham.DataSource = dtSanPham;
            unhideError();
        }

        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSanPham.ClearSelection();
            dgvSanPham.CurrentCell = null;
        }
        #region các hàm bổ trợ

        //Load mã KH mới nhất lên form
        private void unhideError()
        {
            lblErrMaSP.ForeColor = Color.Transparent;
            lblErrTenSP.ForeColor = Color.Transparent;
            lblErrGiaNhap.ForeColor = Color.Transparent;
            lblErrDonViTinh.ForeColor = Color.Transparent;
            lblErrMaLoai.ForeColor = Color.Transparent;
            lblErrMaNCC.ForeColor = Color.Transparent;
            lblErrMaNSX.ForeColor = Color.Transparent;
            lblErrTrangThai.ForeColor = Color.Transparent;
            lblErrIMG.ForeColor = Color.Transparent;
        }
        private void loadMaSP()
        {
            string lastMaSP = null;
            foreach (DataRow row in dtSanPham.Rows)
            {
                lastMaSP = row["MaSP"].ToString();
            }
            if (lastMaSP == "")
            {
                txtMaSP.Texts = "SP001";
            }
            int tempNum = int.Parse(lastMaSP.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaSP.Texts = "SP0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaSP.Texts = "SP00" + (tempNum + 1).ToString();
            }
        }
        //chuyển đổi một hình ảnh thành một dạng biểu diễn nhị phân 
        private byte[] convertImageToBinaryString(Image img, string tag)
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

        //chuyển đổi một dạng biểu diễn nhị phân thành một hình ảnh 
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
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

        private int ConvertToInt(RJTextBox textBox, Label label = null)
        //Nếu không có lbl Lỗi thì mặc định giá trị là null
        {
            string text = textBox.Texts.Trim();
            int result;

            bool isNumeric = int.TryParse(text, out result);

            if (label != null)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Vui lòng nhập Giá nhập hàng";
                }
                else
                {
                    label.ForeColor = isNumeric ? Color.Transparent : Color.FromArgb(230, 76, 89);
                    label.Text = isNumeric ? "" : "*Vui lòng nhập 1 số nguyên";
                }
            }

            return isNumeric ? result : 0;
        }
        #endregion
        #region Các hàm validate lỗi
        private void txtTenSP__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtTenSP, lblErrTenSP);
        }

        private void txtGiaNhap__TextChanged_1(object sender, EventArgs e)
        {
            ConvertToInt(txtGiaNhap, lblErrGiaNhap);

        }

        private void cbxDonViTinh_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxDonViTinh, lblErrDonViTinh);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }

        private void txtMaLoai__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtMaLoai, lblErrMaLoai);
        }

        private void txtMaNSX__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtMaNSX, lblErrMaNSX);
        }

        private void txtMaNCC__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtMaNCC, lblErrMaNCC);
        }
        #endregion
        private void btnUploadAnh_Click(object sender, EventArgs e)
        {
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "SanPham");
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;

                pbImage.Tag = txtMaSP.Texts;
                fileName = Path.GetFileName(open.FileName);

                lblErrIMG.ForeColor = Color.Transparent;

            }


        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            string maSP = CheckAndSetColor(txtMaSP, lblErrMaSP);
            string tenSP = CheckAndSetColor(txtTenSP, lblErrTenSP);
            string donViTinh = CheckAndSetColor(cbxDonViTinh, lblErrDonViTinh);
            string maLoai = CheckAndSetColor(txtMaLoai, lblErrMaLoai);
            string maNSX = CheckAndSetColor(txtMaNSX, lblErrMaNSX);
            string maNCC = CheckAndSetColor(txtMaNCC, lblErrMaNCC);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int soLuongTonKho = ConvertToInt(txtTonKho);
            int donGiaNhap = ConvertToInt(txtGiaNhap, lblErrGiaNhap);
            int donGiaBan = ConvertToInt(txtGiaBan);
            string img = fileName;
            if(img == null)
            {
                lblErrIMG.ForeColor = Color.FromArgb(230, 76, 89);
            } else
            {
                lblErrIMG.ForeColor = Color.Transparent;

            }
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            //Có thể k cần truyền vào lbl Lỗi

            // Nếu null thì return 

            if (!(maSP != "" && tenSP != "" && donViTinh != "" && maLoai != "" && maNSX != "" && maNCC != "" && trangThai != "" && donGiaNhap != 0 && donGiaBan != 0 && img != null))
            {
                return;
            }
            SanPhamDTO sp = new SanPhamDTO(maSP, tenSP, soLuongTonKho, donGiaNhap, donGiaBan, donViTinh, trangThaiValue, maLoai, maNSX, maNCC, img);
            int flag = spBLL.insertSanPham(sp) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                clearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void btnMaNCC_Click(object sender, EventArgs e)
        {
            MiniNCCGUI nccGUI = new MiniNCCGUI();
            nccGUI.Show();
            nccGUI.FormClosed += (s, args) =>
            {
                string maNCC = nccGUI.maNCC;
                Console.WriteLine(maNCC);
                txtMaNCC.Texts = maNCC;
            };
        }

        private void btnMaNSX_Click(object sender, EventArgs e)
        {
            MiniNSXGUI nsxGUI = new MiniNSXGUI();
            nsxGUI.Show();
            nsxGUI.FormClosed += (s, args) =>
            {
                string maNSX = nsxGUI.maNSX;
                Console.WriteLine(maNSX);
                txtMaNSX.Texts = maNSX;
                Console.WriteLine("1");
            };

        }

        private void btnMaLoai_Click(object sender, EventArgs e)
        {
            MiniLoaiGUI maLoaiGUI = new MiniLoaiGUI();
            maLoaiGUI.Show();

            maLoaiGUI.FormClosed += (s, args) =>
            {
                string maLoai = maLoaiGUI.maLoai;
                Console.WriteLine(maLoai);
                txtMaLoai.Texts = maLoai;
            };
        }

        private void txtGiaNhap__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_Click(object sender, EventArgs e)
        {
            int donGiaNhap = ConvertToInt(txtGiaNhap, lblErrGiaNhap);

            if (donGiaNhap == 0)
            {
                return;
            }
            else
            {
                txtGiaBan.Texts = (donGiaNhap + (donGiaNhap * 15 / 100)).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                bool kq = spBLL.deleteSanPham(maSP, out isLoiKhoaNgoai);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    clearForm();



                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa sản phẩm này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    int flag = spBLL.updateTrangThai(trangThai, maSP) ? 1 : 0;
                                    if (flag == 1)
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        clearForm();
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

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            checkQuyen(quyenSanPham);

            int i = dgvSanPham.CurrentRow.Index;
            txtMaSP.Enabled = false;
            txtTonKho.Enabled = false;
            txtMaSP.Texts = dgvSanPham.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Texts = dgvSanPham.Rows[i].Cells[1].Value.ToString();
            txtTonKho.Texts = dgvSanPham.Rows[i].Cells[2].Value.ToString();
            txtGiaNhap.Texts = dgvSanPham.Rows[i].Cells[3].Value.ToString();
            txtGiaBan.Texts = dgvSanPham.Rows[i].Cells[4].Value.ToString();
            cbxDonViTinh.SelectedItem = dgvSanPham.Rows[i].Cells[5].Value.ToString();

            txtMaLoai.Texts = dgvSanPham.Rows[i].Cells[7].Value.ToString();
            txtMaNSX.Texts = dgvSanPham.Rows[i].Cells[8].Value.ToString();
            txtMaNCC.Texts = dgvSanPham.Rows[i].Cells[9].Value.ToString();
            string img = dgvSanPham.Rows[i].Cells[10].Value.ToString();
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "SanPham", img);
            if (File.Exists(folderPath))
            {
                pbImage.Image = Image.FromFile(folderPath);
                pbImage.Tag = dgvSanPham.Rows[i].Cells[10].Value.ToString();
                fileName = Path.GetFileName(folderPath);
            }
            else
            {
                pbImage.Image = pbImage.InitialImage;

            }
           
            int trangThaiValue = Convert.ToInt32(dgvSanPham.Rows[i].Cells[6].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }
        //Hiển thị Trạng thái lên DataGridView
        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.ColumnIndex == dgvSanPham.Columns["TrangThai"].Index && e.Value != null)
            //{
            //    int trangThaiValue = Convert.ToInt32(e.Value);
            //    if (trangThaiValue == 0)
            //    {
            //        e.Value = "Không hoạt động";
            //    }
            //    else if (trangThaiValue == 1)
            //    {
            //        e.Value = "Hoạt động";
            //    }
            //}
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Texts;
            string tenSP = txtTenSP.Texts;
            int soLuong = int.Parse(txtTonKho.Texts);
            int donGiaNhap = int.Parse(txtGiaNhap.Texts);
            int donGiaBan = int.Parse(txtGiaBan.Texts);
            string donViTinh = cbxDonViTinh.SelectedItem.ToString();
            string trangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            string maLoai = txtMaLoai.Texts;
            string maNSX = txtMaNSX.Texts;
            string maNCC = txtMaNCC.Texts;
            string img = fileName;

            SanPhamDTO sp = new SanPhamDTO(maSP, tenSP, soLuong, donGiaNhap, donGiaBan, donViTinh, trangThaiValue, maLoai, maNSX, maNCC, img);
            int kq = spBLL.updateSanPham(sp) ? 1 : 0;
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                clearForm();

            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void btnDeleteIMG_Click(object sender, EventArgs e)
        {
            pbImage.Image = pbImage.InitialImage;
            pbImage.Tag = "Placeholder";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
        }
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã SP");
            cbx.Items.Add("Tên SP");
            cbx.Items.Add("Đơn vị tính");
            cbx.Items.Add("Mã Loại");
            cbx.Items.Add("Mã NSX");
            cbx.Items.Add("Mã NCC");
            cbxItemsMacDinh = cbx.Items[0].ToString();
        }
        private string returnDieuKien(string text)
        {
            return text;
        }

        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã SP":
                    return returnDieuKien($"MaSP like '%{searchText}%'");
                case "Tên SP":
                    return returnDieuKien($"TenSP like '%{searchText}%'");
                case "Đơn vị tính":
                    return returnDieuKien($"DonViTinh like '%{searchText}%'");
                case "Mã Loại":
                    return returnDieuKien($"MaLoai like '%{searchText}%'");
                case "Mã NSX":
                    return returnDieuKien($"MaNSX like '%{searchText}%'");
                case "Mã NCC":
                    return returnDieuKien($"TenNCC like '%{searchText}%'");
                default:
                    return "";
            }

        }

        private void applySearchs(string text)
        {
            // dtSanPham = loaibill.getListLoai();
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvSP = dtSanPham.DefaultView; ;
            dvSP.RowFilter = currentSearch;
            dgvSanPham.DataSource = dvSP.ToTable();
        }
        private string CombineConditions(string condition1, string condition2)
        {
            if (!string.IsNullOrEmpty(condition1) && !string.IsNullOrEmpty(condition2))
            {
                return $"({condition1}) AND ({condition2})";
            }
            else if (!string.IsNullOrEmpty(condition1))
            {
                return condition1;
            }
            else if (!string.IsNullOrEmpty(condition2))
            {
                return condition2;
            }
            else
            {
                return "";
            }


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);
            combinedCondition = CombineConditions(combinedCondition, statusCondition);
            combinedCondition = ApplyOrRemoveDonGiaNhapCondition(combinedCondition, isDonNhap);
            combinedCondition = ApplyOrRemoveDonGiaBanCondition(combinedCondition, isDonBan);
            combinedCondition = ApplyOrRemoveSoLuongCondition(combinedCondition, isSoLuong);
            applySearchs(combinedCondition);
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                btnTimKiem_Click(sender, e);
                e.Handled = true;
            }
        }

        private bool toggleDieuKien(bool value)
        {
            return !value;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            isFormFilter = !isFormFilter;
            if (isFormFilter)
            {
                btnFilter.BackColor = Color.FromArgb(224, 224, 224);
                flpFilter.Visible = true;
                flpFilter.BringToFront();

            }
            else
            {
                btnFilter.BackColor = Color.FromArgb(224, 252, 237);
                flpFilter.Visible = false;
                flpFilter.SendToBack();
            }
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            isTrangThai = toggleDieuKien(isTrangThai);
            chkHoatDong.Enabled = isTrangThai;
            chkKoHD.Enabled = isTrangThai;
            if (isTrangThai)
            {

                if (isHoatDong)
                {

                    chkHoatDong_CheckedChanged(sender, e);
                }

                if (isKoHD)
                {
                    chkKoHD_CheckedChanged(sender, e);
                }
            }
            else
            {
                // Nếu chkGioiTinh không được kiểm tra, tắt chkNam và chkNu và xóa check
                chkHoatDong.Checked = false;
                chkKoHD.Checked = false;
                chkHoatDong.Enabled = isGioiTinh;
                chkKoHD.Enabled = isGioiTinh;
            }
        }

        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            isHoatDong = toggleDieuKien(isHoatDong);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }

        private void chkKoHD_CheckedChanged(object sender, EventArgs e)
        {
            isKoHD = toggleDieuKien(isKoHD);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }

        private void UpdateStatusCondition()
        {
            List<string> statusConditions = new List<string>();

            if (isHoatDong)
            {
                statusConditions.Add("TrangThai = 1");
            }

            if (isKoHD)
            {
                statusConditions.Add("TrangThai = 0");
            }

            statusCondition = string.Join(" OR ", statusConditions);
        }



        private void chkGiaNhap_CheckedChanged(object sender, EventArgs e)
        {
            isDonNhap = toggleDieuKien(isDonNhap);
            Console.WriteLine(isDonNhap);
            txtGiaNhapTu.Enabled = isDonNhap;
            txtGiaNhapDen.Enabled = isDonNhap;
            if (!isDonNhap)
            {
                DonGiaTu = 0;
                DonGiaDen = 0;
            }
            if (isDonNhap)
            {
                if (int.TryParse(txtGiaNhapTu.Texts, out int result))
                {
                    DonGiaTu = result;
                }
                if (int.TryParse(txtGiaNhapDen.Texts, out int result1))
                {
                    DonGiaDen = result1;
                }
            }
            btnTimKiem_Click(sender, e);
        }

        private void txtGiaNhapTu__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaNhapTu.Texts))
            {
                DonGiaTu = 0;
            }
            if (int.TryParse(txtGiaNhapTu.Texts, out int result))
            {
                DonGiaTu = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private void txtGiaNhapDen__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaNhapDen.Texts))
            {
                DonGiaDen = 0;
            }
            if (int.TryParse(txtGiaNhapDen.Texts, out int result))
            {
                DonGiaDen = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }
        private string ApplyOrRemoveDonGiaNhapCondition(string condition, bool isDonNhap)
        {
            // Tạo một biến mới để lưu trữ điều kiện `DiemTL`
            string DonGiaNhap = $"DonGiaNhap >= {DonGiaTu} AND DonGiaNhap <= {DonGiaDen}";

            if (isDonNhap)
            {
                if (DonGiaTu >= 0 && DonGiaDen > 0 && DonGiaTu <= DonGiaDen)
                {
                    // Thêm điều kiện `DiemTL` vào chuỗi điều kiện nếu có
                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = CombineConditions(condition, DonGiaNhap);
                    }
                    else
                    {
                        condition = DonGiaNhap;
                    }
                }
            }
            else
            {
                // Nếu không có checkbox DiemTL được chọn, xóa điều kiện `DiemTL` khỏi chuỗi điều kiện
                condition = condition.Replace(DonGiaNhap, "");
            }

            return condition;
        }

        private void chkGiaBan_CheckedChanged(object sender, EventArgs e)
        {
            isDonBan = toggleDieuKien(isDonBan);
            Console.WriteLine(isDonBan);
            txtGiaBanTu.Enabled = isDonBan;
            txtGiaBanDen.Enabled = isDonBan;
            if (!isDonBan)
            {
                DonGiaBanTu = 0;
                DonGiaBanDen = 0;
            }
            if (isDonBan)
            {
                if (int.TryParse(txtGiaBanTu.Texts, out int result))
                {
                    DonGiaBanTu = result;
                }
                if (int.TryParse(txtGiaBanDen.Texts, out int result1))
                {
                    DonGiaBanDen = result1;
                }
            }
            btnTimKiem_Click(sender, e);
        }

        private void txtGiaBanTu__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaBanTu.Texts))
            {
                DonGiaBanTu = 0;
            }
            if (int.TryParse(txtGiaBanTu.Texts, out int result))
            {
                DonGiaBanTu = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private void txtGiaBanDen__TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGiaBanDen.Texts))
            {
                DonGiaBanDen = 0;
            }
            if (int.TryParse(txtGiaBanDen.Texts, out int result))
            {
                DonGiaBanDen = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private string ApplyOrRemoveDonGiaBanCondition(string condition, bool isDonBan)
        {
            // Tạo một biến mới để lưu trữ điều kiện `DiemTL`
            string DonGiaBan = $"DonGiaBan >= {DonGiaBanTu} AND DonGiaBan <= {DonGiaBanDen}";

            if (isDonBan)
            {
                if (DonGiaBanTu >= 0 && DonGiaBanDen > 0 && DonGiaBanTu <= DonGiaBanDen)
                {
                    // Thêm điều kiện `DiemTL` vào chuỗi điều kiện nếu có
                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = CombineConditions(condition, DonGiaBan);
                    }
                    else
                    {
                        condition = DonGiaBan;
                    }
                }
            }
            else
            {
                // Nếu không có checkbox DiemTL được chọn, xóa điều kiện `DiemTL` khỏi chuỗi điều kiện
                condition = condition.Replace(DonGiaBan, "");
            }

            return condition;
        }

        private void chkSoLuong_CheckedChanged(object sender, EventArgs e)
        {
            isSoLuong = toggleDieuKien(isSoLuong);
            Console.WriteLine(isSoLuong);
            txtSoLuongTu.Enabled = isSoLuong;
            txtSoLuongDen.Enabled = isSoLuong;
            if (!isSoLuong)
            {
                SoLuongTu = 0;
                SoLuongDen = 0;
            }
            if (isSoLuong)
            {
                if (int.TryParse(txtSoLuongTu.Texts, out int result))
                {
                    SoLuongTu = result;
                }
                if (int.TryParse(txtSoLuongDen.Texts, out int result1))
                {
                    SoLuongDen = result1;
                }
            }
            btnTimKiem_Click(sender, e);
        }

        private void txtSoLuongTu__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoLuongTu.Texts))
            {
                SoLuongTu = 0;
            }
            if (int.TryParse(txtSoLuongTu.Texts, out int result))
            {
                SoLuongTu = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private void txtSoLuongDen__TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSoLuongDen.Texts))
            {
                SoLuongDen = 0;
            }
            if (int.TryParse(txtSoLuongDen.Texts, out int result))
            {
                SoLuongDen = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private string ApplyOrRemoveSoLuongCondition(string condition, bool isSoLuong)
        {
            // Tạo một biến mới để lưu trữ điều kiện `DiemTL`
            string SoLuong = $"SoLuong >= {SoLuongTu} AND SoLuong <= {SoLuongDen}";

            if (isSoLuong)
            {
                if (SoLuongTu >= 0 && SoLuongDen > 0 && SoLuongTu <= SoLuongDen)
                {
                    // Thêm điều kiện `DiemTL` vào chuỗi điều kiện nếu có
                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = CombineConditions(condition, SoLuong);
                    }
                    else
                    {
                        condition = SoLuong;
                    }
                }
            }
            else
            {
                // Nếu không có checkbox DiemTL được chọn, xóa điều kiện `DiemTL` khỏi chuỗi điều kiện
                condition = condition.Replace(SoLuong, "");
            }

            return condition;
        }
    }

}


