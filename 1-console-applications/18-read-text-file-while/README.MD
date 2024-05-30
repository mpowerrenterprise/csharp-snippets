# 18-read-text-file- Snippets Code

## 2- read-text-file Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadTextFileWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Values.txt");
            string line = "";

            while (line != null)
            {
                line = myReader.ReadLine();
                if (line != null)
                    Console.WriteLine(line);
            }

            myReader.Close();
            Console.ReadLine();

        }
    }
}

   
```

### Ouput

![read-text-file](media/1x.png)






      





