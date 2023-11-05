using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        private PhieuNhap_DAL pnDAL;
        public PhieuNhapBLL()
        {
            pnDAL = new PhieuNhap_DAL();
        }

        public bool insertPhieuNhap(PhieuNhapDTO pn)
        {
            return pnDAL.insertPhieuNhap(pn);
        }
        
        public string getLastMaPN()
        {
            string lastMaPN = pnDAL.getLastMaPN();
            if (!string.IsNullOrEmpty(lastMaPN))
            {
                string tempLastNumber = lastMaPN.Substring(2);
                if(int.TryParse(tempLastNumber, out int lastNumber))
                {
                    lastNumber++;
                    string nextNumber = lastNumber.ToString("D3");
                    string nextMaPN = "#PN" + nextNumber;
                    return nextMaPN;
                }
            }
            return null;
        }
    }
}
