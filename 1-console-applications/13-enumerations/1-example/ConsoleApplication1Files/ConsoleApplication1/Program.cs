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


