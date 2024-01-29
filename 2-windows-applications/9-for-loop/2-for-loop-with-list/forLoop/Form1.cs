using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> names = new List<string>();
            names.Add("guna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("rakulan");

            //Count for the List
            for (int a = 0; a < names.Count; a++) {


                MessageBox.Show(names[a]);
            }

        }
    }
}
