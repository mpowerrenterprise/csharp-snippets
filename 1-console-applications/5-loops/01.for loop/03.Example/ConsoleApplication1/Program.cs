using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {       
        static void Main(string[] args)
        {

            for (int a = 1000; a >= 0; a++) {

                Console.WriteLine(a);

            }
            Console.ReadKey();

        }
    }
}
//This loop will not stop.
//The condition is 'a' is greater than or equal to 0.
//as long as the condition is true the loop will run.
//so in this case loop will run infinitly.

