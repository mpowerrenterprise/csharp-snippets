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


            Random randomnuber = new Random();
           
            int num1 = randomnuber.Next(1, 12);
            int num2 = randomnuber.Next(1, 12);
            Console.WriteLine("What is " + num1 + " divited by " + num2);
            int userInp = Convert.ToInt32(Console.ReadLine());

            if (userInp == num1 / num2)
            {

                Console.WriteLine("You are right");
                Console.ReadKey();

            }
           
            else
            {

                int ranErr = randomnuber.Next(1, 4);

                switch (ranErr)
                {

                    case 1:
                        Console.WriteLine("You can do this try");
                        break;
                    case 2:
                        Console.WriteLine("Nothing is impossible");
                        break;

                    case 3:
                        Console.WriteLine("try try untill you die");
                        break;
                    case 4:
                        Console.WriteLine("You are the creation of god so you can");
                        break;
                    default:
                        Console.WriteLine("This is default");
                        break;
                }

                Console.ReadKey();


            }



        }
    }
}
