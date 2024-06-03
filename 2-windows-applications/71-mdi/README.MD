# 71-mdi-Snippets Code

## 1- example

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

namespace mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();//we create an instance of the form2 
            f2.MdiParent = this;//then we assign the form2 to this mdiPresnt.
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();

            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();

        }
    }
}


//Multi Document Interface means form inside forms.

```

### Ouput

![1- example](media/1.png)
![1- example](media/2.png)
![1- example](media/3.png)
![1- example](media/4.png)

## 2-arrangeIcons example

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

namespace mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();//we create an instance of the form2 
            f2.MdiParent = this;//then we assign the form2 to this mdiPresnt.
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();

            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}


//ArrangeIcons will arrange the forms when the forms are minimized


```

### Ouput

![2-arrangeIcons](media/5.png)
![2-arrangeIcons](media/6.png)
![2-arrangeIcons](media/7.png)
![2-arrangeIcons](media/8.png)

## 3-cascade example

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

namespace mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();//we create an instance of the form2 
            f2.MdiParent = this;//then we assign the form2 to this mdiPresnt.
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();

            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}


//Cascade will make the forms a litte bit big and arranged properly.

```

### Ouput

![3-cascade](media/9.png)
![3-cascade](media/10.png)
![3-cascade](media/11.png)
![3-cascade](media/12.png)

## 4-tile-horizontal example
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

namespace mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();//we create an instance of the form2 
            f2.MdiParent = this;//then we assign the form2 to this mdiPresnt.
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();

            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}


//TileHorizontal will arrange the form Horizontally.

```

### Ouput

![4-tile-horizontal](media/13.png)
![4-tile-horizontal](media/14.png)
![4-tile-horizontal](media/15.png)
![4-tile-horizontal](media/16.png)

## 5-tile-vertical example
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

namespace mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();//we create an instance of the form2 
            f2.MdiParent = this;//then we assign the form2 to this mdiPresnt.
            f2.Show();

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();

            Form4 f4 = new Form4();
            f4.MdiParent = this;
            f4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}


//TileVertical will arrange the forms Vertically.

```

### Ouput

![5-tile-vertical](media/17.png)
![5-tile-verticall](media/18.png)
![5-tile-vertical](media/19.png)
![5-tile-vertical](media/20.png)