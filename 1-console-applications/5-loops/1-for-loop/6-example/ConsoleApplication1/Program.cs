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


            for (int i = 2; i <= 100; i++) {

                if (i % 2 == 0) {

                    Console.WriteLine(i);
                }
              
            }

            Console.ReadKey();
        }
    }
}

//every time this loop runs it checks the i value divided by 2 ==0.
//if it is it will print.
//so this loop will print even numbers.

