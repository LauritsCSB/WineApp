namespace WineApp
{
    public class Season
    {
        public DateOnly vintage { get; set; }
        public List<PrevailingClimate> rainfallAverage { get; set; }
        public List<PrevailingClimate> temperatureAverage { get; set; }
        public List<PrevailingClimate> sunlightExposure { get; set; }
        public List<PrevailingClimate> growingDegreeDays { get; set; }
        public int daysOfFrost { get; set; }
        public int daysOfHail { get; set; }
        public string grapeDevelopmentEvaluation { get; set; }
        public string cropSize { get; set; }
        public string cropYield { get; set; }
        public string grapeHealth { get; set; }
        public string harvestTiming { get; set; }
        public string overallVintageQuality { get; set; }
        public string agingPotential { get; set; }
    }
}

