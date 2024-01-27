using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsOverloadingName
{
    enum Names {

       Guna,
       Rakulan,
       Joker,
       maker,
       doer,
       hacker
    }

    class methodOverloadingClass
    {

        public void printMe(Names name1) {

            System.Windows.Forms.MessageBox.Show(name1.ToString());

        }
        
    }
    
}

//enum is let to give a list of things for selection.




