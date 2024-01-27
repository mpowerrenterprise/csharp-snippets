using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;//Must be 

namespace readingXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("http://localhost/web/ExampleXML.xml");
            string value= xDoc.SelectSingleNode("people/person/name").InnerText;
            MessageBox.Show(value) ;


        }
    }
}
