using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        private string maSP;
        private string tenSP;
        private int soLuong;
        private int donGiaNhap;
        private int donGiaBan;
        private string donViTinh;
        private int trangThaiSP;
        private string maLoai;
        private string maNSX;
        private string maNCC;
        private byte[] img;

        public SanPhamDTO(string maSP, string tenSP, int soLuong, int donGiaNhap, int donGiaBan, string donViTinh, int trangThaiSP, string maLoai, string maNSX, string maNCC, byte[] img)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.donGiaBan = donGiaBan;
            this.donViTinh = donViTinh;
            this.trangThaiSP = trangThaiSP;
            this.maLoai = maLoai;
            this.maNSX = maNSX;
            this.maNCC = maNCC;
            this.img = img;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public int DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public int TrangThaiSP { get => trangThaiSP; set => trangThaiSP = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public byte[] Img { get => img; set => img = value; }
    }


}
