# 15-break Snippets Code

## ConBrack Example

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

namespace ConBrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            for (int u = 0; u <= 10; u++) {

                if (u == 5) {

                    break;

                }

                richTextBox1.Text += u.ToString();
                //+= appeding

            }

        }
    }
}

//the break statement will stop the program 


```

### Ouput

![ConBrack](media/1.png)
![ConBrack](media/2.png)










