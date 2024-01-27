using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhername
{
    class BC
    {

        public virtual void Display() {

            System.Windows.Forms.MessageBox.Show("BC:Display");


        }
        
    }

    class DC : BC {

        public override void Display()
        {
            System.Windows.Forms.MessageBox.Show("DC:Display");

        }

    }

    class TC : DC {

        public override void Display()
        {
            System.Windows.Forms.MessageBox.Show("TC:Display");
        }
    }
}
