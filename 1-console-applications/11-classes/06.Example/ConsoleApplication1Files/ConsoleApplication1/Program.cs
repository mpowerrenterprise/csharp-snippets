using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Hacker
    {
        public static int count=0;
        public string name;
        public int age;

        public Hacker(){//Constroctor pattren.//default values.if no value assgin this will run.
		
            name = "no name";
            age = 0;
            count++;

        }

        public Hacker(string _name,int _age) {//if value assign this will run.


            name = _name;
            age = _age;
            count++;

        }

        public void print() {//printing method.

            Console.WriteLine("My name is " + name + " and my age is " + age);

        }



    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker("kuna",25);
            kuna.print();
            
            Console.ReadKey();
        
        } 

    }
}

//count can be only accessed with Hacker because that static.





