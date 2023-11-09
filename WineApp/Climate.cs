namespace WineApp
{
    public class Climate 
    {
        public List<double> MonthlyAverageTemperature { get; set; }
        public List<double> DiurnalTemperatureVariation { get; set; }
        public List<double> MonthlySunlightHours { get; set; }
        public List<double> MonthlyRainfall { get; set; }
        public List<int> MonthlyHumidity { get; set; }
        public string WindPatternDescription { get; set; }
        public int GDD { get; set; }
        public List<string> MonthlyFrostRisk { get; set; }
        public List<double> LightIntensity { get; set; }
    }
}

