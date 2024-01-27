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

            string[] names = new string[5];

            names[0] = "kuna";
            names[1] = "joker";
            names[2] = "gta";
            names[3] = "doer";
            names[4] = "maker";

            foreach (string index in names) {
				
                Console.WriteLine(index);

            }

            Console.ReadKey();


        }

    }
}

//This foreach loops assign array values to the index.if you don't understant it think carefully.

