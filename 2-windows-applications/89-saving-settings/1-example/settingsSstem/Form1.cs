using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace settingsSstem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Here we are displaying the settings.
            textBox1.Text = settingsSstem.Properties.Settings.Default.Name;
            textBox2.Text = settingsSstem.Properties.Settings.Default.Age.ToString();//we should convert into string because that is int type.
            textBox3.Text = settingsSstem.Properties.Settings.Default.Phone.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            settingsSstem.Properties.Settings.Default.Name = textBox1.Text;
            settingsSstem.Properties.Settings.Default.Age = Convert.ToInt32(textBox2.Text);
            settingsSstem.Properties.Settings.Default.Phone = Convert.ToInt32(textBox3.Text);

            settingsSstem.Properties.Settings.Default.Save();//we must save the settings.

            MessageBox.Show("Saved");
            

            //settingsSstem is the name of the application


        }
    }
}


//What is settings.
//Setting is when you work with your appliction you save changes. then you come back the settings is avaliable.