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

            // test test test 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTransformation dt = new DataTransformation();
            List<double> array_to_normalize = new List<double>();
            foreach(string itm in lstNotNormalized.Items)
            {
                array_to_normalize.Add(Convert.ToDouble(itm));
            }
            
         foreach (double itm in dt.ZScore(array_to_normalize.ToArray()))
         {
             lstNormalized.Items.Add(itm.ToString());
         }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> fd = new Dictionary<string, int>();
            Dictionary<string, int> sd = new Dictionary<string, int>();

            fd.Add("Visar", 2);
            fd.Add("test", 2);
            fd.Add("aaa", 2);
            fd.Add("bbb", 2);

            sd.Add("Visar", 2);
            sd.Add("test", 3);
            sd.Add("aaa", 1);
            sd.Add("aba", 1);

            Similarity s = new Similarity();
            MessageBox.Show(s.Cosine(fd, sd).ToString());
        }
    }
}
