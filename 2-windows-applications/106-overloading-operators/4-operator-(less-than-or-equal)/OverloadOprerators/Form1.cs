using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverloadOprerators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Item i1 = new Item();
            i1.price = 4;

            Item i2 = new Item();
            i2.price = 5;

            if (i1 <= i2) {

                MessageBox.Show("I1 is less than or equal to I2");
            }

            if (i2 >= i1) {

                MessageBox.Show("I2 is grater than or equal to I1");
            }

           

        }
    }

 
    class Item {


        public int price {

            get;
            set;
        }


        public static bool operator <=(Item i1, Item i2) {

            return (i1.price <= i2.price) ? true : false;


        }

        public static bool operator >=(Item i1, Item i2)
        {
            return (i1.price >= i2.price) ? true : false;

        }

    }
}
