using System.Net;
using System.Net.Mail;
namespace WinFormsApp3
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

        private void otworz_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            textBox1.Text = fileDialog.FileName;
        }

        private void otworz2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "TXT File |*.txt";
            fileDialog.ShowDialog();
            textBox1.Text = fileDialog.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("technikprogramista.pzs@gmail.com");
            MailAddress to = new MailAddress("kubusjezyk69@gmail.com");

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Tytul naszego emaila";
            email.Body = "Tresc naszej wiadomowsci";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("technikprogramista.pzs@gmail.com","cbhpxxheqwbzugod");
            smtp.EnableSsl = true;

            string filename = @"C:\Users\1CT\Documents\plik.txt";
            Attachment attachment=new Attachment(filename);
            email.Attachments.Add(attachment);

            smtp.Send(email);
        }
    }
}
