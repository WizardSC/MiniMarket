using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {
        public class KhuyenMai_DTO
        {
            private string maKm;
            private string tenKm;
            private DateTime ngayBd;
            private DateTime ngayKt;
            private int phanTramKm;
            private string dieuKienKm;
            private int trangThai;

            public KhuyenMai_DTO(string maKm, string tenKm, DateTime ngayBd, DateTime ngayKt, int phanTramKm, string dieuKienKm, int trangThai)
            {
                this.maKm = maKm;
                this.tenKm = tenKm;
                this.ngayBd = ngayBd;
                this.ngayKt = ngayKt;
                this.phanTramKm = phanTramKm;
                this.dieuKienKm = dieuKienKm;
                this.trangThai = trangThai;
            }
            public string Makm { get => maKm; set => maKm = value; }
            public string TenKm { get => tenKm; set => tenKm = value; }
            public DateTime NgayBd { get => ngayBd; set => ngayBd = value; }
            public DateTime NgayKt { get => ngayKt; set => ngayKt = value; }
            public int PhanTramKm { get => phanTramKm; set => phanTramKm = value; }
            public string DieuKiemKm { get => dieuKienKm; set => dieuKienKm = value; }
            public string DieuKienKm { get => dieuKienKm; set => dieuKienKm = value; }
        }
    }
}
