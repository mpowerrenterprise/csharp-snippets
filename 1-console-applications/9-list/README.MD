# list Snippets Code

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

            List<string> names = new List<string>();

            names.Add("kuna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("hello");

            Console.WriteLine(names[1]);
            Console.ReadKey();
        

        }

    }
}

//This is list.
//It is equal to array.but array is faster than list.
//


```

### Ouput

![list](media/1exp.png)



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
        public static void Main(string[] args)
        {

            List<string> names = new List<string>();

            names.Add("kuna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("hello");

            foreach (string nam in names) {

                Console.WriteLine(nam);

            }

            Console.ReadKey();
        

        }

    }
}

//This is list.
//It is equal to array.but array is faster than list.W
//We looped through the list by using foreach() method.


```
### Ouput

![list](media/2exp.png)

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

            List<string> names = new List<string>();

            names.Add("kuna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("hello");


            for (int a = 0; a < names.Count; a = a + 1) {

                Console.WriteLine(names[a]);
                Console.ReadKey(); 
            } 

        }

    }
}

//This is list.
//It is equal to array.but array is faster than list.
//We looped through the list by using for loop
//but when we use list we must put Count instead of length.length for array.



```
### Ouput

![list](media/3exp.png)

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

            List<string> names = new List<string>();

            names.Add("kuna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("hello");

            names.RemoveAt(1);//this will remove joker;

            for (int u = 0; u <= names.Count; u += 1) {

                Console.WriteLine(names[u]);
               

            }
            Console.ReadKey();
        }

    }
}

//we can remove list properties by using RemoveAt method.



```
### Ouput

![list](media/4exp.png)

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
        public static void Main(string[] args)
        {

            List<string> names = new List<string>();

            names.Add("kuna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("hello");

            names.Remove("joker");//this will remove joker;

            foreach (string index in names) {

                Console.WriteLine(index);
                Console.ReadKey();
            }
        }

    }
}

//we can remove list properties by using Remove() method.But in the remove we need to put the 'text' instead of index number point. 



```
### Ouput

![list](media/5exp.png)

     