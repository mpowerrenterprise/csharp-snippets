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


        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush so = new SolidBrush(Color.FromKnownColor(KnownColor.Control));
            Graphics g = this.CreateGraphics();
            g.FillRectangle(so, 0, 0, this.Width, this.Height);
            so.Color = Color.FromKnownColor(KnownColor.ControlLight);//change the Color to ControlLight
            g.FillRectangle(so, 0, this.Height / 2, this.Width, this.Width / 2);//we made a rectangle
            label1.Location = new Point((this.Width / 2)-(label1.Width/2), (this.Height / 2)-(label1.Height/2));//to make center the text.
   
        }

        public string buttonText {

            get { return label1.Text; }
            set { label1.Text = value; }


        }
    }
}
