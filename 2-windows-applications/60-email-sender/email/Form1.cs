using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                MailMessage MSG = new MailMessage();
                MSG.From = new MailAddress(textBox2.Text);
                MSG.Subject = textBox1.Text;
                MSG.Body = richTextBox2.Text;

                foreach (string s in richTextBox1.Text.Split(';'))
                {

                    MSG.To.Add(s);
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new NetworkCredential(textBox2.Text, textBox3.Text);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Send(MSG);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
               
            }
           

        }
    }
}
