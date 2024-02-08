using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listViewSystem
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

        private void button1_Click(object sender, EventArgs e)
        {

            ListViewItem lv1 = new ListViewItem(textBox1.Text);//we must give the first item in the constructor.
            lv1.SubItems.Add(textBox2.Text);
            lv1.SubItems.Add(textBox3.Text);

            listView1.Items.Add(lv1);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";



        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void getTheItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0) {//if the listView has data in it.

                MessageBox.Show(listView1.SelectedItems[0].SubItems[0].Text);
                //we select the first selectedItems then we select first SubItems.

            
            }
        }
    }
}
