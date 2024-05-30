# 3-properties Snippets Code

## 1-button-text-change Example

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

namespace properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            button1.Text = "Text has changed";

        }
    }
}


```

### Ouput

![1-button-text-change](media/1x.png)

![1-button-text-change](media/2x.png)

## 2-button-disable Example

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

namespace properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //set to true means visible.
            button1.Enabled = false;

        }
    }
}


```

### Ouput

![2-button-disable](media/3x.png)


## 3-change-the-height-and-width Example

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

namespace properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //we can also change other properties.
            button1.Height = 100;
            button1.Width = 100;
            
        }
    }
}


```
### Ouput

![3-change-the-height-and-width](media/4x.png)

![3-change-the-height-and-width](media/5x.png)

## 4-textbox-chanege Example

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

namespace properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World";
          
            
        }
    }
}

```
### Ouput

![4-textbox-chanege](media/6x.png)
![4-textbox-chanege](media/7x.png)

## 5-maxlength Example

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

namespace properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 5;
            textBox1.Text = "Hello World";
          
            
        }
    }
}


```
### Ouput

![5-maxlength](media/8x.png)
![5-maxlength](media/9x.png)



