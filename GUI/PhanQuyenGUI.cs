using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PhanQuyenGUI : Form
    {
        private PhanQuyenBLL pqBLL;
        private int quyenPhanQuyen;
        private List<(RJComboBox, BiggerCheckBox)> permissionControlPairs;

        private ChucVuBLL cvBLL;
        private DataTable dtChucVu;

        public PhanQuyenGUI(int isPhanQuyen)
        {

            InitializeComponent();
            pqBLL = new PhanQuyenBLL();
            cvBLL = new ChucVuBLL();
            dtChucVu = cvBLL.getListChucVu();
            this.quyenPhanQuyen = isPhanQuyen;
            InitializePermissionControls();
            loadToCBXChonPQ();
            loadToCBX();
            checkQuyen(quyenPhanQuyen);
            //cbxDanhSach.SelectedIndex = 0;
            cbxDanhSach.Texts = "--Chọn quyền--";
        }

        private void checkQuyen(int quyen)
        {
            if (quyen == 1)
            {
                btnChinhSua.Enabled = false;
                btnResetTT.Enabled = false;
                foreach (var controlPair in permissionControlPairs)
                {
                    var cbx = controlPair.Item1;
                    var chk = controlPair.Item2;

                    cbx.Enabled = false;
                    chk.Enabled = false;
                }
            }
        }
        private void loadToCBX()
        {
            cbxDanhSach.Items.Clear();
            foreach (DataRow row in dtChucVu.Rows)
            {
                // Lấy giá trị của cột "TenCV" từ mỗi dòng
                string tenChucVu = row["TenCV"].ToString();

                cbxDanhSach.Items.Add(tenChucVu);
            }
        }
        private void reset()
        {
            cbxDanhSach.SelectedItem = -1;
            cbxDanhSach.Texts = "--Chọn quyền--";

            foreach (var controlPair in permissionControlPairs)
            {
                var cbx = controlPair.Item1;
                var chk = controlPair.Item2;

                cbx.SelectedIndex = -1;
                chk.Checked = false;
            }
        }
        private void InitializePermissionControls()
        {
            permissionControlPairs = new List<(RJComboBox, BiggerCheckBox)>
    {
        (cbxBanHang, chkBanHang),
        (cbxHoaDon, chkHoaDon),
        (cbxNhapHang, chkNhapHang),
        (cbxPhieuNhap, chkPhieuNhap),
        (cbxKhachHang, chkKhachHang),
        (cbxNhanVien, chkNhanVien),
        (cbxSanPham, chkSanPham),
        (cbxLoai, chkLoai),
        (cbxNhaSanXuat, chkNhaSanXuat),
        (cbxChucVu, chkChucVu),
        (cbxKhuyenMai, chkKhuyenMai),
        (cbxNhaCungCap, chkNhaCungCap),
        (cbxThongKe, chkThongKe),
        (cbxTaiKhoan, chkTaiKhoan),
        (cbxPhanQuyen, chkPhanQuyen)
    };
        }
        private void loadToCBXChonPQ()
        {
            cbxDanhSach.Items.Add("Nhân viên bán hàng");
            cbxDanhSach.Items.Add("Nhân viên kho");
            cbxDanhSach.Items.Add("Nhân viên quản lý");
            cbxDanhSach.Items.Add("Quản trị viên");

        }
        private void UpdatePermissionControls(RJComboBox cbx, BiggerCheckBox chk, int value)
        {
            cbx.SelectedIndex = value;
            chk.Checked = (value == 1 || value == 2);
        }
        private void cbxDanhSach_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string tenPQ = cbxDanhSach.SelectedItem.ToString();
            PhanQuyenDTO pq = pqBLL.getPhanQuyen(tenPQ);

            UpdatePermissionControls(cbxBanHang, chkBanHang, pq.IsBanHang);
            UpdatePermissionControls(cbxHoaDon, chkHoaDon, pq.IsHoaDon);
            UpdatePermissionControls(cbxNhapHang, chkNhapHang, pq.IsNhapHang);
            UpdatePermissionControls(cbxPhieuNhap, chkPhieuNhap, pq.IsPhieuNhap);
            UpdatePermissionControls(cbxKhachHang, chkKhachHang, pq.IsKhachHang);
            UpdatePermissionControls(cbxNhanVien, chkNhanVien, pq.IsNhanVien);
            UpdatePermissionControls(cbxSanPham, chkSanPham, pq.IsSanPham);
            UpdatePermissionControls(cbxLoai, chkLoai, pq.IsLoai);
            UpdatePermissionControls(cbxNhaSanXuat, chkNhaSanXuat, pq.IsNhaSanXuat);
            UpdatePermissionControls(cbxChucVu, chkChucVu, pq.IsChucVu);
            UpdatePermissionControls(cbxKhuyenMai, chkKhuyenMai, pq.IsKhuyenMai);
            UpdatePermissionControls(cbxNhaCungCap, chkNhaCungCap, pq.IsNhaCungCap);
            UpdatePermissionControls(cbxThongKe, chkThongKe, pq.IsThongKe);
            UpdatePermissionControls(cbxTaiKhoan, chkTaiKhoan, pq.IsTaiKhoan);
            UpdatePermissionControls(cbxPhanQuyen, chkPhanQuyen, pq.IsPhanQuyen);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            PhanQuyenDTO pq = new PhanQuyenDTO();
            pq.TenPQ = cbxDanhSach.SelectedItem.ToString();
            pq.IsBanHang = cbxBanHang.SelectedIndex;
            pq.IsHoaDon = cbxHoaDon.SelectedIndex;
            pq.IsNhapHang = cbxNhapHang.SelectedIndex;
            pq.IsPhieuNhap = cbxPhieuNhap.SelectedIndex;
            pq.IsKhachHang = cbxKhachHang.SelectedIndex;
            pq.IsNhanVien = cbxNhanVien.SelectedIndex;
            pq.IsSanPham = cbxSanPham.SelectedIndex;
            pq.IsLoai = cbxLoai.SelectedIndex;
            pq.IsNhaSanXuat = cbxNhaSanXuat.SelectedIndex;
            pq.IsChucVu = cbxChucVu.SelectedIndex;
            pq.IsKhuyenMai = cbxKhuyenMai.SelectedIndex;
            pq.IsNhaCungCap = cbxNhaCungCap.SelectedIndex;
            pq.IsThongKe = cbxThongKe.SelectedIndex;
            pq.IsTaiKhoan = cbxTaiKhoan.SelectedIndex;
            pq.IsPhanQuyen = cbxPhanQuyen.SelectedIndex;

            int result = pqBLL.updatePhanQuyen(pq) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Cập nhật phân quyền thành công",
                 "Thông báo",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Cập nhật phân quyền thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            reset();
        }

        private void btnResetTT_Click(object sender, EventArgs e)
        {
            reset();

        }
    }
}

