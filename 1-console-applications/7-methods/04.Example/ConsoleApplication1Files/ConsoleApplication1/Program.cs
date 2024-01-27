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
            int userNum1 = Convert.ToInt32(Console.ReadLine());

            int userNum2 = Convert.ToInt32(Console.ReadLine());

            add(userNum1, userNum2);

        }


        public static void add(int num1, int num2) {

            Console.WriteLine("Total is "+(num1 + num2));
            Console.ReadKey();
        }

    }
}

//In the main method i get two user inputs and stored them in  variables.
//I called the add method with those values.