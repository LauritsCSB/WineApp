using System;
namespace WineApp
{
    public class PrevailingClimate
    {
        public List<int> monthlyTemperatureMin { get; set; }
        public List<int> monthlyTemperatureMax { get; set; }
        public List<int> monthlyTemperatureAverage { get; set; }
        public List<int> monthlyAverageGDD { get; set; }
        public List<int> monthlyAveragesunshineHours { get; set; }
        public List<int> monthlyAveragerainfall { get; set; }
        public List<int> monthlyDiurnalTemperatureVariation { get; set; }
        public List<int> monthlyHumidutyLevel { get; set; }
        public List<string> generalWindPattern { get; set; }
        public List<string> mothlyFrostRisk { get; set; }

        /*public string OverallClimate(List<int> monthlyAveregeTemperature, more?)
        {
            //method returning valuation of overall climate ("warm", "cool, "moderate") based on climatic input
        }*/
    }
}

