using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietKhuyenMaiDTO
    {
        private string maKm;
        private string maSp;
        private int phanTramKm;
        private int trangThai;
        public ChiTietKhuyenMaiDTO(string maKm, string maSp, int phanTramKm,int trangThai)
        {
            this.maKm = maKm;
            this.maSp = maSp;
            this.phanTramKm = phanTramKm;
            this.trangThai = trangThai;
        }
        public string Makm { get => maKm; set => maKm = value; }
        public string TenKm { get => maSp; set => maSp = value; }
        public int PhanTramKm { get => phanTramKm; set => phanTramKm = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
    
}
