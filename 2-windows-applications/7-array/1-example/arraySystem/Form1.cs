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


            string[] arr = { "guna", "joker", "hacker", "doer", "maker" };

            if (arr[1] == "joker") {

                MessageBox.Show("This array has joker in the second cache");
            }

        }
    }
}
