using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Utlities.ComapareValues(1,"kuna"));//This is comparing the type.
            Console.ReadKey();

        }
    }

    class Utlities
    {

        public static bool ComapareValues<T01, T02>(T01 value1, T02 value2) {

            return typeof(T01).Equals(typeof(T02));
        }

    }

}

//This is code checks the date type.