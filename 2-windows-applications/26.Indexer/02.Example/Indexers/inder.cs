using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexersname
{
    class inder
    {

        private string[] range = new string[5];

        public string this[int indexRange] {

            get {

                return range[indexRange];

            }

            set {

                range[indexRange] = value;
            }
        }
        
    }
}
