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

            Item i = new Item();
            i.price = 4;
            i++;
            MessageBox.Show(i.price.ToString());

            Item i2 = new Item();
            i2.price = 5;
            i2--;
            MessageBox.Show(i2.price.ToString());



        }
    }

 
    class Item {


        public int price {

            get;
            set;
        }



        public static Item operator ++(Item item) {

            Item i = new Item();
            i.price = item.price + 1;
            return i;
        }

        public static Item operator --(Item item)
        {

            Item i = new Item();
            i.price = item.price - 1;
            return i;
        }

    }
}
