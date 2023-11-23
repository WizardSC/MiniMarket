using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyenDTO
    {
        private string tenPQ;
        private int isBanHang;
        private int isHoaDon;
        private int isNhapHang;
        private int isPhieuNhap;
        private int isKhachHang;
        private int isNhanVien;
        private int isSanPham;
        private int isLoai;
        private int isNhaSanXuat;
        private int isChucVu;
        private int isKhuyenMai;
        private int isNhaCungCap;
        private int isThongKe;
        private int isTaiKhoan;
        private int isPhanQuyen;
        public PhanQuyenDTO() { 
        
        }   
        public PhanQuyenDTO(string tenPQ, int isBanHang, int isHoaDon, int isNhapHang, int isPhieuNhap, int isKhachHang, int isNhanVien, int isSanPham, int isLoai, int isNhaSanXuat, int isChucVu, int isKhuyenMai, int isNhaCungCap, int isThongKe, int isTaiKhoan, int isPhanQuyen)
        {
            this.tenPQ = tenPQ;
            this.isBanHang = isBanHang;
            this.isHoaDon = isHoaDon;
            this.isNhapHang = isNhapHang;
            this.isPhieuNhap = isPhieuNhap;
            this.isKhachHang = isKhachHang;
            this.isNhanVien = isNhanVien;
            this.isSanPham = isSanPham;
            this.isLoai = isLoai;
            this.isNhaSanXuat = isNhaSanXuat;
            this.isChucVu = isChucVu;
            this.isKhuyenMai = isKhuyenMai;
            this.isNhaCungCap = isNhaCungCap;
            this.isThongKe = isThongKe;
            this.isTaiKhoan = isTaiKhoan;
            this.IsPhanQuyen = isPhanQuyen;
        }

        public string TenPQ { get => tenPQ; set => tenPQ = value; }
        public int IsBanHang { get => isBanHang; set => isBanHang = value; }
        public int IsHoaDon { get => isHoaDon; set => isHoaDon = value; }
        public int IsNhapHang { get => isNhapHang; set => isNhapHang = value; }
        public int IsPhieuNhap { get => isPhieuNhap; set => isPhieuNhap = value; }
        public int IsKhachHang { get => isKhachHang; set => isKhachHang = value; }
        public int IsNhanVien { get => isNhanVien; set => isNhanVien = value; }
        public int IsSanPham { get => isSanPham; set => isSanPham = value; }
        public int IsLoai { get => isLoai; set => isLoai = value; }
        public int IsNhaSanXuat { get => isNhaSanXuat; set => isNhaSanXuat = value; }
        public int IsChucVu { get => isChucVu; set => isChucVu = value; }
        public int IsKhuyenMai { get => isKhuyenMai; set => isKhuyenMai = value; }
        public int IsNhaCungCap { get => isNhaCungCap; set => isNhaCungCap = value; }
        public int IsThongKe { get => isThongKe; set => isThongKe = value; }
        public int IsTaiKhoan { get => isTaiKhoan; set => isTaiKhoan = value; }
        public int IsPhanQuyen { get => isPhanQuyen; set => isPhanQuyen = value; }
    }

}
