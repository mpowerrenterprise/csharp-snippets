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
            
            int[] numbers = new int[6]; //This is how we create array in C#.
            numbers[0] = 12;
            numbers[1] = 35;
            numbers[2] = 9;
            numbers[3] = 55;
            numbers[4] = 98;
            numbers[5] = 65;

            Console.WriteLine(numbers[5]);
            Console.ReadKey();
            
        }
        
    }
}

//In C# creating an array fully distinct from other programming languages such as javascript and php.
//if we want to make string arrays we should put 'string[] nameOfArr new string[length]'.
//like that for other data types of arrays.
//array index starts at 0 like others programming languages.
//We must specify the length of array in this [] brakets.
