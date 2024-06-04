# 78-opening-files Snippets Code

## SoruceFiles example

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

namespace openingFiles
{
    public partial class Form1 : Form
    {
        public Form1(string s)
        {
            InitializeComponent();
            MessageBox.Show(s);//we print out the data.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


```

### Ouput

![SoruceFiles](media/1.png)








