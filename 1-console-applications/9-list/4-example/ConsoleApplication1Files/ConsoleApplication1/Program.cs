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

            names.RemoveAt(1);//this will remove joker;

            for (int u = 0; u <= names.Count; u += 1) {

                Console.WriteLine(names[u]);
               

            }
            Console.ReadKey();
        }

    }
}

//we can remove list properties by using RemoveAt method.


