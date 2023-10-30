using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDTO
    {
        private string maLoai;
        private string tenLoai;
        private int trangThaiLoai;
        public LoaiDTO() { }

        public LoaiDTO(string maLoai, string tenLoai, int trangThaiLoai)
        {
            this.maLoai = maLoai;
            this.tenLoai = tenLoai;
            this.TrangThaiLoai = trangThaiLoai;
        }

        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
        public int TrangThaiLoai { get => trangThaiLoai; set => trangThaiLoai = value; }
    }
}
