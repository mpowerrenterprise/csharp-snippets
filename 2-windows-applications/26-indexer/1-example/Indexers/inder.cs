using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexersname
{
    class inder
    {
        
        public string this[int index] {


            get
            {
                return myArray[index];
            }

            set {

                myArray[index] = value;

            }

        }

        string[] myArray = { "Guna", "joker", "hacker" };
    }
}
