using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        private string maPN;
        private DateTime ngayLap;
        private int tongTien;
        private string maNV;
        private string maNCC;

        public PhieuNhapDTO()
        {
        }

        public PhieuNhapDTO(string maPN, DateTime ngayLap, int tongTien, string maNV, string maNCC)
        {
            this.maPN = maPN;
            this.ngayLap = ngayLap;
            this.tongTien = tongTien;
            this.maNV = maNV;
            this.maNCC = maNCC;
        }

        public string MaPN { get => maPN; set => maPN = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
    }
}
