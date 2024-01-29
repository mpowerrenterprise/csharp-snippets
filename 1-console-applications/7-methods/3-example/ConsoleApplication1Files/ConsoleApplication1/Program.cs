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

            add(10, 65);
            

        }


        public static void add(int num1, int num2) {

            Console.WriteLine(num1 + num2);
            Console.ReadKey();

        }

 


    }
}

//This add method takes two parameter values num1 and num2.
//we sent the parameter values from the Main method.
//add method is added two number together and print out the result.