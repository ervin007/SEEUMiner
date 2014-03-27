using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEUMiner.Library
{
    /// <summary>
    /// Statistics for categorical attributes
    /// </summary>
    public class CategoricalStatistics
    {
        object[] array_items;
        public CategoricalStatistics(object[] array)
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

        public Dictionary<object, int> Mode()
        {
            return null;
        }


    }
}
