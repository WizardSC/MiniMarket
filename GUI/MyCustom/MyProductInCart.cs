using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyCustom
{
    public partial class MyProductInCart : UserControl
    {
<<<<<<< HEAD
        public string maSP;
        public int donGia;
        public int soLuong;
        public MyProductInCart()
        {
           
        }
=======

        public int soLuongTrongKho;
        public int soLuongMuaThem;
        public event EventHandler TangButtonClicked;
        public event EventHandler GiamButtonClicked;
        public event EventHandler DeleteButtonClicked;

        
        public MyProductInCart()
        {
>>>>>>> d2608a1a22880381357abd8e1dd862e4ca8edf3a

            InitializeComponent();
        }

        public void tinhTongTien()
        {

            //lblTongTien.Text = (soLuong*donGia).ToString() + "đ";

        }


        private void btnTang_Click(object sender, EventArgs e)
        {
            OnTangButtonClicked(EventArgs.Empty);
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            OnGiamButtonClicked(EventArgs.Empty);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnDeleteButtonClicked(EventArgs.Empty);
        }
<<<<<<< HEAD
=======
        protected virtual void OnDeleteButtonClicked(EventArgs e)
        {
            EventHandler handler = DeleteButtonClicked;
            handler?.Invoke(this, e);
        }

        protected virtual void OnTangButtonClicked(EventArgs e)
        {
            EventHandler handler = TangButtonClicked;
            handler?.Invoke(this, e);
        }

        protected virtual void OnGiamButtonClicked(EventArgs e)
        {
            EventHandler handler = GiamButtonClicked;
            handler?.Invoke(this, e);
        }
>>>>>>> d2608a1a22880381357abd8e1dd862e4ca8edf3a
    }
}
