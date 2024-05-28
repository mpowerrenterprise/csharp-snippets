# 3-properties Snippets Code

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

![5-maxlength](media/1.png)

![5-maxlength](media/2.png)









      





