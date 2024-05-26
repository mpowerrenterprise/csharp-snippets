# loops Snippets Code

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

            for (int a = 0; a <= 10; a++) {//a++ is the incrementor ex:a=a+2 ,a+=2

                Console.WriteLine(a);

            }
            Console.ReadKey();

            //for loop is same as other programming languages.
        }

    }
}

```

### Ouput

![1-for-loops](media/1.png)



## 2- Example

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
        static void Main(string[] args)
        {

            for (int a = 1000; a >= 0; a--) {

                Console.WriteLine(a);

            }
            Console.ReadKey();


        }
    }
}
//a starts at 1000;
//as long as the 'a' is greater than or eqaul to 0 this loop will work.
//a-- is decrement the value each time.
//The same concept for all programming language.



```

### Ouput

![1-for-loop](media/2.png)

## 3- Example

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

            s:

            int num1 = 10;
            int num2 = 5;

            Console.WriteLine("What is " + num1 + " is multiplyed by " + num2);

            int userInp = Convert.ToInt32(Console.ReadLine());

            if (userInp == num1 * num2)
            {

                Console.WriteLine("You are right");
                Console.ReadKey();
            }
            else {

                Console.WriteLine("Try agian");
                goto s;

            }

            
        }
    }
}

```
### Ouput

![if-condition](media/3exp.png)

## 4- Example

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

           

            Random randomNumber = new Random();//This is the random number object.

            int num1 = randomNumber.Next(1, 11);//Next is a part of this obj.Next returns random integer number not negative number.
            int num2 = randomNumber.Next(1, 11);//the first 1 is the minimum num 11 is the maximum number.

            Console.WriteLine("What is " + num1 + " multiplay by " + num2);
            startAgain://why i put the loop at here the reason is if the user give the wrong answer it must not change the question.
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == num1 * num2)
            {

                Console.WriteLine("You are right");
                Console.ReadKey();

            }
            else {

                Console.WriteLine("Wrong");
                goto startAgain;
            }
            
            
        }
    }
}

```
### Ouput

![if-condition](media/4exp.png)

## 5- Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please type something and press Enter");
            //string userValue;
            //userValue = Console.ReadLine();
            //Console.WriteLine("You typed: " + userValue);
            //Console.ReadLine();

            Console.WriteLine("Would you prefer what is behind door number 1, 2 or 3?");
            string userValue = Console.ReadLine();

                        /*
            string message = "";


            if (userValue == "1")
                message = "You won a new car!";

            else if (userValue == "2")
                message = "You won a new boat!";

            else if (userValue == "3")
                message = "You won a new cat!";

            else
                message = "Sorry, we didn't understand.  You lose!";
            */

            string message = (userValue == "1") ? "boat" : "strand of lint";
            Console.WriteLine("You won a {0}!  And you typed {1}", message, userValue);

            //Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}

```
### Ouput

![if-condition](media/5exp.png)

## 6- Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 100:");
            string userValue = Console.ReadLine();

            int compareValue = int.Parse(userValue);

            if ((compareValue < 1) || (compareValue > 100))
                Console.WriteLine("The number you chose was out of bounds.");
            else if ((compareValue == 42) || (compareValue == 23) || (compareValue > 90))
                Console.WriteLine("You found one of the numbers!");
            else
                Console.WriteLine("You didn't find one of the special numbers");

            Console.ReadLine();

        }
    }
}

```
### Ouput

![if-condition](media/6exp.png)