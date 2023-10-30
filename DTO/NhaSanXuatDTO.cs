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
        private int trangThaiNSX;


        public NhaSanXuatDTO(string maNSX, string tenNSX, string diaChi, string soDT,int trangThaiNSX)
        {
            this.MaNSX = maNSX;
            this.TenNSX = tenNSX;
            this.DiaChi = diaChi;
            this.SoDT = soDT;
            this.TrangThaiNSX = trangThaiNSX;
         
           
        }

        public NhaSanXuatDTO() { }
       

        public string MaNSX { get => maNSX; set => maNSX = value; }
        public string TenNSX { get => tenNSX; set => tenNSX = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public int TrangThaiNSX { get => trangThaiNSX; set => trangThaiNSX = value; }

    }
}
