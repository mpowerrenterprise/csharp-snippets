using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class StudentData {

        public string name;
        public int age;
        public string stream;

        public void printData() {

            Console.WriteLine("The name is " + name);
            Console.WriteLine("The age is " + age);
            Console.WriteLine("The Strem is " + stream);

        }

    }

    class ClassRoom : StudentData{

        public string nameOfClass;

        public void printClass() {

            Console.WriteLine(nameOfClass);
                
        }

    }

    class Program
    {
       

        public static void Main(string[] args)
        {

            ClassRoom kuna = new ClassRoom();
            kuna.name = "kuna";
            kuna.age = 21;
            kuna.stream = "Computer Sciecnce";
            kuna.printData();
            kuna.nameOfClass = "A level";
            kuna.printClass();

            Console.ReadKey();

        }

    } 

}
//another Example of inheritance.


