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

            int numbersOFArr = 6;

            string[] names = new string[numbersOFArr];

            names[0] = "kuna";
            names[1] = "rakulan";
            names[2] = "joker";
            names[3] = "gta";
            names[4] = "maker";
            names[5] = "java";

            Console.WriteLine(names[5]);
            Console.ReadKey();



        }

    }
}

//This is the string type of array.
//we have created an integer called numbersofArr we have stroed 6 and we can use this in many array then we can programatically access.

