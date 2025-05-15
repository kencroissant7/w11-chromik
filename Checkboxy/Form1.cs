namespace Checkboxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked && !comboBox2.Items.Contains(comboBox1.Text))
            {
                comboBox2.Items.Add(comboBox1.Text);
                comboBox2.Text = comboBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0;i<10;i++)
            {
                comboBox1.Items.Add(i.ToString());
            }
            checkBox1.Checked = false;
            comboBox1.Text = "0";
        }
    }
}
