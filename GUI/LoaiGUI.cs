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
        private List<LoaiDTO> listLoai;
        //private LoaiDTO loaidto;
        public LoaiGUI()
        {
            InitializeComponent();
            loaibill = new LoaiBLL();
            dt = loaibill.getListLoai();
            loadMaLoai();
            clearForm();
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
            cbxTrangThai.Text = "--Chọn trạng thái--";
        }

        private void LoaiGUI_Load(object sender, EventArgs e)
        {
            init();
        }
        public void init()
        {
            dgvLoai.DataSource = loaibill.getListLoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String MaLoai = txtMaLoai.Texts;
            String TenLoai = txtTenLoai.Texts;
            string trangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            LoaiDTO LSP = new LoaiDTO(MaLoai, TenLoai, trangThaiValue);
            int flag = loaibill.insert_LoaiSP(LSP) ? 1 : 0;
            if (flag == 1)
            {
               
                MessageBox.Show("Thêm loại thành công thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                dgvLoai.DataSource = loaibill.getListLoai();
                clearForm();

            }
            else
            {
                MessageBox.Show("Thêm loại thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
       
        }

        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLoai.CurrentRow.Index;
            txtMaLoai.Texts = dgvLoai.Rows[i].Cells[0].Value.ToString();
            txtTenLoai.Texts = dgvLoai.Rows[i].Cells[1].Value.ToString();
            int trangThaiValue = Convert.ToInt32(dgvLoai.Rows[i].Cells[2].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLoai.CurrentRow.Index;
            txtMaLoai.Texts = dgvLoai.Rows[i].Cells[0].Value.ToString();
            txtTenLoai.Texts = dgvLoai.Rows[i].Cells[1].Value.ToString();
            int trangThaiValue = Convert.ToInt32(dgvLoai.Rows[i].Cells[2].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }

       private void btnSua_Click(object sender, EventArgs e)
        {
           LoaiDTO LSP = new LoaiDTO();
            LSP.TenLoai = txtTenLoai.Texts;
            LSP.MaLoai = txtMaLoai.Texts;
            string trangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            LSP.TrangThaiLoai = trangThaiValue; 

            int kq = loaibill.update_LoaiSP(LSP) ? 1 : 0;
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                init();
                

            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            //nsx.Trangthai = cbxTrangThai.Texts;



        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            
            string MaLoai = txtMaLoai.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            if (trangThai == 0)
            {
                var choice1 = MessageBox.Show("Da chuyen ve khong hoat dong", "Thông báo");
                clearForm();

            }
            else
            {
                var choice = MessageBox.Show("Xóa loại này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    bool isLoiKhoaNgoai;
                    bool kq = loaibill.delete_LoaiSP(MaLoai, out isLoiKhoaNgoai);
                    if (kq)
                    {
                        MessageBox.Show("Xóa thành công",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                        init();
                        clearForm();

                    }
                    else
                    {
                        if (isLoiKhoaNgoai)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            var result = MessageBox.Show("Không thể xóa loại sản phẩm này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                                "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                            if (result == DialogResult.OK)
                            {
                                if (trangThai == 1)
                                {
                                    var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của loại sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (result1 == DialogResult.OK)
                                    {
                                        int flag = loaibill.update_LoaiSP(trangThai, MaLoai) ? 1 : 0;
                                        if (flag == 1)
                                        {
                                            MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void dgvLoai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvLoai.Columns["TrangThai"].Index && e.Value != null)
            {
                int trangThaiValue = Convert.ToInt32(e.Value);
                if (trangThaiValue == 0)
                {
                    e.Value = "Không hoạt động";
                }
                else if (trangThaiValue == 1)
                {
                    e.Value = "Hoạt động";
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }

                            }
