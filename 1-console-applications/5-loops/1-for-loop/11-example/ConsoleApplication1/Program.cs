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

            for (int a = 1; a <= 6; a++) {

                for (int b = a; b >= 1; b--) {


                    Console.Write(b+" ");
                }
                Console.WriteLine();
            }
               

          Console.ReadKey();
        }
    }
}


