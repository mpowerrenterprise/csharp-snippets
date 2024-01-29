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

            int total = 0;

            for (int u = 0; u < 100; u++) {

                total = total + u;
              
            }
            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
//This program will add all itreation numbers together from 0 to 100.
//first time total = 0 u is 1 so 0+1=1
//secont time total= 1 u is 2 so 1+2=3;
//third time total =3 u is 3 so 3+3=6;
//and so on.  


