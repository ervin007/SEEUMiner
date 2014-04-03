using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEEUMiner.Library
{
    /// </summary>
    public class Similarity
    {
        /// <summary>
        /// The formula to calculate the euclidian distance is: 
        /// d(i,j) = ( (xi1 + xj1)^2 + (xi2 + xj2)^2 + (xip + xjp)^2 )^1/2
        /// Formmated formula here:
        /// http://en.wikipedia.org/wiki/Euclidean_distance
        /// </summary>
        /// <param name="firstObservation">array of double values</paradistm>
        /// <param name="secondObservation">array of double values</param>
        /// <returns>DOUBLE: EuclidianDistance</returns>
        public double EuclidianDistance(double[] firstObservation, double[] secondObservation)
        {
            double delta = 0.0d;    // stores the difference between elements of array, like (x[i] - y[i])
            double sum = 0.0d;      // stores the sum of squared differences

            foreach (double x in firstObservation)
            {
                foreach (double y in secondObservation)
                {
                    delta = x - y;
                    sum += Math.Pow(delta, 2);
                }
            }

            double distance = 1 / (1 + Math.Sqrt(sum)); // calculates the Euclidian distance, maps it in the range [0,1]

            return distance;
        }

        public double JaccardDistance(object[] firstObservation, object[] secondObservation)
        {
            return 0;
        }

        public double SMC(object[] firstObservation, object[] secondObservation)
        {
            return 0;
        }
        //koment

        /// <summary>
        /// To calculate the cosine similarity of two word sequences, we do the steps:
        /// step 1: Term Frequency: Term Frequency also known as TF measures the number
        /// of times a term (word) occurs in a document. Doing this we fins all the occurences 
        /// of a given word in the same document.  
        /// step 2: Normalize the TF in range [0,1]
        /// step 3: Find the euclidian norm (length) of Doc1 and Doc2 values
        /// step 4: Calculate the dot product of Doc1 elements and Doc2 elements
        /// calculate the Cosine sim. by dividing - x dot y / euclidian(doc1)*euclidian(doc2)
        /// </summary>
        /// <param name="firstDocument">Dictionary<string,int>: Pair of word,frequency from Document 1</param>
        /// <param name="secondDocument">Dictionary<string,int>: Pair of word,frequency from Document 2</param>
        /// <returns>double in range [0.0,1.0]</returns>
        public double Cosine(Dictionary<string, int> firstDocument, Dictionary<string, int> secondDocument)
        {

            return 0;
        }

        //Dictionary<string, int> NormalizedTF(Dictionary<string, int> document)
        //{

        //}
    }
}
