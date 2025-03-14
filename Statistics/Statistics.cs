using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Stats
    {
        public float average;
        public float max;
        public float min;
    }

    public class StatsComputer
    {
        public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here
            Stats stats = new Stats();
            if (numbers.Count == 0)
            {
                stats.average = float.NaN;
                stats.max = float.NaN;
                stats.min = float.NaN;
            }
            else
            {
                stats.average = CalculateAverage(numbers);
                stats.max = CalculateMax(numbers);
                stats.min = CalculateMin(numbers);
            }
            return stats;
        }

        private float CalculateMin(List<float> numbers)
        {
            float min = float.MaxValue;
            foreach (var number in numbers)
            {
            if (number < min)
            {
                min = number;
            }
            }
            return min;
        }

        private float CalculateMax(List<float> numbers)
        {
            float max = float.MinValue;
            foreach (var number in numbers)
            {
            if (number > max)
            {
                max = number;
            }
            }
            return max;
        }

        private float CalculateAverage(List<float> numbers)
        {
            float sum = 0;
            foreach (var number in numbers)
            {
            sum += number;
            }
            return sum / numbers.Count;
        }
    }
}
