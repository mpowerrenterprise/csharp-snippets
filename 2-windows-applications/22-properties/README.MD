# 22-properties Snippets Code

## 1- Example

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
using properName;

namespace proper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Myclass mc = new Myclass("Guna");
            mc.Name = "Joker";//I can change the value because i have setter in the property.
            MessageBox.Show(mc.Name);//I got this value from a getter.


        }
    }
}

```

### Ouput

![1-example](media/1x.png)
![1-example](media/2x.png)

## 2- Example

### Program.cs

```c#


```

### Ouput

![2-example](media/3x.png)
![2-example](media/4x.png)

## 3- Example

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
using properName;

namespace proper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Myclass mc = new Myclass("Guna");
            mc.Name = "joker";
            MessageBox.Show(mc.Name);//I got this value from a getter.


        }
    }
}


```

### Ouput

![3-example](media/5x.png)
![3-example](media/6x.png)





