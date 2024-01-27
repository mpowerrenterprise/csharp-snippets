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

            //Explicit means that we tell the complier to convert 
            //Implicit means that automatically converts.
            
            Item i = (Item) 3;//Explicit

           

            MessageBox.Show("This is called Explicit Convertion "+i.price.ToString());


        }

    }

 
    class Item {


        public int price {

            get;
            set;
        }

        public static explicit operator Item(int Itemprice)
        {

            Item i = new Item();
            i.price = Itemprice;
            return i;

        }

      
    }
}
