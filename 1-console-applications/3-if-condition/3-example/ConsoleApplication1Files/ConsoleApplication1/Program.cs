using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {

            s:

            int num1 = 10;
            int num2 = 5;

            Console.WriteLine("What is " + num1 + " is multiplyed by " + num2);

            int userInp = Convert.ToInt32(Console.ReadLine());

            if (userInp == num1 * num2)
            {

                Console.WriteLine("You are right");
                Console.ReadKey();
            }
            else {

                Console.WriteLine("Try agian");
                goto s;

            }

            
        }
    }
}
