using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properName
{
    class Myclass
    {


        public Myclass(string name)
        {
            Name = name;
            //I have assigned the parameter values to the Name variable.
            
        }
        
        //This is the getter and setter.
        public string Name {

           get;
           private set;//This could be sat by this class only.not by the instance.
        }

    }
}
