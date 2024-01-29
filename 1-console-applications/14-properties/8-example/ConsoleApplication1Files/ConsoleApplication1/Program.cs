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

           private int _health = 100;//because we don't want to directly change this value.

            public int health{//We use int becaste we're returning integer value.

                get {//health is public this can be accessed outside this class also.

                    return _health;//we are returning the private _health as public health.
                                   //so now _health value can be used as health value outside.
                }
                set {//This is for setting purpose.

                    if (value <= 0)//if the value we're passing is less than or equal to 0 the _health would be 0;
                    {
                        _health = 0;
                    }
                    else if (value >= 100)//if the value is greather than or equal to 100 the _health would be 100.
                    {

                        _health = 100;

                    }
                    else {//Otherwise 1 to 99 will be applied.

                        _health = value;
                    }

                }

            }           

        }

        public static void Main(string[] args)
        {

             Player tom = new Player();
            tom.health = -200;//It is imposiable.It returns 0.
            Console.WriteLine(tom.health);
            tom.health = 5000;//it is not posible.It retuens 100.
            Console.WriteLine(tom.health);
            tom.health = 50;//this is posiable.
            Console.WriteLine(tom.health);
            Console.ReadKey();
                       
        }

    } 

}
//we have written an if statement in the set section.loot at that carefully.

