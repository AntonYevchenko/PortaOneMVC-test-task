// Ignore Spelling: ints

using MathNet.Numerics.Statistics;

namespace PortaOneMVC.Models
{
    public static class Calculate
    {
        public static int FindMinNumber(List<int> ints)
        {
            return ints.Min();
        }

        public static int FindMaxNumber(List<int> ints)
        {
            return ints.Max();
        }       

        public static double FindAverageNumber(List<int> ints)
        {
            return ints.Average();
        }

        public static double FindMedian(List<double> ints)
        {
            return ints.Median();
        }

        public static List<int> FindLongestIncreasingSequence(List<int> ints)
        {
            var longest = new List<int>();
            var temp = new List<int>() { ints[0] };

            for (int i = 1; i < ints.Count; i++)
            {
                if (ints[i] > temp[^1])
                {
                    temp.Add(ints[i]);
                }
                else
                {
                    if (temp.Count > longest.Count)
                    {
                        longest = new List<int>(temp);
                    }
                    temp.Clear();
                    temp.Add(ints[i]);
                }
            }
            if (temp.Count > longest.Count)
            {
                longest = new List<int>(temp);
            }
            return longest;
        }

        public static List<int> FindLongestDecreasingSequence(List<int> ints)
        {
            var result = new List<int>();
            var temp = new List<int>() { ints[0] };

            for (int i = 1; i < ints.Count; i++)
            {
                if (ints[i] < temp[^1])
                {
                    temp.Add(ints[i]);
                }
                else
                {
                    if (temp.Count > result.Count)
                    {
                        result = new List<int>(temp);
                    }
                    temp.Clear();
                    temp.Add(ints[i]);
                }
            }
            if (temp.Count > result.Count)
            {
                result = new List<int>(temp);
            }
            return result;
        }
    }
}
