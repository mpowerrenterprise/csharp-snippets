using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Animal {

            public string name="I came from Animal";
            
        }

        class Dog : Animal {//Dog is dervied from Animal.

            public string name;

            public void printDog() {

                Console.WriteLine("The Dog class property is "+name);//This is the Dog class name variable.
                Console.WriteLine("The Animal class propety is" + base.name);//This is the Animal class variable.
                
            }
            


        }
            

        public static void Main(string[] args)
        {

            Dog gmi = new Dog();
            gmi.name = "gimi";//value to Dog class.
            gmi.printDog();
            Console.ReadKey();
          

        }

    } 

}
//for some cases we need to have same name variable inside the dervied class.
//for that needs we can use base keyword to access the blueprint variable.



