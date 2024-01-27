using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numArr = 10;

            float[] Dnums = new float[numArr];
            
            for(int r = 0; r < Dnums.Length; r++)//This loop assigned numbers to the entire array.
            {

                Dnums[r] = 95 + r;

            }

            for (int a = 0; a < Dnums.Length; a++) {//This array loop through the assigned array one by one.


                Console.WriteLine(Dnums[a]);
                Console.ReadKey(); 

            }





        }

    }
}

//This is the string type of array.
//we have created an integer called numbersofArr we have stroed 6 and we can use this in many array then we can programatically access.

