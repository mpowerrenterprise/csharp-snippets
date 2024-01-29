using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methodretuen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = printme("kuna");
            MessageBox.Show(name);


        }

        string printme(string n) {

            return n;
            
        }

        //if we put the data type instead of void mean we are returning.
        //void means execute the method.
        //data type means return the value back.
    }
}
