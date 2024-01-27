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

       public void printOut() {

            Console.WriteLine("My name is " + name + " and my age is " + age);

        }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            kuna.printOut();

            Console.ReadKey();

        
        } 

    }
}

//We are able to have methods in classess.I have a method on line number of 14.
//void means executes the code inside it.
//if you want to return the value back.We must use the variable type instead of void.
//return means send back the result.



