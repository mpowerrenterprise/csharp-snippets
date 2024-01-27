using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Process p in Process.GetProcesses()) {

                MessageBox.Show(p.ProcessName.ToString());

                if (p.ProcessName == "vlc") {

                    p.Kill();
                }

            }

            //if vlc in process kill it.
          
        }
    }
}


