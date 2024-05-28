# 3-properties Snippets Code

## 3-change-the-height-an-width Example

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

![3-change-the-height-an-width](media/1.png)
![3-change-the-height-an-width](media/2.png)









      





