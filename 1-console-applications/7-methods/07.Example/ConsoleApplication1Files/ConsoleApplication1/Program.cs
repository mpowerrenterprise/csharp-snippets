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

            Console.WriteLine(name("kuna"));
            Console.ReadKey();

        }


        public static string name(string name) {

            return "hello "+name;

        }


    }
}

//in this case we use string because we are sending back string value.
