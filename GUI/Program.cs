
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new GiaoDienGUI());
            DangNhapGUI loginForm = new DangNhapGUI();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Chỉ khi đăng nhập thành công, hãy hiển thị form chính
                string maNV = loginForm.maNV;
                string tenPQ = loginForm.tenPQ;
                Application.Run(new GiaoDienGUI(maNV,tenPQ));
            }



        }
    }
}
