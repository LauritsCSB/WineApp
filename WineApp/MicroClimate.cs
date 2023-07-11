namespace WineApp
{
    public class MicroClimate
    {
        public int proximityToWater { get; set; }
        public int altitude { get; set; }
        public string cardinalDirection { get; set; }
        public List<PrevailingClimate> monthlyTemperatureAverage { get; set; }
        public List<PrevailingClimate> monthlySunlightExposureAverage { get; set; }
        public List<PrevailingClimate> monthlyRainfallAverage { get; set; }
        public PrevailingClimate windPattern { get; set; }
        public List<SoilComposition> soilTypes { get; set; }
        public string topography { get; set; }
        public double slope { get; set; }
    }
}

/*should this be a method in another class (appelation)? just looking at the first field, how is that
 supposed to make sense in general?
 This could benefit from some defaults aswell*/