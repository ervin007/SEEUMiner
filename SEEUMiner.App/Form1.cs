using SEEUMiner.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEEUMiner.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] array = txtItems.Text.Split(',');

            double[] dArray = Array.ConvertAll(array, Double.Parse);

            DescriptiveStatistics s = new DescriptiveStatistics(dArray);

            MessageBox.Show("Mesatarja: " + s.Average().ToString());

            MessageBox.Show("Median:" + s.Median().ToString());

            MessageBox.Show("STDEV_Population: " + s.StandardDeviationP().ToString());
            MessageBox.Show("STDEV_Sample: " + s.StandardDeviationS().ToString());


            //CategoricalStatistics s = new CategoricalStatistics(array);

            //foreach (KeyValuePair<object, int> kv in s.Frequency())
            //{
            //    MessageBox.Show(kv.Key.ToString() + " - " + kv.Value.ToString());

            //}
            

        }
    }
}
