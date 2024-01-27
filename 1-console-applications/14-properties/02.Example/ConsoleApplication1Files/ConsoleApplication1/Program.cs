using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {

        class Player {

           public int health = 100;


        }

        public static void Main(string[] args)
        {

            Player Tom = new Player();
            Console.WriteLine(Tom.health);//in this line health is 100;
            Tom.health = 40;//Here I have chagned the value to 40;
            Console.WriteLine(Tom.health);//This will print 40;
            Console.ReadKey();
                
                        
          
        
        }

    } 

}
