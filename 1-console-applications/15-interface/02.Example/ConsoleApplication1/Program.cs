using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        interface IItem
        {

            string name { get; set; }
            int goldValue { get; set; }
            
            void equipt();
            void sell();          

        }

        interface IDamageable{//This is an another interface.

            int durablity { get; set; }

            void takeDamage(int _amount);//this method takes a parameter value.
            

        }

        class Sword : IItem,IDamageable //I have inherited this class with IItem interface and the IDanageable interface.
        {                               //So This class made a contarct width these two interfaces.
                                        //This class must fllow the Contract.
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }
           


            public Sword(string _name)
            {

                name = _name;
                goldValue = 100;
                durablity = 30;

            }

            public void equipt()
            {
            
                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam) {//The parameter name may be diffrent.not be _amount we can change it. 

                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }


        }

        


        static void Main(string[] args)
        {

            Sword s1 = new Sword("Sword of disnity");
            s1.equipt();
            s1.sell();
            s1.takeDamage(20);

            
            Console.ReadKey();
        }

    }
}

