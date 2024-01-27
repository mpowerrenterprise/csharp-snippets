using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args) //This is the main method.it exexutes when the program starts.
        {


            greetUser();//I called the method in main method becasue main method runs when the application starts.

        }

        public static void greetUser() {//this is a method which is created by me.

            Console.WriteLine("Hello world");//WriteLine() is a pre-defind method that it takes texts values as parameter's values.
            Console.ReadKey();//ReadKey() is also a pre-defind method in C#.

        }


    }
}
//method is same as functions in javascript and php.
//in javascript and php there are many pre-defind methods such as toString() fillter_var() like WriteLine() or ReadKey().
//Method has behaviors and actions or contains properties.
//It can take parameter's values like function.
//WriteLine() is a pre-defind method in C# it has it's own behaviors.
//Each methods in programming has tasks to complte like function in functional programming like JS and PHP.
//Like that our custom methods also can be written that the way we expect.
