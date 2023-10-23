using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class KhuyenMaiGUI : Form
    {
        private KhuyenMaiBLL kmBLL;
        private ChiTietKhuyenMaiGUI CTKhuyenMai;
        private ThongTinSPKMGUI ThongTinSPKM;
        private DataTable dt;
        private bool isFormFilter = false;
        private string cbxItemsMacDinh;
         private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private bool isTrangThai = false;
        private bool isHoatDong = false;
        private bool isKoHD = false;
        private string statusCondition = "";

        public KhuyenMaiGUI()
        {
            
            InitializeComponent();
            btnThongTinKM.Visible = false;
            kmBLL = new KhuyenMaiBLL();
            CTKhuyenMai = new ChiTietKhuyenMaiGUI();
            dt = kmBLL.getListDsKm();
            loadMaKM();
            loadDataToCBX(cbxTimKiem);

        }

        private void loadMaKM()
        {
            string lastMaKM = null;
            foreach (DataRow row in dt.Rows)
            {
                lastMaKM = row["MaKM"].ToString();
            }
            if (lastMaKM == "")
            {
                txtMaKM.Texts = "KM001";
            }
            int tempNum = int.Parse(lastMaKM.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaKM.Texts = "KM0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaKM.Texts = "KM00" + (tempNum + 1).ToString();
            }
        }

        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã KM");
            cbx.Items.Add("Tên KM");
            cbx.Items.Add("Phần Trăm KM");
            cbxTimKiem.SelectedIndex = 0;
        }

        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã KM":
                    return returnDieuKien($"MaKM like '%{searchText}%'");
                case "Tên KM":
                    return returnDieuKien($"TenKM like '%{searchText}%'");
                case "Phần Trăm KM":
                    int phanTramKM;
                    if (int.TryParse(searchText, out phanTramKM))
                    {
                        return returnDieuKien($"PhanTramKM = {phanTramKM}");
                    }
                    else
                    {
                        return "";
                    }
                default:
                    return "";
            }
        }

        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvKhuyenMai = kmBLL.getListDsKm().DefaultView;
            dvKhuyenMai.RowFilter = currentSearch;
            dgvKhuyenMai.DataSource = dvKhuyenMai.ToTable();
        }
        private void UpdateStatusCondition()
        {
            List<string> statusConditions = new List<string>();

            if (isHoatDong)
            {
                statusConditions.Add("TrangThai = 1");
            }

            if (isKoHD)
            {
                statusConditions.Add("TrangThai = 0");
            }

            statusCondition = string.Join(" OR ", statusConditions);
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

        public void clearForm()
        {
            loadMaKM();
            txtTenKm.Texts = "";
            txtDkKM.Texts = "";
            DateTime currentDate = DateTime.Now;
            dtpNgayBD.Value = currentDate;
            dtpNgayKT.Value = currentDate;
            txtPhanTramKM.Texts = "";
            cbxTrangThai.SelectedIndex = 0;
            btnThongTinKM.Visible = false;
        }
        //load form DataTable
        public void init()
        {
            dgvKhuyenMai.DataSource = kmBLL.getListDsKm();

            cbxTrangThai.SelectedIndex = 0;
        }
        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            init();
           
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
           CTKhuyenMai.ShowDialog();
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnThongTinKM_Click(object sender, EventArgs e)
        {
            string MaKM = txtMaKM.Texts;
            DataTable dataTable = kmBLL.getThongTinSPKM(MaKM);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                ThongTinSPKMGUI ThongTin = new ThongTinSPKMGUI(this, MaKM);
                ThongTin.Show();
            }
            else
            {
                MessageBox.Show("Khuyến mãi này chưa áp dụng cho sản phẩm nào.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;
            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();
            KM_DTO.Makm = txtMaKM.Texts;
            KM_DTO.TenKm = txtTenKm.Texts; ;
            KM_DTO.NgayBd = dtpNgayBD.Value;
            KM_DTO.NgayKt = dtpNgayKT.Value;
            KM_DTO.PhanTramKm= int.Parse(txtPhanTramKM.Texts);
            KM_DTO.DieuKiemKm = txtDkKM.Texts;
            KM_DTO.TrangThai = trangthai;
            try
            {
                kmBLL.insertKhuyenMai(KM_DTO);
                MessageBox.Show("Thêm khuyến mãi thành công!");
                loadMaKM();
                init();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
            {
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;
            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();

            KM_DTO.TenKm = txtTenKm.Texts; ;
            KM_DTO.NgayBd = dtpNgayBD.Value;
            KM_DTO.NgayKt = dtpNgayKT.Value;
            KM_DTO.PhanTramKm = int.Parse(txtPhanTramKM.Texts);
            KM_DTO.DieuKiemKm = txtDkKM.Texts;
            KM_DTO.TrangThai = trangthai;
            KM_DTO.Makm = txtMaKM.Texts;
            try
            {
                kmBLL.UpdateKhuyenMai(KM_DTO);
                MessageBox.Show("Chỉnh sửa khuyến mãi thành công!");
                loadMaKM();
                init();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string maKM = txtMaKM.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa khuyến mãi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                bool kq = kmBLL.deleteKhuyenMai(maKM, out isLoiKhoaNgoai);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                        loadMaKM();
                        init();
                        clearForm();

                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa sản phẩm này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    int flag = kmBLL.updateTrangThai(trangThai, maKM) ? 1 : 0;
                                    if (flag == 1)
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        loadMaKM();
                                        init();
                                        clearForm();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                                else if (result1 == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                            else return;

                        }

                    }

                }
            }
        }

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

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhuyenMai.CurrentRow.Index;
            txtMaKM.Texts = dgvKhuyenMai.Rows[i].Cells[0].Value.ToString();
            DateTime NgayBd = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[2].Value.ToString());
            DateTime NgayKt = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[3].Value.ToString());
            txtTenKm.Texts = dgvKhuyenMai.Rows[i].Cells[1].Value.ToString();
            dtpNgayBD.Value = NgayBd;
            dtpNgayKT.Value = NgayKt;
            txtPhanTramKM.Texts = dgvKhuyenMai.Rows[i].Cells[4].Value.ToString();
            txtDkKM.Texts = dgvKhuyenMai.Rows[i].Cells[5].Value.ToString();
            int TrangThai = int.Parse(dgvKhuyenMai.Rows[i].Cells[6].Value.ToString());
            if (TrangThai == 1)
            {
                cbxTrangThai.SelectedIndex = 0;
            }
            else
            {
                cbxTrangThai.SelectedIndex = 1;
            }

            if (txtDkKM.Texts == "")
            {
                btnThongTinKM.Visible = true;
            }
            else
            {
                btnThongTinKM.Visible = false;
            }
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, statusCondition);
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

        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            isHoatDong = toggleDieuKien(isHoatDong);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }

        private void chkKoHD_CheckedChanged(object sender, EventArgs e)
        {
            isKoHD = toggleDieuKien(isKoHD);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }
        private bool toggleDieuKien(bool value)
        {
            return !value;
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            isTrangThai = toggleDieuKien(isTrangThai);
            chkHoatDong.Enabled = isTrangThai;
            chkKoHD.Enabled = isTrangThai;
            if (isTrangThai)
            {

                if (isHoatDong)
                {

                    chkHoatDong_CheckedChanged(sender, e);
                }

                if (isKoHD)
                {
                    chkKoHD_CheckedChanged(sender, e);
                }
            }
            else
            {
                // Nếu chkHoatDong không được kiểm tra, tắt chkHd và chkKhd và xóa check
                chkHoatDong.Checked = false;
                chkKoHD.Checked = false;
                chkHoatDong.Enabled = isHoatDong;
                chkKoHD.Enabled = isKoHD;
            }
        }
    }
}
