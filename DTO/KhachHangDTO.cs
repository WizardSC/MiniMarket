using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class KhachHangDTO
    {
        private string maKH;
        private string ho;
        private string ten;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string soDT;
        private string diaChi;
        private int trangThai;
        private byte[] img;
        private int diemTichLuy;

        public KhachHangDTO(string maKH, string ho, string ten, DateTime ngaySinh, string gioiTinh, string soDT, string diaChi, int trangThai, byte[] img, int diemTichLuy)
        {
            this.maKH = maKH;
            this.ho = ho;
            this.ten = ten;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.soDT = soDT;
            this.diaChi = diaChi;
            this.trangThai = trangThai;
            this.img = img;
            this.diemTichLuy = diemTichLuy;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string Ho { get => ho; set => ho = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public byte[] Img { get => img; set => img = value; }
        public int DiemTichLuy { get => diemTichLuy; set => diemTichLuy = value; }
    }
}
