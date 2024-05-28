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

![1-button-text-change](media/1.png)

![1-button-text-change](media/2.png)







      





