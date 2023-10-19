using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string soDT;
        private string soFAX;

        public NhaCungCapDTO(string maNCC, string tenNCC, string diaChi, string soDT, string soFAX)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.soFAX = soFAX;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string SoFAX { get => soFAX; set => soFAX = value; }
    }
}
