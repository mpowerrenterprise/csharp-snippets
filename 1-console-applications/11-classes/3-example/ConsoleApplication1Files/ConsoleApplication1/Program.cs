using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hacker {

       public string name = "Joker";
       public int age = 21;

       public string printOut() {

            return "My name is " + name + " and my age is " + age;

        }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            Console.Write(kuna.printOut());

            Console.ReadKey();

        
        } 

    }
}
//look at line 16 i return the value back.
//so used string instead of void.
//void will execute the code.
//We must put public to the infront of the variable.Otherwise we can't access the value outside any classes.




