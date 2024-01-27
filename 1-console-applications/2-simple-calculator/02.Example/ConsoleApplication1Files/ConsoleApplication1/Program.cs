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
            start:
            int num1;
            int num2;

            Console.WriteLine("Enter a number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1+" is divited by "+num2+" is "+(num1/num2));
            Console.ReadKey();
            goto start;

            //same as the pervioues program but this program works in a loops.
            //that's why i put goto;
			//This program will work in an infinite loop.
            
        }
    }
}
