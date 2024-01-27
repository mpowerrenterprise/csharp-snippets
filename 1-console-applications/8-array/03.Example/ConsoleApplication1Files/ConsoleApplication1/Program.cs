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



            string[] names = new string[6];

            names[0] = "kuna";
            names[1] = "rakulan";
            names[2] = "joker";
            names[3] = "gta";
            names[4] = "maker";
            names[5] = "java";

            for (int a = 0; a < names.Length; a++) {

                Console.WriteLine(names[a]);
               
            }

            Console.ReadKey();

        }
        
    }
}

//This is the string type of array.
//This looped thorgh a string array.
//.length is used to know the length of an array.
//in JS we also use the .length property but in php we use the count() method. 

