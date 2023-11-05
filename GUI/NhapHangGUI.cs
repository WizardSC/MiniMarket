using BLL;
using DevExpress.DirectX.NativeInterop.Direct2D.CCW;
using DevExpress.Utils.Commands;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class NhapHangGUI : Form
    {
        private int currentScrollPosition = 0;
        private CTPhieuNhapBLL ctpnBLL;
        private NhapHangBLL nhBLL;
        private NhaCungCapBLL nccBLL;
        private PhieuNhapBLL pnBLL;
        private NhanVienBLL nvBLL;
        private SanPhamBLL spBLL;
        private DataTable dtSanPham;
        private DataTable dtNhaCungCap;
        private List<NhanVienDTO> listNV;
        private Dictionary<string, thongTinSanPham> gioHangNhap = new Dictionary<string, thongTinSanPham>();
        public struct thongTinSanPham
        {
            public thongTinSanPham(string maSP, string tenSP, int soLuong, int donGiaNhap, int thanhTien)
            {
                MaSP = maSP;
                TenSP = tenSP;
                SoLuong = soLuong;
                DonGiaNhap = donGiaNhap;
                ThanhTien = thanhTien;
            }

            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuong { get; set; }
            public int DonGiaNhap { get; set; }
            public int ThanhTien { get; set; }


        }
        public NhapHangGUI()
        {
            InitializeComponent();
            ctpnBLL = new CTPhieuNhapBLL();
            nhBLL = new NhapHangBLL();
            nccBLL = new NhaCungCapBLL();
            pnBLL = new PhieuNhapBLL();
            nvBLL = new NhanVienBLL();
            spBLL = new SanPhamBLL();
            listNV = nvBLL.getListNV();
            dtSanPham = nhBLL.getListNhapHang();
            dtNhaCungCap = nccBLL.getListNCC();
            dgvSanPham.DataSource = dtSanPham;
            loadToFlpNhaCungCap();
            loadNgayThang();
            loadMaPN();
        }
        private System.Drawing.Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }
        private void loadNgayThang()
        {
            lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void loadMaPN()
        {
            string maPN = pnBLL.getLastMaPN();
            if (string.IsNullOrWhiteSpace(maPN))
            {
                lblMaPN.Text = "#PN001";
            }
            else
            {
                lblMaPN.Text = maPN;
            }
        }
        private void loadToFlpNhaCungCap()
        {
            this.flpNhaCungCap.Controls.Clear();
            for (int i = 0; i < dtNhaCungCap.Rows.Count; i++)
            {
                MyCustom.MySuppiler item = new MyCustom.MySuppiler();
                item.lblNhaCungCap.Text = dtNhaCungCap.Rows[i]["TenNCC"].ToString();
                byte[] imageBytes = (byte[])dtNhaCungCap.Rows[i]["IMG"];
                item.pbNhaCungCap.Image = convertBinaryStringToImage(imageBytes);
                item.Margin = new Padding(6, 0, 6, 0);
                item.ItemClicked += Item_ItemClicked;
                this.flpNhaCungCap.Controls.Add(item);
            }

        }

        private DataTable searchWithTenNCC(string tenNCC)
        {
            DataTable nhaCungCapTable = dtSanPham.Clone(); // DataTable đã tồn tại
           ;


            var nhaCungCap = dtSanPham.AsEnumerable()
                .Where(row => row.Field<string>("TenNCC") == tenNCC)
                .ToList();

            if (nhaCungCap.Count == 0)
            {
                return nhaCungCapTable; // Trả về DataTable đã tồn tại nhưng rỗng
            }

            foreach (DataRow row in nhaCungCap)
            {
                nhaCungCapTable.ImportRow(row); // Sao chép các dòng từ danh sách đã lọc vào DataTable đã tồn tại
            }

            return nhaCungCapTable;
        }
        private string searchMaNVbyTenNV(string tenNV)
        {
            string maNV = listNV
                .Where(row => (row.Ho + " " + row.Ten).Equals(lblNhanVien.Text))
                .Select(row => row.MaNV)
                .FirstOrDefault();
            return maNV;
        }
        private string searchMaNCCbyTenNCC(string tenNCC)
        {
            string maNCC = dtNhaCungCap.AsEnumerable()
                .Where(row => row.Field<string>("TenNCC") == tenNCC)
                .Select(row => row.Field<string>("MaNCC"))
                .FirstOrDefault();
            return maNCC;
        }
        private void refreshAfterInsertCTPN()
        {
            gioHangNhap.Clear();
            lblNhaCungCap.Text = string.Empty;
            lblTongTien.Text = ConvertIntToVND(0);
            while(flpGioHangNhap.Controls.Count > 0)
            {
                Control control = flpGioHangNhap.Controls[0];
                flpGioHangNhap.Controls.Remove(control);
                control.Dispose();
            }
            loadMaPN();
            dgvSanPham.DataSource = dtSanPham;

        }
        public string ConvertIntToVND(int amount)
        {
            // Sử dụng định dạng số nguyên của tiền VND và thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N0}đ", amount);
            return formattedAmount;
        }
        public int ConvertVNDToInt(string vndAmount)
        {
            // Loại bỏ ký hiệu "đ" và dấu phẩy (,) trong chuỗi
            string cleanedAmount = vndAmount.Replace("đ", "").Replace(",", "");

            // Chuyển đổi chuỗi thành số nguyên
            if (int.TryParse(cleanedAmount, out int result))
            {
                return result;
            }
            else
            {
                // Xử lý lỗi nếu chuỗi không thể chuyển đổi thành số nguyên
                throw new ArgumentException("Không thể chuyển đổi chuỗi thành số nguyên.");
            }
        }
        private void tinhTongTien()
        {
            int tongTien = 0;
            foreach(var item in gioHangNhap)
            {
                tongTien += item.Value.ThanhTien;
            }
            lblTongTien.Text = ConvertIntToVND(tongTien);
        }
        private void refreshThongTin()
        {
            txtMaSP.Texts = "";
            txtTenSP.Texts = "";
            txtTonKho.Texts = "";
            txtDonGia.Texts = "";
           
            nudSoLuongMua.Value = 0;
        }
        #region Các hàm thực hiện xử lý sự kiện ở MySupplier
        private void Item_ItemClicked(object sender, EventArgs e)

        {

            if (gioHangNhap.Any())
            {
                MessageBox.Show("Không thể thay đổi nhà cung cấp khi giỏ hàng nhập còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MySuppiler item = (MySuppiler)sender;
            string tenNCC = item.lblNhaCungCap.Text;
            var listNCC = searchWithTenNCC(tenNCC);
            dgvSanPham.DataSource = listNCC;

            string maNCC = searchMaNCCbyTenNCC(tenNCC);
            lblNhaCungCap.Text = maNCC.ToString();


        }
        #endregion
        private void NhapHangGUI_Load(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSanPham.CurrentCell = null;
            dgvSanPham.ClearSelection();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHangNhap.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PhieuNhapDTO pn = new PhieuNhapDTO();
            pn.MaPN = lblMaPN.Text.Substring(1);
            pn.NgayLap = DateTime.ParseExact(lblNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            pn.TongTien = ConvertVNDToInt(lblTongTien.Text);
            pn.MaNCC = lblNhaCungCap.Text;
            pn.MaNV = searchMaNVbyTenNV(lblNhanVien.Text);
            Console.WriteLine(pn.MaPN);
            Console.WriteLine(pn.NgayLap);
            Console.WriteLine(pn.TongTien);
            Console.WriteLine(pn.MaNCC);
            Console.WriteLine(pn.MaNV);

            int result = pnBLL.insertPhieuNhap(pn) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công phiếu nhập",
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
            bool success = true;
            foreach(var pair in gioHangNhap)
            {
                thongTinSanPham sanPham = pair.Value;
                CTPhieuNhapDTO ctpn = new CTPhieuNhapDTO();
                ctpn.MaPN = pn.MaPN;
                ctpn.MaSP = sanPham.MaSP;
                ctpn.TenSP = sanPham.TenSP;
                ctpn.SoLuong = sanPham.SoLuong;
                ctpn.DonGiaNhap = sanPham.DonGiaNhap;
                ctpn.ThanhTien = sanPham.ThanhTien;
                spBLL.updateTonKho(sanPham.MaSP, sanPham.SoLuong);

                int resultCTPN = ctpnBLL.insertCTPN(ctpn) ? 1 : 0;
                if (resultCTPN != 1)
                {
                    success = false;
                    break; // Thoát khỏi vòng lặp nếu có lỗi
                }
            }
            if (success)
            {
                MessageBox.Show("Thêm thành công tất cả chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshAfterInsertCTPN();
                dgvSanPham.DataSource = nhBLL.getListNhapHang();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết phiếu nhập");
                return;
            }
            dtSanPham = nhBLL.getListNhapHang();

            loadMaPN();
            refreshThongTin();
           

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            txtMaSP.Texts = dgvSanPham.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Texts = dgvSanPham.Rows[i].Cells[1].Value.ToString();
            txtTonKho.Texts = dgvSanPham.Rows[i].Cells[2].Value.ToString();
            txtDonGia.Texts = dgvSanPham.Rows[i].Cells[3].Value.ToString();


        }
        #region Các hàm sự kiện ở MyProductInCart
        private void MyProductInCart_DeleteButtonClicked(object sender, EventArgs e)
        {
            MyProductInCart item = (MyProductInCart)sender;
            string maSP = item.lblMaSP.Text;

            var result = MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi giỏ hàng nhập không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {

                foreach (var pair in gioHangNhap)
                {
                    if (pair.Key == maSP)
                    {
                        gioHangNhap.Remove(pair.Key);
                        break;
                    }
                }
                flpGioHangNhap.Controls.Remove(item);

            }

            refreshThongTin();
            tinhTongTien();
        }
        private void MyProductInCart_GiamButtonClicked(object sender, EventArgs e)
        {
            MyProductInCart item = (MyProductInCart)sender;
            string maSP = item.lblMaSP.Text;
            int soLuongMua = int.Parse(item.txtSoLuong.Texts);
            soLuongMua -= 1;
            if (soLuongMua < 0)
            {
                return;
                //Không cho phép thực hiện nhỏ hơn 0
            }
            int thanhTien = ConvertVNDToInt(item.lblDonGia.Text) * soLuongMua;
            
            item.txtSoLuong.Texts = soLuongMua.ToString();
            item.lblTongTien.Text = ConvertIntToVND(thanhTien);
            if(soLuongMua == 0)
            {
                var result = MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi giỏ hàng nhập không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                  
                    foreach (var pair in gioHangNhap)
                    {
                        if (pair.Key == maSP)
                        {
                            gioHangNhap.Remove(pair.Key);
                            break;
                        }
                    }
                    flpGioHangNhap.Controls.Remove(item);
                    dgvSanPham.DataSource = dtSanPham;

                    return;
                } else if (result == DialogResult.Cancel)
                {
                    thongTinSanPham sanPham = gioHangNhap[maSP];
                    sanPham.SoLuong = 1;
                    sanPham.ThanhTien = sanPham.SoLuong * sanPham.DonGiaNhap;
                    gioHangNhap[maSP] = sanPham;

                    item.txtSoLuong.Texts = "1".ToString();
                    item.lblTongTien.Text = item.lblDonGia.Text;
                    return;
                }
            }
            if (gioHangNhap.ContainsKey(maSP))
            {
                thongTinSanPham sanPham = gioHangNhap[maSP];
                sanPham.SoLuong = soLuongMua;
                sanPham.ThanhTien = thanhTien;
                gioHangNhap[maSP] = sanPham;
            }
            refreshThongTin();
            tinhTongTien();


        }
        private void MyProductInCart_TangButtonClicked(object sender, EventArgs e)
        {
            MyProductInCart item = (MyProductInCart)sender;
            string maSP = item.lblMaSP.Text;
            int soLuongMua = int.Parse(item.txtSoLuong.Texts);
            soLuongMua += 1;
            int thanhTien = ConvertVNDToInt(item.lblDonGia.Text) * soLuongMua;

            item.txtSoLuong.Texts = soLuongMua.ToString();
            item.lblTongTien.Text = ConvertIntToVND(thanhTien);

            if (gioHangNhap.ContainsKey(maSP))
            {
                thongTinSanPham sanPham = gioHangNhap[maSP];
                sanPham.SoLuong = soLuongMua;
                sanPham.ThanhTien = thanhTien;
                gioHangNhap[maSP] = sanPham;
            }
            refreshThongTin();
            tinhTongTien();

        }
        #endregion
        private void btnChonSanPham_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Texts;
            string tenSP = txtTenSP.Texts;
            int donGia = int.Parse(txtDonGia.Texts);
            int soLuongMua = Convert.ToInt32(Math.Round(nudSoLuongMua.Value, 0));
            string nhaCungCap = lblNhaCungCap.Text;
            if (string.IsNullOrWhiteSpace(nhaCungCap))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (soLuongMua == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng cần thêm", "Thông báo");
                return;
            }

            MyProductInCart existingItem = null;
            foreach (var control in flpGioHangNhap.Controls)
            {
                if (control is MyProductInCart)
                {
                    MyProductInCart item = (MyProductInCart)control;
                    if (item.lblMaSP.Text == maSP)
                    {
                        existingItem = item;
                        break;
                    }
                }
            }
            if (existingItem != null)
            {
                int soLuongTruocDo = int.Parse(existingItem.txtSoLuong.Texts);
                int soLuongHienTai = soLuongTruocDo + soLuongMua;
                existingItem.txtSoLuong.Texts = soLuongHienTai.ToString();
                int tongTien = soLuongHienTai * ConvertVNDToInt(existingItem.lblDonGia.Text);
                existingItem.lblTongTien.Text = ConvertIntToVND(tongTien);

                if (gioHangNhap.ContainsKey(maSP))
                {
                    thongTinSanPham sanPham = gioHangNhap[maSP];
                    sanPham.SoLuong = soLuongTruocDo + soLuongMua;
                    sanPham.ThanhTien = sanPham.SoLuong * sanPham.DonGiaNhap;
                    gioHangNhap[maSP] = sanPham;
                }

                foreach (var item in gioHangNhap)
                {

                    thongTinSanPham sanPham = item.Value;

                    Console.WriteLine("Mã SP: " + sanPham.MaSP);
                    Console.WriteLine("Tên SP: " + sanPham.TenSP);
                    Console.WriteLine("Số lượng: " + sanPham.SoLuong);
                    Console.WriteLine("Đơn giá nhập: " + sanPham.DonGiaNhap);
                    Console.WriteLine("Thành tiền: " + sanPham.ThanhTien);
                    Console.WriteLine("------");
                }
            }
            else
            {
                MyProductInCart item = new MyProductInCart();
                item.lblMaSP.Text = maSP;
                item.lblTenSP.Text = tenSP;
                item.lblDonGia.Text = ConvertIntToVND(donGia);
                item.txtSoLuong.Texts = soLuongMua.ToString();
                item.lblTongTien.Text = ConvertIntToVND((soLuongMua * donGia));
                int tongTien = ConvertVNDToInt(item.lblTongTien.Text);

                item.TangButtonClicked += MyProductInCart_TangButtonClicked;
                item.GiamButtonClicked += MyProductInCart_GiamButtonClicked;
                item.DeleteButtonClicked += MyProductInCart_DeleteButtonClicked;

                //Thêm vào Dictionary giỏ hàng
                thongTinSanPham sanPham = new thongTinSanPham(maSP, tenSP, soLuongMua, donGia, tongTien);
                gioHangNhap[maSP] = sanPham;
                flpGioHangNhap.Controls.Add(item);


            }
            refreshThongTin();
            tinhTongTien();

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in gioHangNhap)
            {

                thongTinSanPham sanPham = item.Value;

                Console.WriteLine("Mã SP: " + sanPham.MaSP);
                Console.WriteLine("Tên SP: " + sanPham.TenSP);
                Console.WriteLine("Số lượng: " + sanPham.SoLuong);
                Console.WriteLine("Đơn giá nhập: " + sanPham.DonGiaNhap);
                Console.WriteLine("Thành tiền: " + sanPham.ThanhTien);
                Console.WriteLine("------");
            }

            tinhTongTien();
        }
    }
}