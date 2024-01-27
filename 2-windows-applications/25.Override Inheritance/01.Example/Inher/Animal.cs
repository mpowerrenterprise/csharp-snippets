using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhername
{
    class Animal
    {

        public virtual void great() {

            System.Windows.Forms.MessageBox.Show("Hai My name is Animal ");

            
        }
        
    }


    class Dog : Animal {

        public override void great()
        {

            System.Windows.Forms.MessageBox.Show("Hai My name is Dog");


        }

    }
}

//we cannot override without using the virtual keyword.

