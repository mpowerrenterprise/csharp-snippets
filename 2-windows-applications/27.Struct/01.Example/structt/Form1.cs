using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using structtname;

namespace structt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            books b1 = new books();
            b1.title = "C";
            b1.author = "joker";
            b1.subject = "Inheritance";
            b1.book_id = 3565;

            books b2 = new books();
            b2.title = "java";
            b2.author = "maker";
            b2.subject = "loops";
            b2.book_id = 5656;

        }
    }
}
