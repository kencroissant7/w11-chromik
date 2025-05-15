using System.Net.Mail;
using System.Net;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            textBox3.Text = fileDialog.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("technikprogramista.pzs@gmail.com");
            MailAddress to = new MailAddress(textBox1.Text);

            MailMessage email = new MailMessage(from, to);
            email.Subject = textBox2.Text;
            email.Body = textBox4.Text;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("technikprogramista.pzs@gmail.com", "cbhpxxheqwbzugod");
            smtp.EnableSsl = true;

            
            if(textBox3.Text != "")
            {
            string filename = textBox3.Text;
            Attachment attachment = new Attachment(filename);
            email.Attachments.Add(attachment);
            }
           

            smtp.Send(email);
        }
    }
}
