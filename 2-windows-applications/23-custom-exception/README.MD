# 23-custom-exception Snippets Code

## errorStatic example

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
using errorStaticName;

namespace errorStatic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //This method is static that'y why cannot access it from the instance.
                MyClass.checkString("");
                

            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
    }
}

```

### Ouput

![errorStatic](media/1.png)
![errorStatic](media/2.png)







