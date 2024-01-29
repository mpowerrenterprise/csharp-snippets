using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum Jobs {SoftwareDeveloper,NetworkAdmin,JavaDeveloper,PhpDeveloper };
    
    class Program
    {
        class Student {

           public Jobs job1;
           public string name;
           public int age;

            public void printStudentData() {

                string year;

                if (age == 1) {

                    year = "year";
					
                }else{

                    year = "years";
                }
                


                Console.WriteLine("My name is " + name);
                Console.WriteLine("I am " + age +" "+year+" old");
                Console.WriteLine("I am a " + job1);
                    
            }

        }

        public static void Main(string[] args)
        {

            Student kuna = new Student();

            kuna.age = 21;
            kuna.name = "kuna";
            kuna.job1 = Jobs.JavaDeveloper;
            kuna.printStudentData();
            Console.ReadKey();
        }

    } 

}



