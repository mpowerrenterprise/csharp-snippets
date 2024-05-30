# 21-enum Snippets Code

## methodsOverloading Example

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
using methodsOverloadingName;

namespace methodsOverloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            methodOverloadingClass mc = new methodOverloadingClass();
            mc.printMe(Names.Guna);


        }
    }
}


```

### Ouput

![methodsOverloading](media/1x.png)
![methodsOverloading](media/2x.png)










