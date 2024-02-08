using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        Timer t;
   

        private void SplashScreen_Shown(object sender, EventArgs e)
        {

            t = new Timer();
            t.Interval = 2000;//2 Sec
            t.Start();

            t.Tick += T_Tick;
            
        }

   

        private void T_Tick(object sender, EventArgs e)
        {
            t.Stop();
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            

            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

            t = new Timer();
            t.Interval = 200;

            if (progressBar1.Value <= 90) {

                t.Start();
            }

            t.Tick += T_Tick1;

        }

        private void T_Tick1(object sender, EventArgs e)
        {
            progressBar1.PerformStep();

            if (progressBar1.Value == 100) {

                t.Stop();

            }
        }
    }
}
