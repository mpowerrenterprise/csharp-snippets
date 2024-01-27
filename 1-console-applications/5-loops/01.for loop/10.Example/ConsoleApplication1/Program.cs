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

                for (int b = 1; b <= a; b++) {      // 1         first time
                                                    // 1 2       secound time
                                                    // 1 2 3     so on
                    Console.Write(b+" ");           // 1 2 3 4
                }                                   // 1 2 3 4 5
                Console.WriteLine();                // 1 2 3 4 5 6
            }
               

          Console.ReadKey();
        }
    }
}


