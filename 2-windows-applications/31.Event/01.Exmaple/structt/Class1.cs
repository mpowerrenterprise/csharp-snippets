using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structtname
{

    class myClass {


        public event EventHandler ownPropertyChanged;

        string name = "";
        public string NamePro {

            get {

                return name;
            }
            set {

                name = value;
                ownPropertyChanged(this, new EventArgs());

            }

        }


    }
  

}


