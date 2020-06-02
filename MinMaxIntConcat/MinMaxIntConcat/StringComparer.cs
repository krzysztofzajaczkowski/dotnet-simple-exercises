using System;
using System.Collections.Generic;
using System.Xml.Schema;

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
                // Compare the common part
                if (x[i] > y[i])
                {
                    return 1;
                }

                if (x[i] < y[i])
                {
                    return -1;
                }
            }
            // If common parts are equal, compare digits of a longer number
            // Assume that x is longer
            string longerString = x;
            int isBigger = 1;
            if (lengthDifference < 0)
            {
                // If actually y is longer
                longerString = y;
                // Need to reverse the return value
                isBigger = -1;
            }

            for (int i = numberOfIterations; i < longerString.Length; ++i)
            {
                if (longerString[i] > longerString[i - 1])
                {
                    return isBigger;
                }

                if (longerString[i] < longerString[i - 1])
                {
                    return -isBigger;
                }
            }

            return 0;
        }

    }
}