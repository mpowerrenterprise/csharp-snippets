using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessName
{
    class accessClass
    {

        //This can be used by any instances.
        //Because it has public access modifier.
        public int a = 10;
        public string name = "guna";
        
        //This can only be accessed within this class.
        //This cannot be used by any instance.
        private string privatename = "Gta";

        //This can be used.
        public void printME() {

            System.Windows.Forms.MessageBox.Show("The Number is "+a);
            System.Windows.Forms.MessageBox.Show("The Name is " + name);

        }


    }

}
