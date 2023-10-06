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
    }
}
