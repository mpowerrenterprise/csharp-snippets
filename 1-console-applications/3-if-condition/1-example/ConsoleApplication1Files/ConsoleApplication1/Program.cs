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
            string name = Convert.ToString(Console.ReadLine());
       
            if (name == "kuna")
            {

                Console.WriteLine("You are kuna");
            }
            else if (name == "joker")
            {

                Console.WriteLine("You are Joker");

            }
            else if (name == "gta")
            {

                Console.WriteLine("You are gta");

            }
            else {

                Console.WriteLine("Something wrong with your input");
            }

            Console.ReadKey();
         
            //This is if elseif else method in c#.
            
            
        }
    }
}
