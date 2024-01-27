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

            names.Remove("joker");//this will remove joker;

            foreach (string index in names) {

                Console.WriteLine(index);
                Console.ReadKey();
            }
        }

    }
}

//we can remove list properties by using Remove() method.But in the remove we need to put the 'text' instead of index number point. 


