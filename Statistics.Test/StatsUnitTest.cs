using System;
using Xunit;
using Statistics;

namespace Statistics.Test
{
    public class StatsUnitTest
    {
        [Fact]
        public void ReportsAverageMinMax()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<___>{98.6, 98.2, 97.8, 102.2});
            float epsilon = 0.001F;
            Assert.True(Math.Abs(computedStats.average - 99.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.max - 102.2) <= epsilon);
            Assert.True(Math.Abs(computedStats.min - 97.8) <= epsilon);
        }
        [Fact]
        public void ReportsNaNForEmptyInput()
        {
            var statsComputer = new StatsComputer();
            var computedStats = statsComputer.CalculateStatistics(
                new List<___>{});
            // All fields of computedStats (average, max, min) must be
            // Double.NaN (not-a-number), as described in
            // https://docs.microsoft.com/en-us/dotnet/api/system.double.nan?view=netcore-3.1
            // Specify the Assert statements here
        }
    }
}
