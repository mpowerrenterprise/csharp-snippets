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

            Item item1 = new Item();
            item1.price = 4;

            Item item2 = new Item();
            item2.price = 6;


            Item item3 = item1 + item2;

            MessageBox.Show(item3.price.ToString());

        }
    }

    //I have a class called Item
    class Item {


        public int price {

            get;
            set;
        }
                                     //It needs Item types two parameter values.
        public static Item operator +(Item i1, Item i2) {


            Item i3 = new Item();
            i3.price = i1.price + i2.price;
            return i3;

        }

    }
}
