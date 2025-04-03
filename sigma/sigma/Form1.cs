using Opc.UaFx;
using Opc.UaFx.Client;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sigma
{
    public partial class Form1 : Form
    {
        private OpcClient opcClient;
        private ChartValues<double> chartValues = new ChartValues<double>();

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void InitializeChart()
        {
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "OPC UA Data",
                    Values = chartValues
                }
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Czas",
                Labels = new List<string>()
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Warto��"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string opcUrl = textBox1.Text;
                opcClient = new OpcClient(opcUrl);
                opcClient.Connect();

                if (opcClient.State == OpcClientState.Connected)
                {
                    pictureBox1.BackColor = Color.Green;
                }
                else
                {
                    pictureBox1.BackColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B��d po��czenia: " + ex.Message);
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opcClient != null)
            {
                opcClient.Disconnect();
                pictureBox1.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (opcClient != null && opcClient.State == OpcClientState.Connected)
                {
                    var tagName = textBox2.Text;
                    var value = opcClient.ReadNode(tagName);
                    textBox3.Text = value.ToString();
                }
                else
                {
                    MessageBox.Show("Brak po��czenia z OPC UA!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B��d odczytu: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (opcClient != null && opcClient.State == OpcClientState.Connected)
                {
                    var tagName = textBox2.Text;
                    OpcSubscription opcSubscription = opcClient.SubscribeNodes();

                    var item = new OpcMonitoredItem(tagName, OpcAttribute.Value);
                    item.DataChangeReceived += Item_DataChangeReceived;
                    item.SamplingInterval = 100;

                    opcSubscription.AddMonitoredItem(item);
                    opcSubscription.ApplyChanges();
                }
                else
                {
                    MessageBox.Show("Brak po��czenia z OPC UA!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("B��d subskrypcji: " + ex.Message);
            }
        }

        private void Item_DataChangeReceived(object sender, OpcDataChangeReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Item_DataChangeReceived(sender, e)));
                return;
            }

            double value;
            if (double.TryParse(e.Item.Value.ToString(), out value))
            {
                chartValues.Add(value);

                if (chartValues.Count > 20) // Zachowujemy tylko ostatnie 20 warto�ci
                    chartValues.RemoveAt(0);

                cartesianChart1.Update(true, true);
            }

            textBox3.Text = value.ToString();
        }
    }
}
