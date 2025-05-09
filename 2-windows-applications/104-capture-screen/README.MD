# 104-capture-screen Snippets Code

## 1-image example

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
using System.Threading;
namespace captureScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bit = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Graphics g = Graphics.FromImage(bit);
            g.CopyFromScreen(Point.Empty,Point.Empty ,Screen.PrimaryScreen.WorkingArea.Size);
            //PrimaryScreen is the screen without the taskbar
            //Point.empty means the starting and the ending points
            pictureBox1.Image = bit;
        }
    }
}



```

### Ouput

![1-image](media/1.png)
![1-image](media/2.png)

## 2-video example

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
using System.Threading;//Theradig is important to make the program not to stack.

namespace captureScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Thread t = new Thread(run);
            t.Start();
        }

        void run() {

            //This is infinite for loop.
            for (;;)
            {

                Bitmap bit = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                Graphics g = Graphics.FromImage(bit);
                g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.WorkingArea.Size);
                //PrimaryScreen is the screen without the taskbar
                //Point.empty means the starting and the ending points
                pictureBox1.Image = bit;

            }
        }
    }
}


```

### Ouput

![2-video](media/3.png)
![2-video](media/4.png)