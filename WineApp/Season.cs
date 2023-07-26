namespace WineApp
{
    public class Season
    {
        public DateOnly YearOfSeason { get; set; }
        public Region regionName { get; set; }
        public List<int> monthlyRainfallOfSeason { get; set; }
        public List<int> monthlyTemperatureAverageInSeason { get; set; }
        public List<Climate> sunlightExposureInSeason { get; set; }
        public List<Climate> growingDegreeDaysInSeason { get; set; }
        public int daysOfFrostInSeason { get; set; }
        public int daysOfHailInSeason { get; set; }
        public string grapeDevelopmentEvaluation { get; set; }
        public string sizeOfCropInSeason { get; set; }
        public string yieldOfCropInSeason { get; set; }
        public string grapeHealthInSeason { get; set; }
        public string budbreakTimingOfSeason { get; set; }
        public string harvestTimingOfSeason { get; set; }
        public string overallVintageQuality { get; set; }
        public string agingPotentialOfWinesInSeason { get; set; }
    }
}

