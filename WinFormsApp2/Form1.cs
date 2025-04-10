namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zielony_CheckedChanged(object sender, EventArgs e)
        {
            if (zielony.Checked)
            {
                this.BackColor = Color.Green;

            }

        }
        private void czerwony_CheckedChanged(object sender, EventArgs e)
        {
            if (czerwony.Checked)
            {
                this.BackColor = Color.Red;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++) //wypelnienie combobox
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.Text = "1";

            int c = comboBox1.Items.Count; //ile itemow w combobox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            if (comboBox1.Items.Count > 1)
            {
                int skidb = comboBox1.SelectedIndex;  //usuwa wybrany index w comboboxie
                comboBox1.Items.RemoveAt(skidb);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s1 = comboBox1.SelectedItem.ToString();
            if (copy.Checked)
            {
                if (comboBox2.Items.Contains(s1) == false)
                {
                    comboBox2.Items.Add(s1);
                }
            }

        }

        private void copy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.Items.Clear();
            }
        }
    }
}

