using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDonDTO
    {
        private string maHD;
        private string maSP;
        private string tenSP;
        private int soLuong;
        private int donGiaBanDau;
        private int donGiaDaGiam;
        private int phantramKM;
        private int thanhTien;

        public CTHoaDonDTO()
        {
        }

        public CTHoaDonDTO(string maHD, string maSP, string tenSP, int soLuong, int donGiaBanDau, int donGiaDaGiam, int phanTramKM, int thanhTien)
        {
            this.MaHD = maHD;
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.SoLuong = soLuong;
            this.DonGiaBanDau = donGiaBanDau;
            this.DonGiaDaGiam = donGiaDaGiam;
            this.PhanTramKM = phanTramKM;
            this.ThanhTien = thanhTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGiaBanDau { get => donGiaBanDau; set => donGiaBanDau = value; }
        public int DonGiaDaGiam { get => donGiaDaGiam; set => donGiaDaGiam = value; }
        public int PhanTramKM { get => phantramKM; set => phantramKM = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
