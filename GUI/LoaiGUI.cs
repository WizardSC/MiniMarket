using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoaiGUI : Form
    {
        private LoaiBLL loaibill;
        private DataTable dt;
        //private LoaiDTO loaidto;
        public LoaiGUI()
        {
            InitializeComponent();
            loaibill = new LoaiBLL();
            dt = loaibill.getListLoai();
            loadMaLoai();
        }

        private void loadMaLoai()
        {
            string lastMaLoai = null;
            foreach (DataRow row in dt.Rows)
            {
                lastMaLoai = row["MaLoai"].ToString();
            }
            if (lastMaLoai == "")
            {
                txtMaLoai.Texts = "L001";
            }
            int tempNum = int.Parse(lastMaLoai.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaLoai.Texts = "L0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaLoai.Texts = "L00" + (tempNum + 1).ToString();
            }
        }
        public void clearForm()
        {
            loadMaLoai();
            txtTenLoai.Texts = "";
        }

        private void LoaiGUI_Load(object sender, EventArgs e)
        {
            init();
        }
        public void init()
        {
            dgvLoai.DataSource = loaibill.getListLoai();
        }


    }

}
