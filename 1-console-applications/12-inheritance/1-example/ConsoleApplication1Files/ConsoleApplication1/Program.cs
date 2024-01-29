using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        class Animal {//main blueprint Class.

           public string name;
           public int age;
           public float happyness;


            public void printBase() {

                Console.WriteLine("Name is " + name);
                Console.WriteLine("Age is " + age);
                Console.WriteLine("The happyness " + happyness);

            }

        }

        class Dog : Animal {//Dog is derived from Animal class.

           public int spotCount;

            public void printDog() {

                Console.WriteLine("WOFF");

            }

        }

        class Cat : Animal {//Cat is derived from Animal class.

           public int cuteness;

            public void printCat() {

                Console.WriteLine("MEWO");

            }

        }

        public static void Main(string[] args)
        {
            Dog gmmi = new Dog();//Craeted an instance of Dog class.The Dog class is dervied from Aniaml
            gmmi.name = "Gimmi";
            gmmi.age = 5;
            gmmi.happyness = 2.5f;
            gmmi.spotCount = 15;

            gmmi.printBase();
            gmmi.printDog();
            Console.ReadKey();

            Cat hie = new Cat();//Created an instance of Cat Class.The Cat class is dervied from Animal.
            hie.name = "Hie";
            hie.age = 2;
            hie.happyness = 1.5f;
            hie.cuteness = 12;
            hie.printBase();
            hie.printCat();
            Console.ReadKey();

        }

    } 

}
//The whole idea behind the inheritance is Code reuse.
//The Animal is the base class (Blueprint).
//Dog and Cat are derived from Animal Class.
//We can access properties and methods from the Animal class inside Dog or Cat.
//But We can't access data from Dog insie Cat or Car inside Dog.

    
