# interface Snippets Code

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

        interface IItem
        {

            string name { get; set; }
            int goldValue { get; set; }
            
            void equipt();
            void sell();          

        }

        class Sword : IItem
        {

            public string name { get; set; }
            public int goldValue { get; set; }
           


            public Sword(string _name)
            {

                name = _name;
                goldValue = 100;

            }

            public void equipt()
            {
            
                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }


        }

        


        static void Main(string[] args)
        {

            Sword s1 = new Sword("Sword of disnity");
            s1.equipt();
            s1.sell();

            
            Console.ReadKey();
        }

    }
}

//Interface is a contract with the classes that the classes must fllow.
//If we inherite an interface with the class ,that classes can have methods or properties that are not in the interface.
//But the classes have must have properties and methods thats are in the interface.
//We normally create a comman interface for all classes.That all classes must have properties and methods thats are interface.
//And even a class can have properties or methods thats are not in the interface. 

```

### Ouput

![1-example](media/1.png)



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

        interface IItem
        {

            string name { get; set; }
            int goldValue { get; set; }
            
            void equipt();
            void sell();          

        }

        interface IDamageable{//This is an another interface.

            int durablity { get; set; }

            void takeDamage(int _amount);//this method takes a parameter value.
            

        }

        class Sword : IItem,IDamageable //I have inherited this class with IItem interface and the IDanageable interface.
        {                               //So This class made a contarct width these two interfaces.
                                        //This class must fllow the Contract.
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }
           


            public Sword(string _name)
            {

                name = _name;
                goldValue = 100;
                durablity = 30;

            }

            public void equipt()
            {
            
                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam) {//The parameter name may be diffrent.not be _amount we can change it. 

                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }


        }

        


        static void Main(string[] args)
        {

            Sword s1 = new Sword("Sword of disnity");
            s1.equipt();
            s1.sell();
            s1.takeDamage(20);

            
            Console.ReadKey();
        }

    }
}


```

### Ouput

![2-example](media/2.png)


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

        interface IItem
        {

            string name { get; set; }
            int goldValue { get; set; }
            
            void equipt();
            void sell();          

        }

        interface IDamageable{

            int durablity { get; set; }

            void takeDamage(int _amount);
            

        }

        class Sword : IItem,IDamageable
        {                              
                                                                                      
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }
           
          


            public Sword(string _name)
            {

                name = _name;
                goldValue = 100;
                durablity = 30;

            }

            public void equipt()
            {
            
                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam)
            {
                
                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }


        }

        class Axe : IItem, IDamageable//This is new class it inherited with two interfaces
        {

            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }




            public Axe(string _name)
            {

                name = _name;
                goldValue = 70;
                durablity = 50;

            }

            public void equipt()
            {

                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam)
            {

                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }


        }








        static void Main(string[] args)
        {

            Sword s1 = new Sword("Sword of disnity");
            s1.equipt();
            s1.sell();
            s1.takeDamage(20);

            Console.WriteLine();

            Axe a1 = new Axe("Ford Axe");
            a1.equipt();
            a1.sell();
            a1.takeDamage(20);
            
            Console.ReadKey();
        }

    }
}


```
### Output

![3-example](media/3.png)

## 4 - Example

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

        interface IItem
        {

            string name { get; set; }
            int goldValue { get; set; }
            
            void equipt();
            void sell();          

        }

        interface IDamageable{

            int durablity { get; set; }

            void takeDamage(int _amount);
            

        }

        interface IPartOfTheQuest
        {

            void turnIn();


        }

        class Sword : IItem,IDamageable,IPartOfTheQuest
        {                              
                                                                                      
            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }
           
          


            public Sword(string _name)
            {

                name = _name;
                goldValue = 100;
                durablity = 30;

            }

            public void equipt()
            {
            
                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam)
            {
                
                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }

            public void turnIn() {

                Console.WriteLine(name + " Turned in");
            }


        }

        class Axe : IItem, IDamageable
        {

            public string name { get; set; }
            public int goldValue { get; set; }
            public int durablity { get; set; }




            public Axe(string _name)
            {

                name = _name;
                goldValue = 70;
                durablity = 50;

            }

            public void equipt()
            {

                Console.WriteLine(name + " was Equipt");
            }


            public void sell()
            {

                Console.WriteLine(name + " Sold for " + goldValue + " imageary dollers");
            }

            public void takeDamage(int _dam)
            {

                durablity -= _dam;

                Console.WriteLine(name + " Danaged by" + _dam + " It now has durablity of " + durablity);
            }


        }








        static void Main(string[] args)
        {

            Sword s1 = new Sword("Sword of disnity");
            s1.equipt();
            s1.sell();
            s1.takeDamage(20);
            s1.turnIn();

            Console.WriteLine();

            Axe a1 = new Axe("Ford Axe");
            a1.equipt();
            a1.sell();
            a1.takeDamage(20);

            IItem[] Inventory = new IItem[2];
            Inventory[0] = s1;
            Inventory[1] = a1;

            Console.WriteLine();

            for (int i = 0; i < Inventory.Length; i++)
            {

                IPartOfTheQuest questItem = Inventory[i] as IPartOfTheQuest;

                if (questItem != null)
                {

                    questItem.turnIn();
                }
            }

            Console.ReadKey();
        }

    }
}



```
### Output
![4-example](media/4.png)