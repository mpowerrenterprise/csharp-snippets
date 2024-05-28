# 3-properties Snippets Code

## 1-button-disable Example

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

![1-button-text-change](media/1.png)








      





