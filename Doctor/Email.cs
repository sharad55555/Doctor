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

namespace Doctor
{
    public partial class Email : MetroFramework.Forms.MetroForm
    {
       
        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {
            TextBoxFrom.Text = "sharad55555dhage@gmal.com";
            TextBoxSubject.Text = "Confirm Doctor Appointment";
            TextBoxBody.Text = "";
            TextBoxTo.Text = Form1.SetValueForText1;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBoxFrom_Click(object sender, EventArgs e)
        {
            TextBoxFrom.Text = "sharaddhage555555@gmail.com";
        }

       

        private void metroButton1_Click(object sender, EventArgs e)
        {


            try
            {
               
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(TextBoxFrom.Text);
                msg.To.Add(TextBoxTo.Text);
                msg.Subject = TextBoxSubject.Text;
                msg.Body = TextBoxBody.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "sharaddhage555555@gmail.com";
                ntcd.Password = "Sharad@987650";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");

                label5.Text = "Your Mail Send Successfully " + TextBoxTo.Text;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
