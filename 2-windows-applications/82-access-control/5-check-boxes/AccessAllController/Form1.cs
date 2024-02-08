using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessAllController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AccessAll(this.Controls);
        }


        void AccessAll(Control.ControlCollection cc) {

            foreach (Control c in cc) {

                if (c is CheckBox) {//if c is check box.

                    CheckBox ch = c as CheckBox;//store all checkboxes in the ch variable.
                    ch.Checked = true;//than we checked all of them.

                }

                if (c.HasChildren) {

                    AccessAll(c.Controls);
                }
            }
        }
    }
}


