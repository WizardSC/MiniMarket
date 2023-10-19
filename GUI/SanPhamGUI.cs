using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
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
        }

        private void SanPhamGUI_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBLL.getListSanPham();
        }

        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSanPham.ClearSelection();
            dgvSanPham.CurrentCell = null;
        }
        #region các hàm bổ trợ

        //Load mã KH mới nhất lên form
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
        private byte[] convertImageToBinaryString(Image img)
        {
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Texts.ToString();
            string tenSP = txtTenSP.Texts.ToString();
            int soLuongTonKho = int.Parse(txtTonKho.Texts.ToString());
            int donGiaNhap = int.Parse(txtGiaNhap.Texts.ToString());
            int donGiaBan = int.Parse(txtGiaBan.Texts.ToString());
            string donViTinh = "Cái";
            int trangThai = 1;
            string maLoai = "L001";
            string maNSX = "NSX002";
            string maNCC = "NCC001";
            byte[] img = this.convertImageToBinaryString(pbImage.Image);
            SanPhamDTO sp = new SanPhamDTO(maSP,tenSP,soLuongTonKho,donGiaNhap, donGiaBan, donViTinh,trangThai,maLoai, maNSX,maNCC,img);
            int flag = spBLL.insertSanPham(sp) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } else
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
    }
}
