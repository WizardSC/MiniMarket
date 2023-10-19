using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiBLL
    {
        private LoaiDAL loaiDAL;
        public LoaiBLL()
        {
            loaiDAL = new LoaiDAL();
        }
        public DataTable getListLoai()
        {
            return loaiDAL.getListLoai();
        }
    }
}
