using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gotoAndRegin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = "kadksa";//default.

            switch (user)
            {

                case "guna":
                    MessageBox.Show("My name is guna");
                    break;

                case "joker":
                    MessageBox.Show("My name is joker");
                    break;

                default:
                    MessageBox.Show("This is default");
                    goto case "guna";//jumps to the case 'guna';
                    break;


            }
        }
    }
}
