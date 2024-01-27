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
            
            Console.WriteLine(Utlities.ComapareValues(1,1));//we can put string values or any data type instead of int.
            Console.ReadKey();

        }
    }

    class Utlities
    {

        public static bool ComapareValues<T01, T02>(T01 value1, T02 value2) {

            return value1.Equals(value2);
        }

    }

}

//we can use this code for comparition.