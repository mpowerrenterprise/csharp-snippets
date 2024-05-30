using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

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

            using (myClass m = new myClass())
            {


            }

        }
    }

    class myClass : IDisposable
    {

        Image i;
        public myClass()
        {


            i = Image.FromFile("C:\\Users\\Joker Hacker\\Desktop\\k.PNG");

        }

        public void Dispose()
        {
            Disposed(true);
            GC.SuppressFinalize(this);

        }

        protected virtual void Disposed(bool b)
        {
            if (b) {

                i.Dispose();
            }
            
        }

        ~myClass() {

            MessageBox.Show("Guna");
        }
    }

}
