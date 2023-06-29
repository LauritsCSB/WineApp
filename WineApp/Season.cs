using System;
namespace WineApp
{
    public class Season
    {
        public List<DateOnly> vintage { get; set; }
        public List<PrevailingClimate> averageMonthlyRainfall { get; set; }
        public List<PrevailingClimate> averageMonthlyTemperature { get; set; }
        public List<PrevailingClimate> averageMonthlySunlight { get; set; }
        public List<PrevailingClimate> averageMonthlyGDD { get; set; }
        public List<int> monthlyDaysOfFrost { get; set; }
        public List<int> monthlyDaysOfHail { get; set; }
        public string grapeDevelopment { get; set; }
        public string cropSize { get; set; }
        public string cropYield { get; set; }
        public string grapeHealth { get; set; }
        public string harvestTiming { get; set; }
        public string overallVintageQuality { get; set; }
        public int agingPotential { get; set; }
    }
}

