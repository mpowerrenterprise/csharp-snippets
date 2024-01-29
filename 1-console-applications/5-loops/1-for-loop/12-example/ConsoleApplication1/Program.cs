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

            for (int a = 6; a >= 1; a--) {

                for (int b = 1; b <= a; b++) {


                    Console.Write(b+" ");
                }

                Console.WriteLine();
            }
               

          Console.ReadKey();
        }
    }
}


