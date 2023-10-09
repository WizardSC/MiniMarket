
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
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{

    public partial class KhachHangGUI : Form
    {
        private KhachHangBLL khBLL;
        private bool isFormFilter = false;
        private string cbxItemsMacDinh;
        private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string genderCondition = ""; // Biến để lưu trữ điều kiện từ checkbox "Giới Tính"

        private string filterExpression = "";
        private bool isGioiTinh = false;
        private bool isTuoi = false;
        private bool isDiemTL = false;
        private bool isTrangThai = false;
        private bool isNam = false;
        private bool isNu = false;
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
            chkNam.Enabled = isGioiTinh;
            chkNu.Enabled = isGioiTinh;
        }
        //Xóa bỏ tự chọn dòng đầu tiên của DataGridView khi load form

        #region các hàm bổ trợ
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã KH");
            cbx.Items.Add("Họ");
            cbx.Items.Add("Tên");
            cbx.Items.Add("Địa chỉ");
            cbxItemsMacDinh = cbx.Items[0].ToString();
        }

        private string returnDieuKien(string text)
        {
            return text;
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

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;

            switch (cbxItemsMacDinh)
            {
                case "Mã KH":
                    textSearchCondition = returnDieuKien($"MaKH like '%{textTimKiem}%'");
                    break;
                case "Họ":
                    textSearchCondition = returnDieuKien($"Ho like '%{textTimKiem}%'");
                    break;
                case "Tên":
                    textSearchCondition = returnDieuKien($"Ten like '%{textTimKiem}%'");
                    break;
                case "Địa chỉ":
                    textSearchCondition = returnDieuKien($"DiaChi like '%{textTimKiem}%'");
                    break;
            }

            // Kết hợp điều kiện từ textbox tìm kiếm và điều kiện từ checkbox "Giới Tính"
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);

            applySearchs(combinedCondition);
        }


        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.Handled = true;
            }
        }
        
        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvKhachHang = khBLL.getListKhachHang().DefaultView;
            dvKhachHang.RowFilter = currentSearch;
            dgvKhachHang.DataSource = dvKhachHang.ToTable();
        }

        private bool toggleDieuKien(bool value)
        {
            return !value;
        }
        private string appenDieuKien(string dieuKien)
        {
            if(!string.IsNullOrEmpty(dieuKien))
            {
                return $"AND {dieuKien}";
            } else
            {
                return "";
            }
            
        }



        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            isGioiTinh = toggleDieuKien(isGioiTinh);

            // Bật hoặc tắt chkNam và chkNu dựa trên trạng thái của chkGioiTinh
            chkNam.Enabled = isGioiTinh;
            chkNu.Enabled = isGioiTinh;

            // Nếu chkGioiTinh được kiểm tra, thực hiện hành động của chkNam và chkNu
            if (isGioiTinh)
            {
                if (isNam)
                {
                    
                    chkNam_CheckedChanged(sender, e);
                }

                if (isNu)
                {
                    
                    chkNu_CheckedChanged(sender, e);
                }
            }
            else
            {
                // Nếu chkGioiTinh không được kiểm tra, tắt chkNam và chkNu và xóa check
                chkNam.Checked = false;
                chkNu.Checked = false;
                chkNam.Enabled = isGioiTinh;
                chkNu.Enabled = isGioiTinh;
            }
        }
        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            isNam = toggleDieuKien(isNam);
            UpdateGenderCondition();
            btnTimKiem.PerformClick();
        }

        // Thay đổi sự kiện khi checkbox "Nữ" thay đổi
        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            isNu = toggleDieuKien(isNu);
            UpdateGenderCondition();
            btnTimKiem.PerformClick();
        }


        // Hàm để xóa điều kiện giới tính khỏi filterExpression
        private string RemoveGenderCondition(string filter)
        {
            return filter.Replace("GioiTinh = 'Nam'", "").Replace("GioiTinh = 'Nữ'", "").Replace(" OR ", " ").Trim();
        }
        // Hàm để kết hợp các điều kiện
        private string CombineConditions(string condition1, string condition2)
        {
            if (!string.IsNullOrEmpty(condition1) && !string.IsNullOrEmpty(condition2))
            {
                return $"({condition1}) AND ({condition2})";
            }
            else if (!string.IsNullOrEmpty(condition1))
            {
                return condition1;
            }
            else if (!string.IsNullOrEmpty(condition2))
            {
                return condition2;
            }
            else
            {
                return "";
            }
        }

        private void UpdateGenderCondition()
        {
            List<string> genderConditions = new List<string>();

            if (isNam)
            {
                genderConditions.Add("GioiTinh = 'Nam'");
            }

            if (isNu)
            {
                genderConditions.Add("GioiTinh = 'Nữ'");
            }

            genderCondition = string.Join(" OR ", genderConditions);
        }





        private void chkTuoi_CheckedChanged(object sender, EventArgs e)
        {
            isTuoi = toggleDieuKien(isTuoi);
        }

        private void chkDiemTL_CheckedChanged(object sender, EventArgs e)
        {
            isDiemTL = toggleDieuKien(isDiemTL);
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            isTrangThai = toggleDieuKien(isTrangThai);

        }

        
    }
}

