namespace WineApp
{
    public class Climate
    {
        public Region Region { get; set; }
        public List<double> MonthlyTemperature { get; set; }
        public List<double> DiurnalTemperatureVariation { get; set; }
        public int SunlightHours { get; set; }
        public int Rainfall { get; set; }
        public List<int> MonthlyHumidity { get; set; }
        public string WindPattern { get; set; }
        public int AverageGDD { get; set; }
        public List<int> HumidutyLevelAverage { get; set; }
        public List<string> FrostRiskAverage { get; set; }
        public int LengthOfGrowingSeason { get; set; }
    }
}

