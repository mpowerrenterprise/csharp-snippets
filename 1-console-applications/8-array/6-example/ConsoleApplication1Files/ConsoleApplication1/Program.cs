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

            string[] names = new string[5] {

                "kuna","java","c++","php","kuna"

            };

            foreach (string index in names) {

                Console.WriteLine(index);//index has the array values.The foreach converts the values in the array to the index.
                Console.ReadKey();

            }

        }

    }
}

//This is an easy way of assign array values.

