using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebContentGet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        WebBrowser wb = new WebBrowser();

        private void button1_Click(object sender, EventArgs e)
        {

            wb.Navigate("http://localhost/web/index.html");//URL
            wb.DocumentCompleted += Wb_DocumentCompleted;

        }

        private void Wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            label1.Text = wb.Document.GetElementById("item").InnerText;
            //item is the id of the website

        }
    }
}
