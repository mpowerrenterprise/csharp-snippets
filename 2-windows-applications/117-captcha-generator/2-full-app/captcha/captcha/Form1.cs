using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.IO;
namespace captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> strings = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        Image[] GenarateCap(int amount)
        {
            Image[] imgs = new Image[amount];
            Random ran = new Random();
            for (int z = 0; z < amount; z++)
            {
                Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height);
                Graphics g = Graphics.FromImage(bitmap);
                g.Clear(panel1.BackColor);
                
                SolidBrush sol = new SolidBrush(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));
                Pen p = new Pen(Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255)));

                char[] chars = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890".ToCharArray();

                string randomString = "";

                for (int a = 0; a < 6; a++)
                {

                    randomString += chars[ran.Next(0, 36)];

                }

                byte[] buffer = new byte[randomString.Length];
                int y = 0;

                foreach (char c in randomString.ToCharArray())
                {

                    buffer[y] = (byte)c;
                    y++;
                }

                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                string md5string = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");
                strings.Add(md5string);
                FontFamily ff = new FontFamily("Arial");
                Font f = new System.Drawing.Font(ff, 14);
                g.DrawString(randomString, f, sol, 20, 50);

                for (int i = 0; i < 6; i++)
                {


                    int j = ran.Next(0, 2);

                    if (j == 0)
                    {

                        g.DrawRectangle(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 111), ran.Next(0, 60));

                    }
                    else if (j == 1)
                    {

                        g.DrawEllipse(p, ran.Next(0, 111), ran.Next(0, 60), ran.Next(0, 111), ran.Next(0, 60));

                    }

                    p.Color = Color.FromArgb(0xFF, ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                }

                panel1.BackgroundImage = bitmap;
                imgs[z] = bitmap;

            }
            return imgs;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Image[] images = GenarateCap(Convert.ToInt32(textBox1.Text));
            int g = 0;

            foreach (Image im in images) {

                im.Save(label1.Text + "\\" + strings[g] + ".PNG");
                g++;
            }
            MessageBox.Show("Completed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();

            if (fdb.ShowDialog()==DialogResult.OK) {

                label1.Text = fdb.SelectedPath;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string md5Hashname = "";
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) {

                pictureBox1.ImageLocation = ofd.FileName;
                md5Hashname = Path.GetFileNameWithoutExtension(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            int y = 0;

            byte[] buffer = new byte[textBox2.Text.Length];

            foreach (char c in textBox2.Text.ToCharArray())
            {

                buffer[y] = (byte)c;
                y++;
            }

            string bla = BitConverter.ToString(md5.ComputeHash(buffer)).Replace("-", "");

            if (bla != md5Hashname)
            {
                MessageBox.Show("You are wrong");
            }
            else {

                MessageBox.Show("You are right");
            }
        }
    }
}
