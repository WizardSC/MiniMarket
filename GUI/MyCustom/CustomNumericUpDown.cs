using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyCustom
{
    public class CustomNumericUpDown : NumericUpDown
    {
        private Color borderColor = Color.Red;
        private int borderSize = 1;
        private int customHeight = 28;
        private Padding customPadding = new Padding(4);

        public CustomNumericUpDown()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int CustomHeight
        {
            get { return customHeight; }
            set
            {
                customHeight = value;
                this.Invalidate();
            }
        }

        public Padding CustomPadding
        {
            get { return customPadding; }
            set
            {
                customPadding = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, borderColor, borderSize, ButtonBorderStyle.Solid, borderColor, borderSize, ButtonBorderStyle.Solid, borderColor, borderSize, ButtonBorderStyle.Solid, borderColor, borderSize, ButtonBorderStyle.Solid);
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            this.Height = customHeight;

            int leftPadding = customPadding.Left;
            int topPadding = customPadding.Top;

            int contentWidth = this.Width - leftPadding - customPadding.Right;
            int contentHeight = this.Height - topPadding - customPadding.Bottom;

            if (Controls[1] is TextBox tb)
            {
                tb.SetBounds(leftPadding, topPadding, contentWidth, contentHeight);
            }
        }
    }
}
