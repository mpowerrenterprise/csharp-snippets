# 2-while-loop Snippets Code

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
    class Program
    {
        public static void Main(string[] args)
        {

            int a = 0;

            while (a <= 10) {

                Console.WriteLine(a);
                a=a+1;
            }

            
          
            
            Console.ReadKey();

            //while loop is same as other programming languages.
        }

    }
}


```

### Ouput

![2-while-loop](media/example1x.png)



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
    class Program
    {
        public static void Main(string[] args)
        {


            Random numberGen = new Random();

            int numberOfAtt = 0;
            int att = 0;

            while (att != 6) {//This while loop will works untill the 'att' is not equal  to 6 if it is this will stop.

                att = numberGen.Next(1, 7);//This will genarate numbers between 1 to 7.
                Console.WriteLine("Rolled " + att + " Times");
                numberOfAtt += 1;
            }

            Console.WriteLine("It took " + numberOfAtt + " to  get the 6");

            Console.ReadKey();

            //while loop is used for this type of algorithems.
            //it looks like an if statement.
        }

    }
}


```



### Ouput

![2-while-loop](media/example2x.png)



