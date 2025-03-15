namespace Statistics
{
    public class Stats
    {
        public Stats(float avg, float max, float min)
        {
            Average = avg;
            Max = max;
            Min = min;
        }
        public float Average { get; set; }
        public float Max { get; set; }
        public float Min { get; set; }
    }
}
