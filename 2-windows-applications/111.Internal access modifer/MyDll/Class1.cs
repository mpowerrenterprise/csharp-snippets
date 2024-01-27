using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDll
{
    namespace Clients {


        internal class Client {//Internal class can be accessed by the internal class.Not outside 

            
            public string Name//we can also apply the internal to members and variables.
            {
                get;
                set;
            }

            public int Age {


                get;
                set;

            }
        }


    }

    class myClass
    {


        Clients.Client c = new Clients.Client();
        

    }

}
