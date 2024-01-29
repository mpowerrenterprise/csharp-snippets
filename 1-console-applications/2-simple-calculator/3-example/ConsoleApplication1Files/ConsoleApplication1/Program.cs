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

            double num1;
            double num2;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another Number");
            num2 = Convert.ToDouble(Console.ReadLine());

            s:     //This will loop thorugh only the printing section.
            Console.WriteLine(num1 + " is added by " + num2 + " is " + (num1 + num2));
            Console.ReadKey();
            goto s;


            //This program can add decimal number.

        }
    }
}
