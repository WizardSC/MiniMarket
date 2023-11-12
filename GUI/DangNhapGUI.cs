using BLL;
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
    public partial class DangNhapGUI : Form
    {
        private TaiKhoanBLL tkBLL;
        private DataTable dtTaiKhoan;
        
        public DangNhapGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            dtTaiKhoan = tkBLL.getListTaiKhoan();
        }

        //private int ketQua getTaiKhoan(string tenDangNhap, string matKhau)
        //{
        //    var query = from row in dtTaiKhoan.AsEnumerable()
        //                where row.Field<string>("TenDangNhap") == tenDangNhap
        //                and row.Field<string>("MatKhau") == matKhau
        //                select new
        //                {
        //                    TenDangNhap = row.Field<string>("TenDangNhap"),
        //                    MatKhau = row.Field<string>("MatKhau"),
        //                    TrangThai = row.Field<byte>("TrangThai")
        //                };

        //    var result = query.FirstOrDefault(); // Lấy dòng đầu tiên hoặc null nếu không có dòng nào thỏa mãn điều kiện

        //    if (result != null)
        //    {
        //        return (result.TenDangNhap, result.MatKhau, result.TrangThai);
        //    }

        //    // Trả về một giá trị mặc định hoặc throw exception nếu cần
        //    return (string.Empty, string.Empty, 0);
        //}
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
