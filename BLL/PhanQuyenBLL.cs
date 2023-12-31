﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        private PhanQuyenDAL pqDAL;
        public PhanQuyenBLL()
        {
            pqDAL = new PhanQuyenDAL();
        }
        public PhanQuyenDTO getPhanQuyen(string tenPQ)
        {
            return pqDAL.getPhanQuyen(tenPQ);
        }

        public bool updatePhanQuyen(PhanQuyenDTO pq)
        {
            return pqDAL.updatePhanQuyen(pq);
        }

        public bool insertPhanQuyen(string tenPQ)
        {
            return pqDAL.insertPhanQuyen(tenPQ);
        }
    }
}
