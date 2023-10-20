using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMaiDTO
    {
     
            private string maKm;
            private string tenKm;
            private DateTime ngayBd;
            private DateTime ngayKt;
            private int phanTramKm;
            private string dieuKienKm;
            private int trangThai;

            public KhuyenMaiDTO()
            {

            }
            public string Makm { get => maKm; set => maKm = value; }
            public string TenKm { get => tenKm; set => tenKm = value; }
            public DateTime NgayBd { get => ngayBd; set => ngayBd = value; }
            public DateTime NgayKt { get => ngayKt; set => ngayKt = value; }
            public int PhanTramKm { get => phanTramKm; set => phanTramKm = value; }
            public string DieuKiemKm { get => dieuKienKm; set => dieuKienKm = value; }
            public int TrangThai{ get => trangThai; set => trangThai = value; }
        }
    
} 
