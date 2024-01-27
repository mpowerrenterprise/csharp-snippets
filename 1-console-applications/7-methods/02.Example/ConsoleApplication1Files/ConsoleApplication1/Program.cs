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

          
            greatingUser(Console.ReadLine());

        }

        public static void greatingUser(string name) {

            Console.WriteLine(name);

             last();
        }

        public static void last() {

            Console.WriteLine("Programme has been finished");
            Console.ReadKey();

        }

        

    }
}
//This is a simple program i have called the last() method in the greatingUser which is the second method in the code above.
//greatingUser method is called when the program executes because it is in the main method.
//in functional programming we call functions in functions also we could call many functions in a single function.
//method is also same as that.
