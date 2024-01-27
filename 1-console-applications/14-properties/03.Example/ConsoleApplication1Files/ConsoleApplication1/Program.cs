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

           public int health = 100;

        }

        public static void Main(string[] args)
        {
            Player tom = new Player();
            tom.health -= 40;
            Console.WriteLine(tom.health);
            Console.ReadKey();
            
        }

    } 

}
