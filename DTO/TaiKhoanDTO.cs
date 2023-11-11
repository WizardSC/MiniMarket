using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        private string maTK;
        private string maNV;
        private string tenDangNhap;
        private string matKhau;
        private string quyen;
        private int trangThai;
        private DateTime ngayLap;

        public TaiKhoanDTO() { }

        public TaiKhoanDTO(string maTK, string maNV, string tenDangNhap, string matKhau, string quyen, byte trangThai, DateTime ngayLap)
        {
            this.MaTK = maTK;
            this.MaNV = maNV;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.Quyen = quyen;
            this.TrangThai = trangThai;
            this.NgayLap = ngayLap;
        }

        public string MaTK { get => maTK; set => maTK = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
    }
}
