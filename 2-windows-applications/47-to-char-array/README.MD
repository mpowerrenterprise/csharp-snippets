# 47-to-char-array Snippets Code

## Substrin example

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

namespace Substrin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string alp = "QWERTYUIOLPAFGHJKL";
            char[] charArr = alp.ToCharArray();

            foreach (char item in charArr)
            {

                MessageBox.Show(item.ToString());

            }


        }
    }
}


```

### Ouput

![Substrin](media/1.png)
![Substrin](media/2.png)








