using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateOwnControler
{
    public partial class MyButton : UserControl
    {
        public MyButton()
        {
            InitializeComponent();
        }

        string text = "";
        protected override void OnPaint(PaintEventArgs e)
        {


            drawButton(Color.FromKnownColor(KnownColor.Control));
   
        }

        public string buttonText {

            get { return text; }
            set { text = value; }


        }

        void drawButton(Color c) {

            SolidBrush so = new SolidBrush(c);
            Graphics g = this.CreateGraphics();
            g.FillRectangle(so, 0, 0, this.Width, this.Height);
            so.Color = Color.FromArgb(255, c.R - 13, c.G - 13, c.B - 13);//we subtract to make dark.
            g.FillRectangle(so, 0, this.Height / 2, this.Width, this.Width / 2);
            PointF p = new Point((this.Width / 2) - (text.Length - 10), (this.Height / 2) - (text.Length - 10));
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            so.Color = Color.Black;
            g.DrawString(text, f, so, p);

        }

        private void MyButton_MouseHover(object sender, EventArgs e)
        {
            Color mycolor = Color.FromArgb(255, Color.FromKnownColor(KnownColor.Control).R - 30, Color.FromKnownColor(KnownColor.Control).G - 3, 255);
            //we subtract the Red and green to make the blue bright.
            drawButton(mycolor);
        }

        private void MyButton_MouseLeave(object sender, EventArgs e)
        {
            drawButton(Color.FromKnownColor(KnownColor.Control));
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
