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

            Dictionary<string, string> books = new Dictionary<string, string>(5);
            books.Add("name1", "java");
            books.Add("name2", "C++");
            books.Add("name3", "php");

            Console.WriteLine(books["name1"]);
            Console.ReadKey();


        }
    }

}

//Dictionary are right equal to associative array.
//It is looks like list<> array.