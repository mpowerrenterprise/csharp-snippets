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
        static void Main(string[] args)
        {

            for (int a = 1000; a >= 0; a++) {

                Console.WriteLine(a);

            }
            Console.ReadKey();

        }
    }
}
//This loop will not stop.
//The condition is 'a' is greater than or equal to 0.
//as long as the condition is true the loop will run.
//so in this case loop will run infinitly.




```
### Ouput

![1-for-loop](media/3.png)

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
        static void Main(string[] args)
        {


            for (int i = 1; i <= 100; i+=2) {

                Console.WriteLine(i);
            }

            Console.ReadKey();


        }
    }
}

//in this loop the increment is 2 so it will increase the value by two each time this loop works.
//This loop will print out the odd numbers.

```
### Ouput

![1-for-loop](media/4.png)

## 5- Example

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


            for (int i = 2; i <= 100; i+=2) {

                Console.WriteLine(i);
            }

            Console.ReadKey();


        }
    }
}

//in this loop the increment is 2 so it will increase the value by two each time this loop works.
//This loop will print out the even numbers.



```
### Ouput

![1-for-loop](media/5.png)

## 6- Example

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


            for (int i = 2; i <= 100; i++) {

                if (i % 2 == 0) {

                    Console.WriteLine(i);
                }
              
            }

            Console.ReadKey();
        }
    }
}

//every time this loop runs it checks the i value divided by 2 ==0.
//if it is it will print.
//so this loop will print even numbers.


```
### Ouput

![1-for-loop](media/6.png)

## 7- Example

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


            for (int i = 2; i <= 100; i++) {

                if (i % 2 == 0==false) {

                    Console.WriteLine(i);
                }
              
            }

            Console.ReadKey();
        }
    }
}

//every time this loop runs it checks the i value divided by 2 ==0 == false.
//if it is it will print.
//so this loop will print odd numbers.

```
### Ouput

![1-for-loop](media/7.png)

## 8- Example

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

            int total = 0;

            for (int u = 0; u < 100; u++) {

                total = total + u;
              
            }
            Console.WriteLine(total);
            Console.ReadKey();

        }
    }
}
//This program will add all itreation numbers together from 0 to 100.
//first time total = 0 u is 1 so 0+1=1
//secont time total= 1 u is 2 so 1+2=3;
//third time total =3 u is 3 so 3+3=6;
//and so on.  

```
### Ouput

![1-for-loop](media/8.png)

## 9- Example

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

            createGrid();
            Console.ReadKey();
        }

        public static void createGrid()
        {


            for (int a = 1; a <= 1; a++) {

                Console.Write(a+" ");

            }

            Console.WriteLine();

            for (int b = 1; b <= 2; b++) {

                Console.Write(b+" ");
            }

            Console.WriteLine();

            for (int c = 1; c <= 3; c++) {

                Console.Write(c + " ");
            }

            Console.WriteLine();

            for (int d = 1; d <= 4; d++) {

                Console.Write(d + " ");
            }

            Console.WriteLine();

            for (int e = 1; e <= 5; e++)
            {

                Console.Write(e + " ");
            }
            Console.WriteLine();

            for (int f = 1; f <= 6; f++) {

                Console.Write(f + " ");
            }

            Console.ReadKey();


        }


    }
}



```

### Ouput

![1-for-loop](media/9.png)

## 10- Example

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

            for (int a = 1; a <= 6; a++) {

                for (int b = 1; b <= a; b++) {      // 1         first time
                                                    // 1 2       secound time
                                                    // 1 2 3     so on
                    Console.Write(b+" ");           // 1 2 3 4
                }                                   // 1 2 3 4 5
                Console.WriteLine();                // 1 2 3 4 5 6
            }
               

          Console.ReadKey();
        }
    }
}



```
### Ouput

![1-for-loop](media/10.png)

## 11- Example

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

            for (int a = 1; a <= 6; a++) {

                for (int b = a; b >= 1; b--) {


                    Console.Write(b+" ");
                }
                Console.WriteLine();
            }
               

          Console.ReadKey();
        }
    }
}


```
### Ouput

![1-for-loop](media/11.png)

## 12- Example

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

            for (int a = 6; a >= 1; a--) {

                for (int b = 1; b <= a; b++) {


                    Console.Write(b+" ");
                }

                Console.WriteLine();
            }
               

          Console.ReadKey();
        }
    }
}

```
### Ouput

![1-for-loop](media/12.png)

## 13- Example

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

            for (int loop1 = 1; loop1 <= 5; loop1 = loop1 + 1) {

                for (int loop2 = 1; loop2 <= 5; loop2++) {


                    Console.Write("*"+"\t");

                }
                Console.WriteLine();


            }

          Console.ReadKey();
        }
    }
}


```
### Ouput

![1-for-loop](media/13.png)