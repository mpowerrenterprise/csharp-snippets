using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hacker {
		
       public string name = "Joker";
       public int age = 21;

    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            Console.WriteLine(kuna.name);
            Console.ReadKey();       
        } 

    }
}

//Hacker is a simple class.
//Class is a blueprint for our program.
//We could have many calasses in one single program.
//We normally create a class (blueprint) and use as an object in our program
//look at line 22.I have created an instence bashed on the hacker class. 
//public can access outside the class.
//private can access only inside the class.These are look like scoping in javascript and php.
//Inside the Hacker class we have two values string value and a integer vaule.
//we can also create classes in javascript by using contructor pattren or factory pattren.

