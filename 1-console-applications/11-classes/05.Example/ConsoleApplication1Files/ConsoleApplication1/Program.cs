using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal {

       public string name;
       public int age;


        public void printSys() {

            Console.WriteLine("The name is " + name + " and the age i " + age);
            Console.ReadKey();

        }

    }
    class Program
    {
        public static void Main(string[] args)
        {

            Animal dog1 = new Animal();
            dog1.name = "gmni";
            dog1.age = 2;
            dog1.printSys();
        
        } 

    }
}

//we can set class values like this.
//You can notice in the class we did not set any values.
//we have created an instance of Animal called dog1.
//we sat values in the main method.





