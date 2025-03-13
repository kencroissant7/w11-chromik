using LiveCharts;
using LiveCharts.Wpf;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public SeriesCollection SeriesCollection { get; set; }
        public List<double> values = new List<double>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeriesCollection = new SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Nowy wykres",
                    Values=new ChartValues<double>()
                }
            };



            myChart1.AxisX.Add(new Axis
            {
                Title = "Oœ X"
            });
            myChart1.AxisY.Add(new Axis
            {
                Title = "Oœ Y",
                LabelFormatter = value => value + " oC"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double value = random.Next(0, 100);

            SeriesCollection[0].Values.Add(value);
            myChart1.Series = SeriesCollection;



            if (SeriesCollection[0].Values.Count > 15)
            {
                SeriesCollection[0].Values.RemoveAt(0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double val;
            SeriesCollection[0].Values.Clear();
            for(int i = 0; i < 10; i++)
            {
                val = random.Next(0, 10);
                SeriesCollection[0].Values.Add(val);
            }
        }
    }
}
