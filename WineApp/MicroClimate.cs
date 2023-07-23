namespace WineApp
{
    public class MicroClimate
    {
        public int proximityToBodyOfWater { get; set; }
        public int altitudeOfMicroClimate { get; set; }
        public int latitudeOfMicroClimate { get; set; }
        public List<PrevailingClimate> monthlyTemperatureAverage { get; set; }
        public List<PrevailingClimate> monthlySunlightExposureAverage { get; set; }
        public List<PrevailingClimate> monthlyRainfallAverage { get; set; }
        public PrevailingClimate windPatternOfMicroClimate { get; set; }
        public List<SoilComposition.SoilDefaults> soilTypesInMicroClimate { get; set; }
        public string topographyOfMicroClimate { get; set; }
        public double slopeInMicroClimate { get; set; }
        public string cardinalDirectionOfSlope { get; set; }
    }
}

/*should this be a method in another class (appelation)? just looking at the first field, how is that
 supposed to make sense in general?
 This could benefit from some defaults aswell*/