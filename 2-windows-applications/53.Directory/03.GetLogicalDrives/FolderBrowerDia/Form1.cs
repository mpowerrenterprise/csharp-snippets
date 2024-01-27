using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FolderBrowerDia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //The GetLogicalDrives() will get all logigal drives and store in the array.
            string[] logical = Directory.GetLogicalDrives().ToArray();

            for (int u = 0; u <logical.Length; u++)
            {

                MessageBox.Show(logical[u].ToString());

            }
            

        }
    }
}
