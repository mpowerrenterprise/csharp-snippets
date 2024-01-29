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

       public static int count=0;


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            Hacker.count++;

            Console.WriteLine(Hacker.count);
            
          
            Console.ReadKey();

        
        } 

    }
}
//What is staic 
//All variables and methods are bound to the instance of Hacker that we are going to be creating.
//look at line number of 23 we created an object called kuna bashed on the Hacker class.
//if you want to increment the value of count property of kuna you could write kuna.count++;
//but by using static variable we can increment the value of Hacker.count++ so this way we can increent the count value to be 1 for all instance of objs.
//next time when you created an object bashed on kuna. you can use count value from the Hacker.count
//count will not avaliable for the insteance of objects.It will only can be accessed with Hacker class.




