using System;
using System.Collections.Generic;

namespace MinMaxIntConcat
{
    public class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }
            var lengthDifference = x.Length - y.Length;
            // Assume that x is shorter
            int numberOfIterations = x.Length;

            if (lengthDifference > 0)
            {
                // If actually y is shorter, then swap
                numberOfIterations = y.Length;
            }

            for (int i = 0; i < numberOfIterations; ++i)
            {
                if (x[i] > y[i])
                {
                    return 1;
                }

                if (x[i] < y[i])
                {
                    return -1;
                }
            }

            if (lengthDifference > 0)
            {
                if (x[numberOfIterations] > x[numberOfIterations-1])
                {
                    return 1;
                }

                return -1;
            }

            if (lengthDifference < 0)
            {
                if (y[numberOfIterations] > y[numberOfIterations - 1])
                {
                    return -1;
                }

                return 1;
            }

            return 0;
        }

    }
}