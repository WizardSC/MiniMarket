using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVuDTO
    {
        private string maCV;
        private string tenCV;
        private int trangThai;

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }

        public ChucVuDTO() { }

        public ChucVuDTO(string maCV, string tenCV, int trangThai)
        {
            this.maCV = maCV;
            this.tenCV = tenCV;
            this.trangThai = trangThai;
        }
    }
}
