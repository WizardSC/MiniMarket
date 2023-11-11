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
    public partial class MiniChonKMGUI : Form
    {
        private KhuyenMaiBLL kmBLL;
        private ChiTietKhuyenMaiBLL ctkmBLL;
        private int trangThaiKM;
        private int tongTienTT;
        private int dieuKienKM;
        private DataTable dtKhuyenMai;
        private DataTable dtCTKM;
        private string maKM1;
        private int phanTramKM1;
        // Khai báo biến để lưu trữ RowIndex
        private int rowIndexForValidation = -1;
        public List<ChiTietKhuyenMaiDTO> listCTKMinFormMini { get; set; }
        public List<string> MaKMinCTKMList { get; set; }
        public List<string> MaSPinCTKMList { get; set; }
        public List<int> PhantramKMinCTKMList { get; set; }
        public List<int> TrangThaiinCTKMList { get; set; }


        public string MaKM1 { get => maKM1; set => maKM1 = value; }
        public int PhanTramKM1 { get => phanTramKM1; set => phanTramKM1 = value; }

        public MiniChonKMGUI(int tongTienTT)
        {
            InitializeComponent();
            kmBLL = new KhuyenMaiBLL();
            ctkmBLL = new ChiTietKhuyenMaiBLL();
            dtKhuyenMai = kmBLL.getListDsKm();
            dgvKhuyenMai.DataSource = dtKhuyenMai;
            this.tongTienTT = tongTienTT;

            MaKMinCTKMList = new List<string>();
            MaSPinCTKMList = new List<string>();
            PhantramKMinCTKMList = new List<int>();
            TrangThaiinCTKMList = new List<int>();

            listCTKMinFormMini = new List<ChiTietKhuyenMaiDTO>();
        }

        public MiniChonKMGUI() : this(0) // Gọi hàm khởi tạo có tham số với giá trị mặc định 0
        {
            // Mã khởi tạo không có tham số
        }

        private void MiniChonKMGUI_Load(object sender, EventArgs e)
        {


        }



        private void dgvKhuyenMai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvKhuyenMai.Columns["TrangThai"].Index && e.Value != null)
            {
                int trangThai = Convert.ToInt32(e.Value); // Chuyển đổi giá trị ô thành số nguyên

                // Lấy giá trị cột "NgayKetThuc"
                DateTime ngayKetThuc = Convert.ToDateTime(dgvKhuyenMai.Rows[e.RowIndex].Cells["NgayKetThuc"].Value);

                // Định dạng giá trị dựa trên giá trị của cột "TrangThai" và ngày kết thúc
                if (trangThai == 1 && ngayKetThuc >= DateTime.Now)
                {
                    e.Value = "Hoạt động";
                }
                else
                {
                    e.Value = "Không hoạt động";
                }

                // Đánh dấu rằng đã xử lý định dạng và không cần DataGridView thực hiện định dạng mặc định
                e.FormattingApplied = true;
            }
            rowIndexForValidation = e.RowIndex;
        }
    

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            listCTKMinFormMini = new List<ChiTietKhuyenMaiDTO>();
            MaKM1 = "";
            this.Close();

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (rowIndexForValidation != -1 ||
        (trangThaiKM == 0 || dgvKhuyenMai.Rows[rowIndexForValidation].Cells["TrangThai"].Value.ToString() == "Không hoạt động"))
            {
                MessageBox.Show("Khuyến mãi không khả dụng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tongTienTT < dieuKienKM)
            {
                MessageBox.Show("Chưa đủ điều kiện tham gia khuyến mãi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MaKM1 = txtMaKM.Texts;
            PhanTramKM1 = phanTramKM1;
            if (dieuKienKM == 0 && phanTramKM1 == 0)
            {
                dtCTKM = ctkmBLL.getListCTKM(MaKM1);
                List<ChiTietKhuyenMaiDTO> listCTKM = dtCTKM.AsEnumerable()
                        .Select(row => new ChiTietKhuyenMaiDTO
                        {
                            Makm = row.Field<string>("MaKm"),
                            Masp = row.Field<string>("MaSp"),
                            PhanTramKm = row.Field<int>("PhanTramKm"),
                            TrangThai = row.Field<int>("TrangThai")
                        })
                        .ToList();
                foreach (var ctkm in listCTKM)
                {
                    MaKMinCTKMList.Add(ctkm.Makm);
                    MaSPinCTKMList.Add(ctkm.Masp);
                    PhantramKMinCTKMList.Add(ctkm.PhanTramKm);
                    TrangThaiinCTKMList.Add(ctkm.TrangThai);


                }
                listCTKMinFormMini = listCTKM;
            }
            else
            {
                listCTKMinFormMini = new List<ChiTietKhuyenMaiDTO>();
            }

            this.Close();

        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhuyenMai.CurrentRow.Index;
            txtMaKM.Texts = dgvKhuyenMai.Rows[i].Cells[0].Value.ToString();
            txtTenKM.Texts = dgvKhuyenMai.Rows[i].Cells[1].Value.ToString();
            trangThaiKM = int.Parse(dgvKhuyenMai.Rows[i].Cells[6].Value.ToString());
            dieuKienKM = int.Parse(dgvKhuyenMai.Rows[i].Cells[5].Value.ToString());
            phanTramKM1 = int.Parse(dgvKhuyenMai.Rows[i].Cells[4].Value.ToString());
        }

        private void btnKhongApDungKM_Click(object sender, EventArgs e)
        {
            MaKM1 = "Không KM";
            PhanTramKM1 = 0;
            listCTKMinFormMini = new List<ChiTietKhuyenMaiDTO>();

            this.Close();
        }
    }
}
