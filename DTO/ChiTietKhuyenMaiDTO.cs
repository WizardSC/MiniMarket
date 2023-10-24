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
        public ChiTietKhuyenMaiDTO()
        {
           
        }
        public string Makm { get => maKm; set => maKm = value; }
        public string Masp { get => maSp; set => maSp = value; }
        public int PhanTramKm { get => phanTramKm; set => phanTramKm = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
    
}
