using System;
namespace WineApp
{
    public class PrevailingClimate
    {
        public List<int> temperatureMin { get; set; }
        public List<int> temperatureMax { get; set; }
        public List<double> temperatureAverage { get; set; }
        public int averageGDD { get; set; }
        public int sunshineHoursAverage { get; set; }
        public int rainfallAverage { get; set; }
        public List<int> diurnalTemperatureVariation { get; set; }
        public List<int> humidutyLevelAverage { get; set; }
        public List<string> frostRiskAverage { get; set; }
    }
}

