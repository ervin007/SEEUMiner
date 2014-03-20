using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEUMiner.Library
{
    public class Statistics
    {
        double[] array_items;

        public Statistics(double[] items)
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
            return 0;
        }

        public double Percentile(int n)
        {
            return 0;
        }

        public double StandardDeviationP()
        {
            return 0;
        }

        public double StandardDeviationS()
        {
            return 0;
        }

        
    }
}
