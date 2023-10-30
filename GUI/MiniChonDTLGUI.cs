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
    public partial class MiniChonDTLGUI : Form
    {
        public int diemTL;
        public int diemTLSuDung;
        public int diemCoTheSD;
        
        public MiniChonDTLGUI(int diemTL, int diemCoTheSD)
        {
            InitializeComponent();
            this.diemTL = diemTL;
            lblDiemTL.Text = diemTL.ToString();
            this.diemCoTheSD = diemCoTheSD;
            if (diemTL > diemCoTheSD)
            {
                lblDiemTLCoTheSD.Text = diemCoTheSD.ToString();

            } else
            {
                lblDiemTLCoTheSD.Text = diemTL.ToString();
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDiemTL.Texts, out int diemTLSuDung1))
            {
                if(diemTLSuDung1 > int.Parse(lblDiemTL.Text))
                {
                    MessageBox.Show("Không đủ điểm tích lũy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(diemTLSuDung1 > int.Parse(lblDiemTLCoTheSD.Text))
                {
                    MessageBox.Show($"Chỉ có thể sử dụng tối đa {lblDiemTLCoTheSD.Text} điểm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                diemTLSuDung = diemTLSuDung1;
                this.Close();
            }
            else
            {
                // Không thể chuyển đổi thành số nguyên, hiển thị thông báo lỗi
                MessageBox.Show("Cần nhập vào không một số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
