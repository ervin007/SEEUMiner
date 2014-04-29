using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEUMiner.Library
{
    /// <summary>
    /// Categorical Statistics
    /// </summary>
    public class CategoricalStatistics
    {
        double[] array_items;
        public CategoricalStatistics(double[] array)
        {
            array_items = array;
        }

        public Dictionary<object, int> Frequency()
        {
            Dictionary<object, int> ret = new Dictionary<object, int>();
            
            foreach (object item in array_items)
            {
                if (ret.ContainsKey(item))
                {
                    ret[item]++;
                }
                else
                {
                    ret.Add(item, 1);
                }
            }

            return ret;
        }

        public Dictionary<object, int> CalculateMode()
        {
            Dictionary<object, int> frequency = new Dictionary<object,int>();
            Dictionary<object, int> ret = new Dictionary<object,int>();
            foreach(object item in array_items)
            {
                if (frequency.ContainsKey(item))
                    frequency[item]++;
                else
                    frequency[item] = 1;
            }

            frequency.OrderByDescending(k => k.Value);
            ret.Add(frequency.ElementAt(0).Key, frequency.ElementAt(0).Value);

            for (int i = 0; i < frequency.Count-1; i++)
            {
                if (frequency.ElementAt(i).Value != frequency.ElementAt(i + 1).Value)
                {
                    return ret;
                }
                else
                {
                    ret.Add(frequency.ElementAt(i + 1).Key, frequency.ElementAt(i + 1).Value);
                }
            }
            
            return ret;
        }


    }
}
