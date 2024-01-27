using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DestructorAndConstructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            myClass m = new myClass();
        }
    }

    class myClass {

        //This works when the first time it will run.
        public myClass() {

            MessageBox.Show("I am the Constructor");

        }

        //This work when the program get closed.
        ~myClass() {

            MessageBox.Show("I am the Destructor");

        }
    }
}
