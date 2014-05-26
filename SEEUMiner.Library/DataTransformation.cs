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
            //This is a work in progress for now. I will return back to it...eventually...
            //some_variable is a sample number
            decimal some_variable = 2;
            //the scale of the decimal value
            decimal base_scale = 1.0000m;
            //the scale factor
            decimal scale_factor= 1;
            //the scale factor size
            decimal scale_factor_size = 3;
            //the scaling loop
            for ( int i=0 ; i<scale_factor_size; i++)
            {  scale_factor *= base_scale;}
            decimal result = some_variable * scale_factor;

            //It took me a few day to write 7 lines of code but just 25 seconds to find the chess game.

           // 8 ║♜ ♞ ♝ ♛ ♚ ♝ ♞ ♜
           // 7 ║♟ ♟ ♟ ♟ ♟ ♟ ♟ ♟
           // 6 ║… … … … … … … …
           // 5 ║… … … … … … … …                Knight to C3! 
           // 4 ║… … … … … … … …
           // 3 ║… … ♘ … … … … …
           // 2 ║♙ ♙ ♙ ♙ ♙ ♙ ♙ ♙
           // 1 ║♖ …  ♗ ♕ ♔ ♗ ♘ ♖
            // —╚═══════════════
            // ——a  b  c  d  e  f  g  h
                  
            return null;
        }

    }
}
