using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyCon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Person p = new Person();//This is the instance that has created from the Person class. 

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = "Guna";
            p.age = 21;
            p.email = "gunarakulan@gmail.com";
            propertyGrid1.SelectedObject = p;
            Reload();//call the reload method.

            
        }

        void Reload() {

            textBox1.Text = p.Name;
            textBox2.Text = p.age.ToString();
            textBox3.Text = p.email;
        }

        class Person {

            public string Name{
                get;
                set;

            }

            public int age {

                get;
                set;

            }

            public string email {

                get;
                set;

            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {

            Reload();
        }
    }
}
