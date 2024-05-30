# enumerations Snippets Code

## 1- Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    enum Jobs {SoftwareDeveloper,NetworkAdmin,JavaDeveloper,PhpDeveloper };

    class Job {

        public int indexCode;
        public Jobs job;//job is the enum type.

        public Job(Jobs _job,int _indexCode)//we use Jobs(enum) instead of the int or string data type.
        {
            job = _job;//job is ths enum variable type.This variable only takes enum values.
            indexCode = _indexCode;
            

        }

        public string printData() {

            return "The job is " + job + " and indexCode " + indexCode;
        }

    }

    
    class Program
    {

        public static void Main(string[] args)
        {

           Job kuna = new Job(Jobs.SoftwareDeveloper,12);

            Console.WriteLine(kuna.printData());
            Console.ReadKey();
                
        }

    } 

}
//enum is value data type.
//int takes integer values,
//string takes string values.
//float takes floating point values.
//like enum takes enum values that we are createing.
//in line 14 i've created an enum data type called Jobs.
//And i made a variable bashed on Jobs enum data type called job.
//same as line number of 13 int data type called indexCode.
//enum is much like an array.
//in line number of 9 i've created an enum.Assigned some values.



```

### Ouput

![1-example](media/example1.png)



## 2 Example

### Program.cs


```c#
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



```



### Ouput

![2-example](media/example2.png)

## 3 Example

### Program.cs
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Type in a super hero's name to see his nickname:");
            string userValue = Console.ReadLine();

            Superhero myValue;
            if (Enum.TryParse<Superhero>(userValue, true, out myValue))
            {
                switch (myValue)
                {
                    case Superhero.Batman:
                        Console.WriteLine("Caped crusader");
                        break;
                    case Superhero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case Superhero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Does not compute");
            }

            Console.ReadLine();
        }
    }

    enum Superhero
    {
        Batman,
        Superman,
        GreenLantern
    }
}

```
### Output
![3-example](media/example3.png)

