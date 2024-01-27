using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace errorStaticName
{
    
    class MyClass
    {
        static Exception myExc = new Exception("You cannot set this string equal to any empty string");

        public static void checkString(string myStr) {

            if (myStr == "") {

                throw myExc;
            }
        }


    }
}
