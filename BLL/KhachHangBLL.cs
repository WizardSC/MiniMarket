using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DTO;
namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDAL khDAL;
        private List<KhachHangDTO> listKhacHang = null;

        public KhachHangBLL()
        {
            khDAL = new KhachHangDAL();
        }

        public DataTable getListKhachHang()
        {
            return khDAL.getListKhachHang();
        }

        public bool insertKhachhang(KhachHangDTO kh)
        {
            return khDAL.insertKhachHang(kh);
        }

        public bool updateKhachHang(KhachHangDTO kh)
        {
            return khDAL.updateKhachHang(kh);
        }
    }
}
