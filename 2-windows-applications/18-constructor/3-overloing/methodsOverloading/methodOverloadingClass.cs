using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsOverloadingName
{
    class methodOverloadingClass
    {

        public methodOverloadingClass(string fname,string lname){


            System.Windows.Forms.MessageBox.Show("The first name is "+fname+" and the last name is "+lname);
        }

        public methodOverloadingClass(int age, int phone) {

            System.Windows.Forms.MessageBox.Show("The age is "+age+" and my phone number is "+phone);

        }

        public methodOverloadingClass(string name, string city, int zipCode) {

            System.Windows.Forms.MessageBox.Show("The name is " + name + " and the city is " + city + " and the zip code is " + zipCode);
        }
        
    }
    
}

//This is callled constructor overloading.
//signature has be diffrent from other constructors.
//The number of parameters and the type of parameter is the signature.
