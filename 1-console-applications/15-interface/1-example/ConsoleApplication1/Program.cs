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

        class Sword : IItem
        {

            public string name { get; set; }
            public int goldValue { get; set; }
           


            public Sword(string _name)
            {

                name = _name;
                goldValue = 100;

            }

            public void equipt()
            {
            
                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }


        }

        


        static void Main(string[] args)
        {

            Sword s1 = new Sword("Sword of disnity");
            s1.equipt();
            s1.sell();

            
            Console.ReadKey();
        }

    }
}

//Interface is a contract with the classes that the classes must fllow.
//If we inherite an interface with the class ,that classes can have methods or properties that are not in the interface.
//But the classes have must have properties and methods thats are in the interface.
//We normally create a comman interface for all classes.That all classes must have properties and methods thats are interface.
//And even a class can have properties or methods thats are not in the interface. 