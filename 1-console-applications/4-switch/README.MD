# 4-switch Snippets Code

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


            Random randomnuber = new Random();
           
            int num1 = randomnuber.Next(1, 12);
            int num2 = randomnuber.Next(1, 12);
            Console.WriteLine("What is " + num1 + " divited by " + num2);
            int userInp = Convert.ToInt32(Console.ReadLine());

            if (userInp == num1 / num2)
            {

                Console.WriteLine("You are right");
                Console.ReadKey();

            }
           
            else
            {

                int ranErr = randomnuber.Next(1, 4);

                switch (ranErr)
                {

                    case 1:
                        Console.WriteLine("You can do this try");
                        break;
                    case 2:
                        Console.WriteLine("Nothing is impossible");
                        break;

                    case 3:
                        Console.WriteLine("try try untill you die");
                        break;
                    case 4:
                        Console.WriteLine("You are the creation of god so you can");
                        break;
                    default:
                        Console.WriteLine("This is default");
                        break;
                }

                Console.ReadKey();


            }



        }
    }
}

```

### Ouput

![switch](media/1.png)



## 2- Example

### Program.cs


```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            Console.WriteLine("Enter your name");            
            string userInp = Convert.ToString(Console.ReadLine());

            switch (userInp)
            {

                case "kuna":
                    Console.WriteLine("You are kuna");
                    Console.ReadKey();
                    break;

                case "joker":
                    Console.WriteLine("You are joker");
                    Console.ReadKey();
                    break;

                case "gta":
                    Console.WriteLine("You are gta");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("There is no name like your searching");
                    Console.ReadKey();
                    break;
               

            }

            //This is the switch()

        }
    }
}


```

### Ouput

![switch](media/2.png)


## 3 - Example

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

            int num1 = numberGen.Next(1, 12);
            int num2 = numberGen.Next(1, 12);

            Console.WriteLine("What is " + num1 + " multiplay by " + num2);
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == (num1 * num2))
            {
                int ranAns = numberGen.Next(1, 4);

                switch (ranAns)
                {

                    case 1:
                        Console.WriteLine("You are correct");
                        break;

                    case 2:
                        Console.WriteLine("You are Good");
                        break;

                    case 3:
                        Console.WriteLine("You did it");
                        break;
                    case 4:
                        Console.WriteLine("You made it");
                        break;

                    default:
                        Console.WriteLine("YOu are done");
                        break;
                }


            }
            else {//This else statement finds the closest answers.


                int diff = (answer - (num1 * num2));//we substract the user answer by the question than depanding on the blance we guess the answer.

                if (diff == 1)
                {

                    Console.WriteLine("You are greather than close");


                }
                else if (diff == -1) {

                    Console.WriteLine("You are less than close");
                }
                else if (diff <= 10)
                {

                    Console.WriteLine("You are near the answer");
                }
                else
                {

                    Console.WriteLine("You are Out of answer");
                }

              

            }

            Console.ReadKey();


        }

    }
}

```
### Output
![switch](media/3.png)

## 4 - Example

### Program.cs
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a super hero's name to see his nickname:");
            string userValue = Console.ReadLine();

            switch (userValue.ToUpper())
            {
                case "BATMAN":
                    Console.WriteLine("Caped crusader");
                    break;
                case "SUPERMAN":
                    Console.WriteLine("Man of Steel");
                    break;
                case "Green Lantern":
                    Console.WriteLine("Emerald Knight");
                    break;
                default:
                    Console.WriteLine("Does not compute");
                    break;

            }


            Console.ReadLine();

        }
    }
}
```
### Output
![switch](media/4.png)