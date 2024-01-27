using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsOverloadingName
{
    class methodOverloadingClass
    {

        public void printMe(string fname,string lname) {


            System.Windows.Forms.MessageBox.Show("The First name is "+fname+" The last name is "+lname);
            
        }

        public void printMe(int age, int phone) {


            System.Windows.Forms.MessageBox.Show("The age is "+age+" and my phone number is "+phone);

        }
        
    }
    
}

//It is same as constructor overloading.
//The signature has to be diffrent.
//Number of parameters and the type of the paramtes are the signature.


