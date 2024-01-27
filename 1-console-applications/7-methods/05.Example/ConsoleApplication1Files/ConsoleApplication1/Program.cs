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

            Console.WriteLine("Enter two numbers to be added");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            add(num1, num2);


        }


        public static void add(int num1, int num2) {

            int total = num1 + num2;

            if (total >= 10)
            {

                Console.WriteLine("The total is greather than 10");
            }
            else {

                Console.WriteLine("it is not greather than 10");
            }
            Console.ReadKey();


        }

        

    }
}

