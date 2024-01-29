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


            bool b = false;

            //it is true.
            //!b means not false means true.
            //true not == false
            if (!b != false)
            {
                MessageBox.Show("This is true");
            }
            else {
                MessageBox.Show("This is fasle");

            }
            
        }
    }
}
