# Basic Snippets Code

## 0-helloword Example

### Program.cs

```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a comment.
            Console.WriteLine("Hi");
            Console.WriteLine("Hello World!");
            Console.ReadLine();

        }

    }
}


```

### Ouput

![HelloWorld](media/helloword-exmaple.PNG)



## 1-variable Example

### Program.cs


```c#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
             */
            //string myfirstname;
            //string myFirstName;
            //myFirstName = "Bob";

            //string myFirstName = "Bob";

            //var myFirstName = "Bob";

            //Console.WriteLine(myFirstName);


            int x = 7;
            string y = "5";
            string myFirstTry = x.ToString() + y;
            int mySecondTry = x + int.Parse(y);
            Console.WriteLine(myFirstTry);
            Console.WriteLine(mySecondTry);

            Console.ReadLine();


        }
    }
}


```



### Ouput

![HelloWorld](media/variables.PNG)

## 2-strings Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
           // string myString = "Go to your c:\\ drive";
           // string myString = "My \"so called\" life";
           // string myString = "What if I need \n a new line?";

           // string myString = string.Format("{0}!", "Hello");
            //string myString = string.Format("Make: {0} (Model: {1})", "BMW", "745li");

            //string myString = string.Format("{0:C}", 123.45);

            //string myString = string.Format("{0:N}", 1234567890);

            //string myString = string.Format("{0:P}", .123);

            //string myString = string.Format("Phone number: {0:(###) ###-####}", 1234567890);


            //string myString = "";

            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                //myString = myString + "--" + i.ToString();
               // myString += "--" + i.ToString();

                myString.Append("--");
                myString.Append(i);

            }
            */


            string myString = "It's better to be lucky than good.  ";



            //myString = myString.Substring(5, 12);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");

            myString = String.Format("Length Before: {0} -- After: {1}", myString.Length, myString.Trim().Length);

            Console.WriteLine(myString);
            Console.ReadLine();


        }
    }
}

```
### Ouput

![HelloWorld](media/string.PNG)

## 3-operators-expressions-statements Example

### Program.cs
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int x = 0;
            int y = 0;
            int a = 0;
            int b = 0;


            // Assignment operator
            x = 3;

            // Addition operator
            x = 3 + 4;

            // Subtraction operator
            x = 4 - 3;

            // Multiplication operator
            x = 10 * 5;

            // Division operator
            x = 10 / 5;

            // Equality operator
            if (x == y)
            {
            }

            // Greater than operator
            if (x > y)
            {
            }

            // Less than operator
            if (x < y)
            {
            }

            // Greater or equal to operator
            if (x >= y)
            {
            }

            // Less than or equal to operator
            if (x <= y)
            {
            }

            // Conditional AND operator … 
            if ((x > y) && (a > b)) 
            { 
            }

            // Conditional OR operator …
            if ((x > y) || (a > b))
            {
            }

            // Conditional
            string message = (x == 1) ? "Car" : "Boat";

            // Member access and Method invocation
            Console.WriteLine("Hi");
            Console.ReadLine();
        }
    }
}
```

### Ouput

![HelloWorld](media/operators.PNG)

## 4-understanding-scope Example

### Program.cs
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingScope
{
    class Program
    {
        //private static string k = "";

        static void Main(string[] args)
        {

            /*
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }

                //Console.WriteLine(l);

            }

            //Console.WriteLine(i);

            Console.WriteLine("Outside of the for: " + j);
            //Console.WriteLine("k: " + k);

            helperMethod();

             */

            Car car = new Car();
            car.DoSomething();

            Console.ReadLine();

        }

        /*
        static void helperMethod()
        {
            Console.WriteLine("k from helperMethod: " + k);
        }
         */ 

    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello world!";
        }
    }

}

```
### Ouput

![HelloWorld](media/understandingscope.PNG)
