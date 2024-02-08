using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace refer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int Age = 3;
            modify(ref Age);
            MessageBox.Show(Age.ToString()); //It would be 8  because we are passing the reference of the variable Age.
            
        }


        void modify(ref int age) {

            age += 5;

        }
    }
}
