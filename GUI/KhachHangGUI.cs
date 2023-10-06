
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.MyCustom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{

    public partial class KhachHangGUI : Form
    {
        private KhachHangBLL khBLL;
        private bool isFormFilter = false;


        public KhachHangGUI()
        {
            InitializeComponent();
            khBLL = new KhachHangBLL();
            
        }
        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khBLL.getListKhachHang();

            cbxTimKiem.Refresh();
            loadDataToCBX(cbxTimKiem);
        }
        //Xóa bỏ tự chọn dòng đầu tiên của DataGridView khi load form

        #region các hàm bổ trợ
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã KH");
            cbx.Items.Add("Họ");
            cbx.Items.Add("Tên");
            cbx.Items.Add("Địa chỉ");
        }
        #endregion


        private void btnFilter_Click(object sender, EventArgs e)
        {
            isFormFilter = !isFormFilter;
            if (isFormFilter)
            {
                btnFilter.BackColor = Color.FromArgb(224, 224, 224);
                flpFilter.Visible = true;
                flpFilter.BringToFront();

            }
            else
            {
                btnFilter.BackColor = Color.FromArgb(224, 252, 237);
                flpFilter.Visible = false;
                flpFilter.SendToBack();
            }
        }

        private void dgvKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKhachHang.ClearSelection();
            dgvKhachHang.CurrentCell = null;
        }
    }
}
