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

            int num01;
            int num02;

            Console.Write("Give a number to be multiplayed");//write prints without line breack.
            num01 = Convert.ToInt32(Console.ReadLine());//ReadLine() is used to get user input form the console.
            Console.WriteLine("Give another number");
            num02 = Convert.ToInt32(Console.ReadLine());//Convert is mainly used for converting purpose at this case we convert the numbers to int32.
            Console.WriteLine("The Total is " + (num01 * num02));
            Console.ReadKey();

            //This is a simple program to multiplay two numbers together.
            //int is integer type variable.
            //float is decimalpoint number.
            //dobule is same as decimalpoint number.
            //bool is boolean type
            //string is for long string value and it is string type
            //char is for single one charactor.
            //we can also use the var keyword to define loosely typed variables.
            //arthimatic are + - * / %


        }
    }
}
