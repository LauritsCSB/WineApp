using System;
namespace WineApp
{
    public class PrevailingClimate
    {
        public Region regionName { get; set; }
        //Use constructor to set month, rest of properties is updated to hold values for that?
        public int temperatureMin { get; set; }
        public int temperatureMax { get; set; }
        public double temperatureAverage { get; set; }
        public int averageGDD { get; set; }
        public int averagesunshineHours { get; set; }
        public int averagerainfall { get; set; }
        public int diurnalTemperatureVariation { get; set; }
        public int humidutyLevel { get; set; }
        public string frostRisk { get; set; }

        /*public string OverallClimate(List<int> monthlyAveregeTemperature, more?)
        {
            //method returning valuation of overall climate ("warm", "cool, "moderate") based on climatic input
        }*/

        //method or field to display general data for climate of a region and/or country?
    }
}

