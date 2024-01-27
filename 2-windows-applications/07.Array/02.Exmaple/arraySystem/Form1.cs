using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            string[] arrName = new string[5];
            arrName[0] = "guna";
            arrName[1] = "joker";
            arrName[2] = "maker";
            arrName[3] = "doer";
            arrName[4] = "rakulan";

            MessageBox.Show(arrName[2]);

        }
    }
}
