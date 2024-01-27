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
            ofd.Filter = "XML|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                XmlDocument doc = new XmlDocument();

                doc.Load(ofd.FileName);

                foreach (XmlNode node in doc.SelectNodes("people/person"))
                {

                    MessageBox.Show(node.SelectSingleNode("name").InnerText);

                }

            }
            
        }
    }
}
