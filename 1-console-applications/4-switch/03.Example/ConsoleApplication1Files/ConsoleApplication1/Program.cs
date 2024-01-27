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

            Random numberGen = new Random();

            int num1 = numberGen.Next(1, 12);
            int num2 = numberGen.Next(1, 12);

            Console.WriteLine("What is " + num1 + " multiplay by " + num2);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (num1 * num2))
            {
                int ranAns = numberGen.Next(1, 4);

                switch (ranAns)
                {

                    case 1:
                        Console.WriteLine("You are correct");
                        break;

                    case 2:
                        Console.WriteLine("You are Good");
                        break;

                    case 3:
                        Console.WriteLine("You did it");
                        break;
                    case 4:
                        Console.WriteLine("You made it");
                        break;

                    default:
                        Console.WriteLine("YOu are done");
                        break;
                }


            }
            else {//This else statement finds the closest answers.


                int diff = (answer - (num1 * num2));//we substract the user answer by the question than depanding on the blance we guess the answer.

                if (diff == 1)
                {

                    Console.WriteLine("You are greather than close");


                }
                else if (diff == -1) {

                    Console.WriteLine("You are less than close");
                }
                else if (diff <= 10)
                {

                    Console.WriteLine("You are near the answer");
                }
                else
                {

                    Console.WriteLine("You are Out of answer");
                }

              

            }

            Console.ReadKey();


        }

    }
}
