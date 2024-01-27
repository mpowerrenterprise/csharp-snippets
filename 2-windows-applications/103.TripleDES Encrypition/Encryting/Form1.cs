using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //Must be

namespace Encryting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider(); //We are using MD5 16 bytes long hash codes.

            UTF8Encoding utf8 = new UTF8Encoding();

            TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider(); //This is the encrypter class.

            tDES.Key = md5.ComputeHash(utf8.GetBytes(textBox1.Text)); // We give key
            tDES.Mode = CipherMode.ECB;// must be or cannot be decrypted
            tDES.Padding = PaddingMode.PKCS7;// must be or cannot be decrypted
            ICryptoTransform trans = tDES.CreateEncryptor();

            textBox3.Text = BitConverter.ToString(trans.TransformFinalBlock(utf8.GetBytes(textBox2.Text), 0, utf8.GetBytes(textBox2.Text).Length));
            //0 is the starting point we are starting from the start so 0.
            //utf8.GetBytes(textBox2.Text).Length is the ending point.



        }
    }
}
