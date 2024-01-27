using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structtname
{
    public partial class Employee
    {
        public void DoWork()
        {
            System.Windows.Forms.MessageBox.Show("Hello 1");
        }
    }

    public partial class Employee
    {
        public void GoToLunch()
        {
            System.Windows.Forms.MessageBox.Show("Hello 2");
        }
    }

}
