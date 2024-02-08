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

namespace WrtingXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlTextWriter xwriter = new XmlTextWriter("C:\\Users\\Joker Hacker\\Desktop\\guna.xml",Encoding.UTF8);

            xwriter.Formatting = Formatting.Indented;//if we do not put this line of code, It will be written in one line.

            xwriter.WriteStartElement("people");//<people>
            xwriter.WriteStartElement("person");//<person>
            xwriter.WriteStartElement("name");//<name>
            xwriter.WriteString(textBox1.Text);//textbox1.Text
            xwriter.WriteEndElement();//</name>
            xwriter.WriteEndElement();//</person>
            xwriter.WriteEndElement();//</people>

            xwriter.WriteStartElement("people");
            xwriter.WriteStartElement("person");
            xwriter.WriteStartElement("age");
            xwriter.WriteString(Convert.ToString(numericUpDown1.Value));
            xwriter.WriteEndElement();
            xwriter.WriteEndElement();
            xwriter.WriteEndElement();


            xwriter.WriteStartElement("people");
            xwriter.WriteStartElement("person");
            xwriter.WriteStartElement("age");
            xwriter.WriteString(textBox2.Text);
            xwriter.WriteEndElement();
            xwriter.WriteEndElement();
            xwriter.WriteEndElement();
            
            xwriter.Close();



        }
    }
}
