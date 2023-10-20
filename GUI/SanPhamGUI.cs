using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private SanPhamBLL spBLL;
        private DataTable dt;
        public SanPhamGUI()
        {
            spBLL = new SanPhamBLL();
            dt = spBLL.getListSanPham();
            InitializeComponent();
            loadMaSP();
            unhideError();
        }

        private void SanPhamGUI_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBLL.getListSanPham();
            dgvSanPham.ClearSelection();
            dgvSanPham.CurrentCell = null;
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
            foreach(DataRow row in dt.Rows)
            {
                lastMaSP = row["MaSP"].ToString();
            }
            if(lastMaSP == "")
            {
                txtMaSP.Texts = "SP001";
            }
            int tempNum = int.Parse(lastMaSP.Substring(2));
            if((tempNum + 1) >= 10)
            {
                txtMaSP.Texts = "SP0" + (tempNum + 1).ToString();
            } else if(tempNum >= 1 && tempNum < 9) { 
                txtMaSP.Texts = "SP00" + (tempNum + 1).ToString();
            }
        }
        //chuyển đổi một hình ảnh thành một dạng biểu diễn nhị phân 
        private byte[] convertImageToBinaryString(Image img,string tag)
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
                Console.WriteLine(pbImage.Tag);

            }
        }
        
        private void rjButton1_Click(object sender, EventArgs e)
        {
            pbImage.Image = pbImage.InitialImage;
            pbImage.Tag = "Placeholder";
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
            byte[] img = convertImageToBinaryString(pbImage.Image, pbImage.Tag.ToString());
            //Có thể k cần truyền vào lbl Lỗi
            Console.WriteLine("maSP: " + maSP);
            Console.WriteLine("tenSP: " + tenSP);
            Console.WriteLine("donViTinh: " + donViTinh);
            Console.WriteLine("maLoai: " + maLoai);
            Console.WriteLine("maNSX: " + maNSX);
            Console.WriteLine("maNCC: " + maNCC);
            Console.WriteLine("trangThai: " + trangThai);
            Console.WriteLine("tonKho: " + soLuongTonKho);
            Console.WriteLine("dongianhap: " + donGiaNhap);
            Console.WriteLine("dongiaban: " + donGiaBan);
            // Xử lý trường hợp không có ảnh (imgBytes == null)
           
            if (!(maSP != "" && tenSP != "" && donViTinh != "" && maLoai != "" && maNSX != "" && maNCC != "" && trangThai != "" && donGiaNhap != 0 && donGiaBan != 0 && img != null))
            {
                return;
            }
                Console.WriteLine("Không có cái nào null");





            //SanPhamDTO sp = new SanPhamDTO(maSP,tenSP,soLuongTonKho,donGiaNhap, donGiaBan, donViTinh,trangThai,maLoai, maNSX,maNCC,img);
            //int flag = spBLL.insertSanPham(sp) ? 1 : 0;
            //if (flag == 1)
            //{
            //    MessageBox.Show("Thêm thành công",
            //        "Thông báo",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information);
            //} else
            //{
            //    MessageBox.Show("Thêm thất bại",
            //        "Lỗi",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}

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
    }
}
