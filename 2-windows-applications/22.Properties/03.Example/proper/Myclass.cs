using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properName
{
    class Myclass
    {

        string myString;

        public Myclass(string name)
        {
            myString=name;
            
        }
        
      
        public string Name {

            get { return myString;}

            set {

                if (value == "")
                {

                    System.Windows.Forms.MessageBox.Show("You cannot do that");
                }
                else {

                    myString = value;
                }

            }
          
        }

    }
}
