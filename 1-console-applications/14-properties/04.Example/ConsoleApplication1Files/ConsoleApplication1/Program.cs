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

            public void damage(int _dam) {//This method takes an integer.

                health -= _dam;//decrese the parameter values from the health ammount.

            }

        }

        public static void Main(string[] args)
        {
            Player tom = new Player();//I have created a tom instance of Player().
            tom.damage(50);//I run the damage method and sent 50 as value.
            Console.WriteLine(tom.health);
            Console.ReadKey();
            
        }

    } 

}
