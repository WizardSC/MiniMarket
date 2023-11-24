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

        private string textSearchCondition = "";
        private string currentSearch;
        private int giaStart = 0;
        private int giaEnd = 0;
        private bool isGia = false;
        private int tonKhoStart = 0;
        private int tonKhoEnd = 0;
        private bool isTonKho = false;
        private string genderCondition = "";

        private bool isFormFilter = false;
        private int currentScrollPosition = 0;
        private CTPhieuNhapBLL ctpnBLL;
        private NhapHangBLL nhBLL;
        private NhaCungCapBLL nccBLL;
        private PhieuNhapBLL pnBLL;
        private NhanVienBLL nvBLL;
        private SanPhamBLL spBLL;
        private DataTable dtSanPham;
        private DataTable dtNhaCungCap;
        private DataTable dtNCCbyMaNCC;
        private List<NhanVienDTO> listNV;
        private Dictionary<string, thongTinSanPham> gioHangNhap = new Dictionary<string, thongTinSanPham>();
        private DataTable currentListNCC;
        private string fileName;

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
        public NhapHangGUI(string tenNV)
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
            //dgvSanPham.DataSource = dtSanPham;
            loadToFlpNhaCungCap();
            loadNgayThang();
            loadMaPN();
            loadCbxTimKiem();
            lblNhanVien.Text = tenNV;
            btnInPhieuNhap.Enabled = false;
            init();
        }
        public void init()
        {
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtTonKho.Enabled = false;
            txtDonGia.Enabled = false;

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

                string image = dtNhaCungCap.Rows[i]["IMG"].ToString();
                string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string folderPath = Path.Combine(appDirectory, "resources", "image", "NhaCungCap", image);
                Console.WriteLine(folderPath);
                if (File.Exists(folderPath))
                {
                    item.pbNhaCungCap.Image = System.Drawing.Image.FromFile(folderPath);
                }
                else
                {
                    item.pbNhaCungCap.Image = item.pbNhaCungCap.InitialImage;

                }
                item.Margin = new Padding(6, 0, 6, 0);
                item.ItemClicked += Item_ItemClicked;
                this.flpNhaCungCap.Controls.Add(item);
            }

        }
        private void loadCbxTimKiem()
        {
            cbxTimKiem.Items.Add("Mã SP");
            cbxTimKiem.Items.Add("Tên SP");
            cbxTimKiem.Items.Add("Tên loại");
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
                    return returnDieuKien($"SanPham.MaSP like '%{searchText}%'");
                case 1:
                    return returnDieuKien($"TenSP like '%{searchText}%'");
                case 2:
                    return returnDieuKien($"TenLoai like '%{searchText}%'");
                default:
                    return returnDieuKien($"MaSP like '%{searchText}%'"); ;
            }
        }
        private void applySearchs(string text, DataTable filteredData)
        {
            currentSearch = text;
            DataView dvSanPham = filteredData.DefaultView;

            dvSanPham.RowFilter = currentSearch;
            dgvSanPham.DataSource = dvSanPham.ToTable();
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);
            combinedCondition = ApplyOrRemoveGiaCondition(combinedCondition, isGia);
            combinedCondition = ApplyOrRemoveTonKhoCondition(combinedCondition, isTonKho);

            // Kiểm tra nếu currentListNCC đã được khởi tạo và không phải null
            if (currentListNCC != null)
            {
                applySearchs(combinedCondition, currentListNCC);
            }
            else
            {
                // Nếu currentListNCC chưa được khởi tạo, có thể hiển thị thông báo hoặc xử lý khác
                MessageBox.Show("Vui lòng chọn một nhà cung cấp trước khi tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        private int searchTrangThaibyTenNCC(string tenNCC)
        {
            int trangthai = dtNhaCungCap.AsEnumerable()
                .Where(row => row.Field<string>("TenNCC") == tenNCC)
                .Select(row => row.Field<int>("TrangThai"))
                .FirstOrDefault();
            return trangthai;
        }

        private void refreshAfterInsertCTPN()
        {
            gioHangNhap.Clear();
            lblNhaCungCap.Text = string.Empty;
            lblTongTien.Text = ConvertIntToVND(0);
            while (flpGioHangNhap.Controls.Count > 0)
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
            foreach (var item in gioHangNhap)
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
            int trangThai = searchTrangThaibyTenNCC(tenNCC);
            if (trangThai == 0)
            {
                MessageBox.Show("Nhà cung cấp không hoạt động", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var listNCC = searchWithTenNCC(tenNCC);

            // Lưu giá trị của listNCC vào biến cục bộ
            currentListNCC = listNCC;

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
            foreach (var pair in gioHangNhap)
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
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết phiếu nhập");
                return;
            }
            btnInPhieuNhap.Enabled = true;
            btnChonSanPham.Enabled = false;

        }
        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Xác nhận in phiếu nhập?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NhaCungCapDTO ncc = nccBLL.getNhaCungCapbyMaNCC(lblNhaCungCap.Text);
                Reports.PhieuNhapCreator pnCreator = new Reports.PhieuNhapCreator();
                pnCreator.DtThongTinCTPN = ctpnBLL.getListPhieuNhapbyMaPN(lblMaPN.Text.Substring(1));

                pnCreator.NgayLap = DateTime.ParseExact(lblNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString();
                pnCreator.MaPN = lblMaPN.Text.Substring(1);
                pnCreator.TenNCC = ncc.TenNCC;
                pnCreator.DiaChi = ncc.DiaChi;
                pnCreator.SoDT = ncc.SoDT;
                pnCreator.SoFAX = ncc.SoFAX;
                pnCreator.showPhieuNhapRP();
                refreshAfterInsertCTPN();
                dgvSanPham.DataSource = nhBLL.getListNhapHang();
                dtSanPham = nhBLL.getListNhapHang();
                loadMaPN();
                refreshThongTin();

            }
            else
            {
                refreshAfterInsertCTPN();
                dgvSanPham.DataSource = nhBLL.getListNhapHang();
                dtSanPham = nhBLL.getListNhapHang();

                loadMaPN();
                refreshThongTin();
            }
            btnInPhieuNhap.Enabled = false;
            btnChonSanPham.Enabled = true;

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
            if (soLuongMua == 0)
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
                }
                else if (result == DialogResult.Cancel)
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
        private bool toggleDieuKien(bool value)
        {
            return !value;
        }
        private void chkGia_CheckedChanged(object sender, EventArgs e)
        {
            isGia = toggleDieuKien(isGia);
            txtGiaStart.Enabled = isGia;
            txtGiaEnd.Enabled = isGia;

            if (!isGia)
            {
                txtGiaStart.PlaceholderText = "Từ";
                txtGiaEnd.PlaceholderText = "Đến";
                lblErrGiaFilter.Visible = false;
            }
            if (isGia)
            {
                if (int.TryParse(txtGiaStart.Texts, out int giaStartResult))
                {
                    // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                    giaStart = giaStartResult;
                }
                if (int.TryParse(txtGiaEnd.Texts, out int giaEndResult))
                {
                    // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                    giaEnd = giaEndResult;

                }
            }
            btnTimKiem_Click(sender, e);
        }

       
        private void txtGiaStart__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaStart.Texts))
            {
                giaStart = 0;
            }

            if (int.TryParse(txtGiaStart.Texts, out int giaStartResult))
            {
                giaStart = giaStartResult;

                if (giaStart < 0)
                {
                    lblErrGiaFilter.Text = "* Không được nhập giá là số âm";
                    lblErrGiaFilter.Visible = true;
                    return;
                }
                else
                {
                    lblErrGiaFilter.Visible = false;
                }

                // Kiểm tra nếu giaEnd đã được nhập và giaStart > giaEnd
                if (!string.IsNullOrEmpty(txtGiaEnd.Texts) && giaStart > giaEnd)
                {
                    lblErrGiaFilter.Text = "Sai khoảng giá";
                    lblErrGiaFilter.Visible = true;
                    return;
                }

                lblErrGiaFilter.Visible = false;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                return;
            }
        }

        private void txtGiaEnd__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiaEnd.Texts))
            {
                giaEnd = int.MaxValue; // Đặt giá trị tối đa nếu giaEnd không được nhập
            }

            if (int.TryParse(txtGiaEnd.Texts, out int giaEndResult))
            {
                giaEnd = giaEndResult;

                if (giaEnd < 0)
                {
                    lblErrGiaFilter.Text = "* Không được nhập giá là số âm";
                    lblErrGiaFilter.Visible = true;
                    return;
                }
                else
                {
                    lblErrGiaFilter.Visible = false;
                }

                // Kiểm tra nếu giaStart đã được nhập và giaEnd < giaStart
                if (!string.IsNullOrEmpty(txtGiaStart.Texts) && giaEnd < giaStart)
                {
                    lblErrGiaFilter.Text = "Sai khoảng giá";
                    lblErrGiaFilter.Visible = true;
                    return;
                }

                lblErrGiaFilter.Visible = false;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                return;
            }
        }
        private string ApplyOrRemoveGiaCondition(string condition, bool isGia)
        {
            if (isGia)
            {
                if (giaStart > 0 && giaEnd > 0 && giaStart <= giaEnd)
                {
                    return CombineConditions(condition, $"DonGiaNhap >= '{giaStart}' AND DonGiaNhap <= '{giaEnd}'");
                }
            }
            else
            {
                // Nếu không có checkbox Tuoi được chọn, xóa điều kiện lọc theo ngày sinh
                condition = condition.Replace("DonGiaNhap >= '0' AND DonGiaNhap <= '9999999' AND ", "");
            }
            return condition;
        }
        private void chkTonKho_CheckedChanged(object sender, EventArgs e)
        {
            isTonKho = toggleDieuKien(isTonKho);
            txtTonKhoStart.Enabled = isTonKho;
            txtTonKhoEnd.Enabled = isTonKho;

            if (!isTonKho)
            {
                txtTonKhoStart.PlaceholderText = "Từ";
                txtTonKhoEnd.PlaceholderText = "Đến";
                lblErrTonKhoFilter.Visible = false;
            }
            if (isTonKho)
            {
                if (int.TryParse(txtTonKhoStart.Texts, out int tonKhoStartResult))
                {
                    // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                    tonKhoStart = tonKhoStartResult;
                }
                if (int.TryParse(txtTonKhoEnd.Texts, out int tonKhoEndResult))
                {
                    // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                    tonKhoEnd = tonKhoEndResult;

                }
            }
            btnTimKiem_Click(sender, e);
        }

        private void txtTonKhoStart__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTonKhoStart.Texts))
            {
                tonKhoStart = 0;
            }
            if (int.TryParse(txtTonKhoStart.Texts, out int tonKhoStartResult))
            {
                tonKhoStart = tonKhoStartResult;
                if (tonKhoStart < 0)
                {
                    lblErrTonKhoFilter.Text = "* Không được nhập SL là số âm";
                    lblErrTonKhoFilter.Visible = true;
                    return;
                }
                if (int.Parse(txtTonKhoStart.Texts) >= tonKhoEnd)
                {

                    lblErrTonKhoFilter.Text = "Khoảng tìm kiếm không phù hợp";
                    lblErrTonKhoFilter.Visible = true;
                    return;
                }
                else
                {
                    lblErrTonKhoFilter.Visible = false;
                    tonKhoStart = tonKhoStartResult;
                    btnTimKiem_Click(sender, e);
                }
                lblErrTonKhoFilter.Visible = false;
            }

            else
            {
                return;
            }
        }

        private void txtTonKhoEnd__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTonKhoEnd.Texts))
            {
                tonKhoEnd = 0;
            }
            if (int.TryParse(txtTonKhoEnd.Texts, out int tonKhoEndResult))
            {
                tonKhoEnd = tonKhoEndResult;
                if (tonKhoEnd < 0)
                {

                    lblErrTonKhoFilter.Text = "* Không được nhập SL là số âm";
                    lblErrTonKhoFilter.Visible = true;
                    return;
                }
                if (int.Parse(txtTonKhoStart.Texts) >= tonKhoEnd)
                {

                    lblErrTonKhoFilter.Text = "Khoảng tìm kiếm không phù hợp";
                    lblErrTonKhoFilter.Visible = true;
                    return;
                }
                else
                {
                    lblErrTonKhoFilter.Visible = false;
                    btnTimKiem_Click(sender, e);
                }

            }
            else
            {
                return;
            }
        }

        private string ApplyOrRemoveTonKhoCondition(string condition, bool isTonKho)
        {
            if (isTonKho)
            {
                if (tonKhoStart > 0 && tonKhoEnd > 0 && tonKhoStart <= tonKhoEnd)
                {
                    return CombineConditions(condition, $"SoLuong >= '{tonKhoStart}' AND SoLuong <= '{tonKhoEnd}'");
                }
            }
            else
            {
                // Nếu không có checkbox Tuoi được chọn, xóa điều kiện lọc theo ngày sinh
                condition = condition.Replace("SoLuong >= '0' AND SoLuong <= '10000000' AND ", "");
            }
            return condition;
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Texts = string.Empty;

        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ngăn chặn ký tự Enter từ việc xuất hiện trong TextBox
                e.Handled = true;
                btnTimKiem_Click(sender, e);

            }
        }
    } 
}