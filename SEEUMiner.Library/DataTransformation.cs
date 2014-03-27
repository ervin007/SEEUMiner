using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEUMiner.Library
{
    public class DataTransformation
    {
        public double[] MinMax(double[] array_to_normalize, double new_min, double new_max)
        {
            return null;
        }

        public double[] ZScore(double[] array_to_normalize)
        {
            //formula eshte: v-mesatarja / devijimi
            double average;
            double deviation;
            DescriptiveStatistics ds = new DescriptiveStatistics(array_to_normalize);
            average = ds.Average();
            deviation = ds.StandardDeviationP();
            List<double> normalized_array = new List<double>();

            foreach (double element in array_to_normalize)
            {
                double new_value = (element - average) / deviation;                 normalized_array.Add(new_value);
            }
            
            return normalized_array.ToArray();
        }

        public double[] DecimalScaling(double[] array_to_normalize)
        {
            return null;
        }

    }
}
