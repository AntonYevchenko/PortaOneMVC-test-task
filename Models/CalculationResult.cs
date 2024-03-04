namespace PortaOneMVC.Models
{
    public class CalculationResult
    {
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public double AverageNumber { get; set; }
        public double Median { get; set; }
        public List<int> LongestIncreasingSequence { get; set; }
        public List<int> LongestDecreasingSequence { get; set; }
    }
}
