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

                if (checkBox1.Checked)
                {

                    MessageBox.Show("Ok fine");
                }
                else
                {

                    MessageBox.Show("please check the box");
                }

            }
            else {

                MessageBox.Show("Enter the correct name");
            }
          
            
        }
    }
}
