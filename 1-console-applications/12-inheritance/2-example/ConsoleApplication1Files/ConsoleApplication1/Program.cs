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

        class Cat : Dog {//Cat is derived from Dog.Dog is already dervied from Animal.

           public int cuteness;

            public void printCat() {

                Console.WriteLine("MEWO");

            }

        }

        public static void Main(string[] args)
        {
           

            Cat hie = new Cat();//Created an instance of Cat Class.The Cat class is dervied Dog.The Dog is already part of the Animal. 
            hie.name = "Hie";   //so we can access Dog data through out the Cat.
            hie.age = 2;
            hie.happyness = 1.5f;
            hie.cuteness = 12;
            hie.printBase();
            hie.printCat();
            hie.printDog();//Dog method
            hie.spotCount = 5;//Dog property.
   
            Console.ReadKey();


        }

    } 

}

//The Cat instances are able to access the Dog's and the Animal's properties and methods.
//Because Dog is dervied from Animal.The Cat is dervied from Dog.
//Dog has Animal data alerady so the Cat is the instance of Dog.
//through out the Cat i can access dog and Animal data.because cat is dervied from Dog.Dog is dervied from Animal.
//in this case Animal is the blueprint.

