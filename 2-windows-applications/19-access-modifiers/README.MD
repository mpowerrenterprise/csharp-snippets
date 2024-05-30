# 19-access-modifiers Snippets Code

## 1- Example

### Program.cs

```c#



```

### Ouput

![1- Example](media/1.PNG)
![1- Example](media/2.PNG)

## 2- Example

### Program.cs

```c#

```
### Ouput

![2-example](media/3.PNG)
![2-example](media/4.PNG)

## 3-Example

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
using accessName;

namespace access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            accessClass ac1 = new accessClass();
            string name = ac1.nameBack();
            MessageBox.Show(name);

        }
    }
}


```

### Ouput

![3-example](media/5.PNG)
![3-example](media/6.PNG)





