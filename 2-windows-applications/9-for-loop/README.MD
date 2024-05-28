# 9-for-loop Snippets Code

## 1-for-loop-with-array Example

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

namespace list
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

![1-for-loop-with-array](media/1.png)
![1-for-loop-with-array](media/2.png)

## 2- 1-for-loop-with-list Example

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

namespace forLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> names = new List<string>();
            names.Add("guna");
            names.Add("joker");
            names.Add("maker");
            names.Add("doer");
            names.Add("rakulan");

            //Count for the List
            for (int a = 0; a < names.Count; a++) {


                MessageBox.Show(names[a]);
            }

        }
    }
}


```

### Ouput

![2-for-loop-with-list](media/3.png)
![2-for-loop-with-list](media/4.png)






