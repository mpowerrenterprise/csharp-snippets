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

           

            Random randomNumber = new Random();//This is the random number object.

            int num1 = randomNumber.Next(1, 11);//Next is a part of this obj.Next returns random integer number not negative number.
            int num2 = randomNumber.Next(1, 11);//the first 1 is the minimum num 11 is the maximum number.

            Console.WriteLine("What is " + num1 + " multiplay by " + num2);
            startAgain://why i put the loop at here the reason is if the user give the wrong answer it must not change the question.
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == num1 * num2)
            {

                Console.WriteLine("You are right");
                Console.ReadKey();

            }
            else {

                Console.WriteLine("Wrong");
                goto startAgain;
            }
            
            
        }
    }
}
