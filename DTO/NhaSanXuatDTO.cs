using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaSanXuatDTO
    {
        private string maNSX;
        private string tenNSX;
        private string diaChi;
        private string soDT;

        public NhaSanXuatDTO(string maNSX, string tenNSX, string diaChi, string soDT)
        {
            this.MaNSX = maNSX;
            this.TenNSX = tenNSX;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
        }

        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
    }
}
