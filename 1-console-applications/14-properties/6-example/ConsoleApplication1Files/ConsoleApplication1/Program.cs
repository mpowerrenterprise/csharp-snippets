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

            public int health//Why we use int is because we're returning the integer value.
            {
                get//This is the get only property.
                {
                    return _health;//This means whenever we try to get health it returns the _health ammount as health.
                                   // health is public. But _health is private we can use it inside only this class.
                                   
                }   
            }

            public void damage(int _dam) {

                _health -= _dam;

            }
        }

        public static void Main(string[] args)
        {
            Player tom = new Player();
            tom.damage(10);//we can damage tom.
            //tom.health=50; //we can't decrese the value like this.because we didn't specify the setter.
            Console.WriteLine(tom.health);
            Console.ReadKey();
           
                       
        }

    } 

}
//This is get readonly.