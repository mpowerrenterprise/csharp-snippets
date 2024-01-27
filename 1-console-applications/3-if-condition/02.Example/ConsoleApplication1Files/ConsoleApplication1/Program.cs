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
            Console.WriteLine("What is 10 divited by 2");
            int userInp = Convert.ToInt32(Console.ReadLine());

            if (userInp == 5)
            {

                Console.WriteLine("You are done");
                Console.ReadKey();
            }
            else {

                Console.WriteLine("Try again");
                goto s;
            }           
            
        }
    }
}
