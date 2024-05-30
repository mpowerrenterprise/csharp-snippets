# 10-foreach Snippets Code

## 1-foreach-loop-with-lilst Example

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


            foreach (string item in names)
            {

                MessageBox.Show(item);

            }

        }
    }
}


```

### Ouput

![1-foreach-loop-with-lilst](media/1.png)
![1-foreach-loop-with-lilst](media/2.png)

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

            int[] nums = new int[5];
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;



            foreach (int item in nums)
            {

                MessageBox.Show(item.ToString());

            }

        }
    }
}


```

### Ouput

![2-foreach-loop-with-array](media/3.png)
![2-foreach-loop-with-array](media/4.png)






