namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            if (numbers.Count == 0)
            {
                return new Stats(float.NaN, float.NaN, float.NaN);
            }

            // Calculate the Average, Max, and Min for non-empty lists
            float average = numbers.Average();
            float max = numbers.Max();
            float min = numbers.Min();

            return new Stats(average,max,min);
        }
    }
}
