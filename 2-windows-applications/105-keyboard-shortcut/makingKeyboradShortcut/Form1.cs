using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makingKeyboradShortcut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "A") {

                MessageBox.Show("My Name is guna");

            }

            if (e.Alt && e.Control) {

                MessageBox.Show("Alt and Control pressed");
            }
       
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "F") {

                textBox1.Text = "Hello";

            }
        }
    }
}

//e.Control means event with the control key.
//KeyCode has all keys.
//KeyCode has all uppercase letters.