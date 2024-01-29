using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomName
{
    class Class1
    {
        string name = "";
        int age = 0;

        public Class1(string n)
        {

            name = n;

        }

        

        public Class1(string n, int age) {

            age = age;
            name = name;
        }

        public void printname() {

            System.Windows.Forms.MessageBox.Show(name);

        }

    }
}

//the parameter type and the number of paramers is diffrentsiate the signature.


