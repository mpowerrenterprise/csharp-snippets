using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhername
{
    class Animal
    {

        public void great() {

            System.Windows.Forms.MessageBox.Show("Hai My name is gmmi");

            
        }
        
    }


    class Dog : Animal {


    }


    //Now the Dog can access all methods,variables and properies that are in the Animal class.
    //Animal is the base class.
    //Dog is the Drived class.
}
