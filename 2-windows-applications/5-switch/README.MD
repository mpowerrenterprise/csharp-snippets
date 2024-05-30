# 5-switch Snippets Code

## swSta Example

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

namespace swSta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string userInput = textBox1.Text;

            switch (userInput)
            {

                case "guna":
                    MessageBox.Show("guna is logged in");
                    break;

                case "joker":
                    MessageBox.Show("Joker is logged in");
                    break;

                case "hacker":
                    MessageBox.Show("hacker is logged in");
                    break;

                    case "maker":
                    MessageBox.Show("maker is logged in");
                    break;

                default:
                    MessageBox.Show("No User is there");
                    break;
                    
            }



        }
    }
}

       
```

### Ouput

![swSta](media/1x.png)
![swSta](media/2x.png)





      





