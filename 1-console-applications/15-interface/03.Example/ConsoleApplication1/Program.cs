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

        interface IDamageable{

            int durablity { get; set; }

            void takeDamage(int _amount);
            

        }

        class Sword : IItem,IDamageable
        {                              
                                                                                      
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

            public void takeDamage(int _dam)
            {
                
                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }


        }

        class Axe : IItem, IDamageable//This is new class it inherited with two interfaces
        {

            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }




            public Axe(string _name)
            {

                name = _name;
                goldValue = 70;
                durablity = 50;

            }

            public void equipt()
            {

                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam)
            {

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

            Console.WriteLine();

            Axe a1 = new Axe("Ford Axe");
            a1.equipt();
            a1.sell();
            a1.takeDamage(20);
            
            Console.ReadKey();
        }

    }
}

