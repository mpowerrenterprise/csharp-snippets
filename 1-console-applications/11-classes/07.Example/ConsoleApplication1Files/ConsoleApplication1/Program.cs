using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Employees {

        public string name;
        public int age;
        public string job;

        public Employees(string _name, int _age, string _job) {

            name = _name;
            age = _age;
            job = _job;

        }



        public void print() {

            Console.Write("My name is " + name + " and my age is " + age + " I work as a " + job);
            Console.ReadKey();
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Employees kuna = new Employees("kuna",21,"SE");
            kuna.print();
         


        
        } 

    }
}







