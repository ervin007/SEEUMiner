using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEUMiner.Library
{
    public class DescriptiveStatistics
    {
        double[] array_items;

        public DescriptiveStatistics(double[] items)
        {
            array_items = items;
            Array.Sort(array_items);
        }
        public double Min()
        {
            return array_items[0];
        }

        public double Max()
        {
            return array_items[array_items.Length];
        }

        public double Average()
        {
            double s = 0;
            foreach (double el in array_items)
                s += el;
            return s / array_items.Length;

            //return array_items.average();
        }

        public double Median()
        {
            int pozita;
            double median;
            if (array_items.Length % 2 == 1)
            {
                
                pozita = (int)Math.Ceiling((double)array_items.Length / 2) - 1;
                median = array_items[pozita];
            }
            else //rasti cift
            {
                pozita = array_items.Length / 2;
                median = (array_items[pozita - 1] + array_items[pozita]) / 2;
            }

            return median;


        }

        public double Percentile(int n)
        {
            return 0;
        }


        
        public double StandardDeviationP()
        {
            double mean = Average();
            double sum = 0.0d;
            for (int i = 0; i < array_items.Length; i++)
            {
                sum = sum + Math.Pow(array_items[i] - mean, 2);
            }

            double STDev_P = Math.Sqrt(sum / array_items.Length);

            return STDev_P;
        }
        //someone was here
        //someone noticed this :P youre dead

        public double StandardDeviationS()
        {
            double mean = Average();
            double sum = 0.0d;
            for (int i = 0; i < array_items.Length; i++)
            {
                sum = sum + Math.Pow(array_items[i] - mean, 2);
            }

            double STDev_S = Math.Sqrt(sum / array_items.Length - 1);

            if (Double.IsNaN(STDev_S))
                return 0;

            return STDev_S;
        }

        
    }
}
