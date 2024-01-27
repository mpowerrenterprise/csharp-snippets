using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;//must be

namespace MD5Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            MessageBox.Show(BitConverter.ToString(sha1.ComputeHash(utf8.GetBytes(textBox1.Text))));


        }
    }
}

//SHA1 is 20 Bytes long.
//MD5 is 16 bytes long.