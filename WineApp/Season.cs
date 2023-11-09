namespace WineApp
{
    public class Season
    {
        public DateOnly YearOfSeason { get; set; }
        public Region RegionName { get; set; }

        public List<double> MonthlyTemperatureAverage { get; set; }
        public List<double> MonthlyTemperatureHigh { get; set; }
        public List<double> MonthlyTemperatureLow { get; set; }
        public List<double> MonthlyRainfall { get; set; }

        public DateOnly HarvestDate { get; set; }

        public bool FrostDuringBudbreak { get; set; }
        public int SpringDaysOfFrost { get; set; }
        public int AutumnDaysOfFrost { get; set; }
    }
}

