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

            List<string> names = new List<string>();

            names.Add("kuna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("hello");


            for (int a = 0; a < names.Count; a = a + 1) {

                Console.WriteLine(names[a]);
                Console.ReadKey(); 
            } 

        }

    }
}

//This is list.
//It is equal to array.but array is faster than list.
//We looped through the list by using for loop
//but when we use list we must put Count instead of length.length for array.


