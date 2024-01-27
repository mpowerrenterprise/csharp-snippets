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

            SolidBrush so = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            Graphics g = this.CreateGraphics();
            g.FillRectangle(so, 0, 0, this.Width, this.Height);
            so.Color = Color.FromKnownColor(KnownColor.ControlLight);
            g.FillRectangle(so, 0, this.Height / 2, this.Width, this.Width / 2);
            PointF p = new Point((this.Width / 2)-(text.Length-10), (this.Height / 2)-(text.Length-10));
            FontFamily ff = new FontFamily("Arial");
            Font f = new System.Drawing.Font(ff, 8);
            so.Color = Color.Black;
            g.DrawString(text, f, so, p);
   
        }

        public string buttonText {

            get { return text; }
            set { text = value; }


        }
    }
}
