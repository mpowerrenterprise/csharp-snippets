using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "guna")
            {

                MessageBox.Show("The guna is logged in");
            }
            else if (textBox1.Text == "joker")
            {

                MessageBox.Show("The Joker is logged in");
            }
            else if (textBox1.Text == "hacker")
            {

                MessageBox.Show("The hacker is logged on");
            }
            else if (textBox1.Text == "maker") {

                MessageBox.Show("The maker is logged in");
            }
            else{

                MessageBox.Show("The username that you entered is not avaliable in the database table");
            }
        }
    }
}
