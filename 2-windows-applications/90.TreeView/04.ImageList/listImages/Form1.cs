using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listImages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();
            tn.Text = "Person";
            tn.ImageIndex = 1;
            tn.SelectedImageIndex = 0;
            treeView1.Nodes.Add(tn);

        }
    }
}
