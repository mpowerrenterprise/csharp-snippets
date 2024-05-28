# 3-properties Snippets Code

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

![4-textbox-chanege](media/1.png)

![4-textbox-chanege](media/2.png)









      





