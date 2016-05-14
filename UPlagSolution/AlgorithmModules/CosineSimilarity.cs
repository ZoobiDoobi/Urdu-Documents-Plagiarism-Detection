using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPlagSolution.AlgorithmModules
{
    public class CosineSimilarity
    {
        public static double CalculateCosineSimilarity(double[] vecA, double[] vecB)
        {
            var dotProduct = DotProduct(vecA, vecB);
            var magnitudeOfA = Magnitude(vecA);
            var magnitudeOfB = Magnitude(vecB);

            return dotProduct / (magnitudeOfA * magnitudeOfB);
        }

        private static double DotProduct(double[] vecA, double[] vecB)
        {
            double dotProduct = 0;
            for (var i = 0; i < vecA.Length; i++)
            {
                dotProduct += (vecA[i] * vecB[i]);
            }

            return dotProduct;
        }

        private static double Magnitude(double[] vector)
        {
            return Math.Sqrt(DotProduct(vector, vector));
        }
    }
}
