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

            int numberOfAtt = 0;
            int att = 0;

            while (att != 6) {//This while loop will works untill the 'att' is not equal  to 6 if it is this will stop.

                att = numberGen.Next(1, 7);//This will genarate numbers between 1 to 7.
                Console.WriteLine("Rolled " + att + " Times");
                numberOfAtt += 1;
            }

            Console.WriteLine("It took " + numberOfAtt + " to  get the 6");

            Console.ReadKey();

            //while loop is used for this type of algorithems.
            //it looks like an if statement.
        }

    }
}
