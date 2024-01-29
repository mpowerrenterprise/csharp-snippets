using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structtname
{

    class myClass {

        delegate void myDelegate(string myString);

        public void showTheMessage() {


            myDelegate md = new myDelegate(showMsg);
            md += showAnotherMs;
            md("guna");
        }

        public void showMsg(string str) {

            System.Windows.Forms.MessageBox.Show(str+" method 1");

        }

        public void showAnotherMs(string str) {

            System.Windows.Forms.MessageBox.Show(str+" method 2");
        }
    }
  

}


