using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace deleteXMlNode
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
            xDoc.Load("C:\\Users\\Joker Hacker\\Desktop\\ExampleXML.xml");

            foreach (XmlNode xNode in xDoc.SelectNodes("people/person")) {


                if (xNode.SelectSingleNode("name").InnerText == textBox1.Text) {

                    xNode.RemoveAll();//This will remove all nodes thats besides it. This wont remove with the parent.
                }

                xDoc.Save("C:\\Users\\Joker Hacker\\Desktop\\ExampleXML.xml");

            }
            
        }
    }
}
