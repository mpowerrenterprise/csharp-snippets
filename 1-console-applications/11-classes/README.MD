# classes Snippets Code

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
    class Hacker {
		
       public string name = "Joker";
       public int age = 21;

    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            Console.WriteLine(kuna.name);
            Console.ReadKey();       
        } 

    }
}

//Hacker is a simple class.
//Class is a blueprint for our program.
//We could have many calasses in one single program.
//We normally create a class (blueprint) and use as an object in our program
//look at line 22.I have created an instence bashed on the hacker class. 
//public can access outside the class.
//private can access only inside the class.These are look like scoping in javascript and php.
//Inside the Hacker class we have two values string value and a integer vaule.
//we can also create classes in javascript by using contructor pattren or factory pattren.


```

### Ouput

![1-example](media/exp1.png)

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
    class Hacker {

       public string name = "Joker";
       public int age = 21;

       public void printOut() {

            Console.WriteLine("My name is " + name + " and my age is " + age);

        }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            kuna.printOut();

            Console.ReadKey();

        
        } 

    }
}

//We are able to have methods in classess.I have a method on line number of 14.
//void means executes the code inside it.
//if you want to return the value back.We must use the variable type instead of void.
//return means send back the result.

```

### Ouput

![2-example](media/exp2.png)

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
    class Hacker {

       public string name = "Joker";
       public int age = 21;

       public string printOut() {

            return "My name is " + name + " and my age is " + age;

        }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker();
            Console.Write(kuna.printOut());

            Console.ReadKey();

        
        } 

    }
}
//look at line 16 i return the value back.
//so used string instead of void.
//void will execute the code.
//We must put public to the infront of the variable.Otherwise we can't access the value outside any classes.


```
### Ouput

![3-example](media/exp3.png)

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



```
### Ouput

![4-example](media/exp4.png)

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
    class Animal {

       public string name;
       public int age;


        public void printSys() {

            Console.WriteLine("The name is " + name + " and the age i " + age);
            Console.ReadKey();

        }

    }
    class Program
    {
        public static void Main(string[] args)
        {

            Animal dog1 = new Animal();
            dog1.name = "gmni";
            dog1.age = 2;
            dog1.printSys();
        
        } 

    }
}

//we can set class values like this.
//You can notice in the class we did not set any values.
//we have created an instance of Animal called dog1.
//we sat values in the main method.


```
### Ouput

![5-example](media/exp5.png)

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
    class Hacker
    {
        public static int count=0;
        public string name;
        public int age;

        public Hacker(){//Constroctor pattren.//default values.if no value assgin this will run.
		
            name = "no name";
            age = 0;
            count++;

        }

        public Hacker(string _name,int _age) {//if value assign this will run.


            name = _name;
            age = _age;
            count++;

        }

        public void print() {//printing method.

            Console.WriteLine("My name is " + name + " and my age is " + age);

        }



    }

    class Program
    {
        public static void Main(string[] args)
        {

            Hacker kuna = new Hacker("kuna",25);
            kuna.print();
            
            Console.ReadKey();
        
        } 

    }
}

//count can be only accessed with Hacker because that static.


```
### Ouput

![6-example](media/exp6.png)

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
    class Employees {

        public string name;
        public int age;
        public string job;

        public Employees(string _name, int _age, string _job) {

            name = _name;
            age = _age;
            job = _job;

        }



        public void print() {

            Console.Write("My name is " + name + " and my age is " + age + " I work as a " + job);
            Console.ReadKey();
        }


    }

    class Program
    {
        public static void Main(string[] args)
        {

            Employees kuna = new Employees("kuna",21,"SE");
            kuna.print();
         


        
        } 

    }
}



```
### Output
![7-example](media/exp7.png)

## 8- Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            myNewCar.Make = "Oldsmobile";
            myNewCar.Model = "Cutlas Supreme";
            myNewCar.Year = 1986;
            myNewCar.Color = "Silver";

            //Console.WriteLine("{0} - {1} - {2}", myNewCar.Make, myNewCar.Model, myNewCar.Color);

            //determineMarketValue(myNewCar);

            double myValue = myNewCar.DetermineMarketValue();

            Console.ReadLine();

        }

        /*
        private static double determineMarketValue(Car car)
        {

            return 100.0;
        }
         */

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public double DetermineMarketValue()
        {
            return 0.0;
        }

    }

}


```
### Output
![8-example](media/exp8.png)

