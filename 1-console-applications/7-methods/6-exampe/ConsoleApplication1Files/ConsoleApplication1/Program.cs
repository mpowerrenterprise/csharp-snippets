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

            int result = add(10, 2);

            if (result >= 10)
            {

                Console.WriteLine("Greather than 10");
            }
            else {

                Console.WriteLine("Less than 10");
            }
            Console.ReadKey();

        }


        public static int add(int num1, int num2) {//this method returns the value back.

            return num1 + num2;


        }


    }
}
//you can notice we used int instead of void.
//void means executes the code in the method never returns back.
//but if we use int or other data types depanding on the programming purpose it returns the value back.
