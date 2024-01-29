using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    

    class Program
    {
        static void Main(string[] args)
        {

            KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 66);//string type is applied for Tkey int type is applied for Tvalue.
            meaning.Print();

            Console.WriteLine();

            KeyValuePair<bool, float> mea = new KeyValuePair<bool, float>(true, 26);//This is time bool and flaot.
            mea.Print();
            Console.ReadKey();
              
        }
    }

    class KeyValuePair<Tkey, Tvalue>//Tkey and Tvalue are not values they are custom data type.
    {

        public Tkey key;  //key is the variable it's data type is Tkey. 
        public Tvalue value;//value is the variable it's data type is Tvalue.

        public KeyValuePair(Tkey _key, Tvalue _value)//This is the contrctor class.
        {
            key = _key;
            value = _value;
        }

        public void Print()
        {

            Console.WriteLine("The key is " + key);
            Console.WriteLine("The value is " + value);

        }

    }
}
//by using generic we can create instences with diffrent data types.
//The data can be changed by the instance.
/*
Generics allow you to delay the specification of the data type of programming elements in a class or a method,
until it is actually used in the program.
In other words, generics allow you to write a class or method that can work with any data type.

*/
