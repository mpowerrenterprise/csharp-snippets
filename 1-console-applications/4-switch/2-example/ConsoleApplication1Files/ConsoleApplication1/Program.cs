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

            Console.WriteLine("Enter your name");            
            string userInp = Convert.ToString(Console.ReadLine());

            switch (userInp)
            {

                case "kuna":
                    Console.WriteLine("You are kuna");
                    Console.ReadKey();
                    break;

                case "joker":
                    Console.WriteLine("You are joker");
                    Console.ReadKey();
                    break;

                case "gta":
                    Console.WriteLine("You are gta");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("There is no name like your searching");
                    Console.ReadKey();
                    break;
               

            }

            //This is the switch()

        }
    }
}
