
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
        /// 
        private static GiaoDienGUI mainForm;
        private static bool mainFormClosed = false;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new TestCameraQR());
            //Application.Run(new GiaoDienGUI());
            DangNhapGUI loginForm = new DangNhapGUI();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                string maNV = loginForm.maNV;
                string tenPQ = loginForm.tenPQ;

                mainForm = new GiaoDienGUI(maNV, tenPQ);
                loginForm.Hide();             
                mainForm.ShowDialog();
                loginForm.Dispose();
               
            }



        }
    
      
    }
}
