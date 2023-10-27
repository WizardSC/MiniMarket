using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string maHD;
        private DateTime ngayLapHD;
        private int tongTienTT;
        private int diemSuDung;
        private float tongTien;
        private int diemNhanDuoc;
        private string maKM;
        private string maNV;
        private string maKH;
        public HoaDonDTO()
        {

        }
        public HoaDonDTO(string maHD, DateTime ngayLapHD, int tongTienTT, int diemSuDung, float tongTien, int diemNhanDuoc, string maKM, string maNV, string maKH)
        {
            this.maHD = maHD;
            this.ngayLapHD = ngayLapHD;
            this.tongTienTT = tongTienTT;
            this.diemSuDung = diemSuDung;
            this.tongTien = tongTien;
            this.diemNhanDuoc = diemNhanDuoc;
            this.maKM = maKM;
            this.maNV = maNV;
            this.maKH = maKH;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public DateTime NgayLapHD { get => ngayLapHD; set => ngayLapHD = value; }
        public int TongTienTT { get => tongTienTT; set => tongTienTT = value; }
        public int DiemSuDung { get => diemSuDung; set => diemSuDung = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public int DiemNhanDuoc { get => diemNhanDuoc; set => diemNhanDuoc = value; }
        public string MaKM { get => maKM; set => maKM = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
    }
}
