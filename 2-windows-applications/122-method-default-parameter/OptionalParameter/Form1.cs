using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptionalParameter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShowMsg("guna",10);//we send 10.

        }

        //The default value for the is 5.
        void ShowMsg(string name,int age=5) {


            for (int s = 0; s <= age; s++)
            {

                MessageBox.Show("My name is " + name);

            }

        }
    }
}
