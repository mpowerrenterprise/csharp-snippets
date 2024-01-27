using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace openingFiles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] files)//if we open one or more files thats will pass thorugh this method.
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            foreach (string s in files)//we loop thorugh the passing programs.
            {
                Application.Run(new Form1(s));//we send them to the form1
            }

            
        }
    }
}
