# 1-hello-world Snippets Code

## 1-message-box Example

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

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show("I have to learn C#","This is the title");

            //In the MSG box the first parameter is the value that has display.
            //second parameter is the title for the MSG box.

        }
    }
}


```

### Ouput

![1-message-box](media/1.png)






      





