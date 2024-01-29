using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessName
{
    
    class accessClass
    {

        //cannot be accessed with the instance.
        //This private can be accessed within this class.
        private string name = "guna";
    

        //but the public can be used by any instance.
        public string nameBack() {

            //I have used the private variable.
            return name;

        }


        
    }



}
