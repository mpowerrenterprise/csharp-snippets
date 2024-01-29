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

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "XML|*.xml";//allowed file types.

            if (ofd.ShowDialog() == DialogResult.OK) {

                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);//We can put URL 
                string Namevalue= xDoc.SelectSingleNode("people/person/name").InnerText;
                string AgeVlaue = xDoc.SelectSingleNode("people/person/age").InnerText;
                MessageBox.Show(Namevalue);
                MessageBox.Show(AgeVlaue);
            }


        }
    }
}
