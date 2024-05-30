# 4-if-else-if Snippets Code

## 1- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "guna")
            {

                MessageBox.Show("The guna is logged in");
            }
            else if (textBox1.Text == "joker")
            {

                MessageBox.Show("The Joker is logged in");
            }
            else if (textBox1.Text == "hacker")
            {

                MessageBox.Show("The hacker is logged on");
            }
            else if (textBox1.Text == "maker") {

                MessageBox.Show("The maker is logged in");
            }
            else{

                MessageBox.Show("The username that you entered is not avaliable in the database table");
            }
        }
    }
}

```

### Ouput

![1-example](media/1x.png)

![1-example](media/2x.png)

## 2- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                MessageBox.Show("The MSG BOX has been checked");
            }
            else {

                MessageBox.Show("Please check the MSG box");
            }
        }
    }
}


```

### Ouput

![2-example](media/3x.png)

## 3- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool b = true;
            
            //means true.
            if (b) {
                MessageBox.Show("This is true");
            }
            
        }
    }
}

```

### Ouput

![3-example](media/4x.png)

## 4- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool b = false;
            
            //means fasle.
            if (!b) {
                MessageBox.Show("This is false");
            }
            
        }
    }
}


```
### Ouput

![4-example](media/5x.png)
![4-example](media/6x.png)

## 5- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool b = false;

            //it is flase.
            //!b means not false means true.
            if (!b == false)
            {
                MessageBox.Show("This is true");
            }
            else {
                MessageBox.Show("This is fasle");

            }
            
        }
    }
}


```
### Ouput

![5-example](media/7x.png)
![5-example](media/8x.png)

## 6- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool b = false;

            //it is true.
            //!b means not false means true.
            //true not == false
            if (!b != false)
            {
                MessageBox.Show("This is true");
            }
            else {
                MessageBox.Show("This is fasle");

            }
            
        }
    }
}


```

### Ouput

![6-example](media/9x.png)
![6-example](media/10x.png)

## 7- Example

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            bool b = true;

            //it is true.
            //!b means not false means true.
            //false not == false
            if (!b != false)
            {
                MessageBox.Show("This is true");
            }
            else {
                MessageBox.Show("This is fasle");

            }
            
        }
    }
}


```
### Output
![7-example](media/10x.png)
![7-example](media/11x.png)

## 8- and-if-concept

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "guna")
            {

                if (checkBox1.Checked)
                {

                    MessageBox.Show("Ok fine");
                }
                else
                {

                    MessageBox.Show("please check the box");
                }

            }
            else {

                MessageBox.Show("Enter the correct name");
            }
          
            
        }
    }
}


```
### Output
![8-and-if-concept](media/13x.png)
![8-and-if-concept](media/12x.png)

## 9- and-if

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "guna" && checkBox1.Checked!=false) {


                MessageBox.Show("Oh Fine");

            }
            else
            {


                MessageBox.Show("Someting wrong");

            }
          
            
        }
    }
}

```
### Output
![and-if](media/15x.png)
![and-if](media/14x.png)

## 10- or-if

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

namespace ifStae
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "guna" || checkBox1.Checked!=false) {


                MessageBox.Show("Oh Fine");

            }
            else
            {


                MessageBox.Show("Someting wrong");

            }
          
            
        }
    }
}


```
### Output
![or-if](media/17x.png)
![or-if](media/18x.png)







      





