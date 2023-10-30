using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        private string maNV;
        private string ho;
        private string ten;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDT;
        private string diaChi;
        private int trangThai;
        private byte[] img;
        private string maTK;
        private string maCV;


        //public NhanVienDTO(string maNV, string ho, string ten, DateTime ngaySinh, string gioiTinh, string soDT, string diaChi, int trangThai, byte[] img,string maTK, string maCV)
        //{
        //    this.maNV = maNV;
        //    this.ho = ho;
        //    this.ten = ten;
        //    this.ngaySinh = ngaySinh;
        //    this.gioiTinh = gioiTinh;
        //    this.soDT = soDT;
        //    this.diaChi = diaChi;
        //    this.trangThai = trangThai;
        //    this.img = img;
        //    this.maTK = maTK;
        //    this.maCV = maCV;
        //}
        // Chưa thêm hình , mã tk
        public NhanVienDTO(string maNV, string ho, string ten, DateTime ngaySinh, string gioiTinh, string soDT, string diaChi, int trangThai, string maCV)
        {
            this.maNV = maNV;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.trangThai = trangThai;
            this.maCV = maCV;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public byte[] Img { get => img; set => img = value; }

        public string MaTK { get => maTK; set => maTK = value; }
        public string MaCV { get => maCV; set => maCV = value; }
    }
}
