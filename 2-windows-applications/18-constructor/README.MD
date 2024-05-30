# 18-constructor Snippets Code

## 1-overloading-constructor Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCustomName;

namespace Constu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1("kuna");
            c1.printname();

        }
    }
}

```

### Ouput

![1-overloading-constructor](media/1.png)
![1-overloading-constructor](media/2.png)

## 2-default-constructor Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCustomName;

namespace Constu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 c1 = new Class1();
            int total = c1.a +c1.b;
            MessageBox.Show(total.ToString());

        }
    }
}


```
### Ouput

![2-default-constructor](media/3.png)
![2-default-constructor](media/4.png)

## 3-overloing Example

### Program.cs

```c#
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace methodsOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }
    }
}


```

### Ouput

![3-overloing](media/5.png)





