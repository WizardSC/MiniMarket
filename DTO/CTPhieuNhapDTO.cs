using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTPhieuNhapDTO
    {
        private string maPN;
        private string maSP;
        private string tenSP;
        private int soLuong;
        private int donGiaNhap;
        private int thanhTien;

        public string MaPN { get => maPN; set => maPN = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public CTPhieuNhapDTO(string maPN, string maSP, string tenSP, int soLuong, int donGiaNhap, int thanhTien)
        {
            this.maPN = maPN;
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.soLuong = soLuong;
            this.donGiaNhap = donGiaNhap;
            this.thanhTien = thanhTien;
        }

        public CTPhieuNhapDTO()
        {
        }


    }
}
