using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     class Program
    {
        class Player {

            private int health = 100;
            public int hal(int _h) {

             return  health = health - _h;
               
            }

           
           
        }

        static void Main(string[] args)
        {

            Player kuna = new Player();
            Console.WriteLine(kuna.hal(5));
            Console.ReadKey();
         
        }
    }
}

