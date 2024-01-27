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

           private int _health = 100;

            public int health{//We use int becaste we're returning integer value.

                get {//health is public this can be accessed outside this class also.

                    return _health;//we are returning the private _health as public health.
                                   //so now _health value can be used as health value outside.
                }

            }           

        }

        public static void Main(string[] args)
        {

            Player tom = new Player();
            // tom.health -= 50; We can't do this becasue we have permisson to read only.
            Console.WriteLine(tom.health);
            Console.ReadKey();
                       
        }

    } 

}
//get returns the private _health as public health.
//we can only readonly but we cannot change it's value.
