using System;
namespace WineApp
{
    public class MicroClimate
    {
        public int proximityToWater { get; set; }
        public int altitude { get; set; }
        public List<string> cardinalDirection { get; set; }
        public PrevailingClimate temperature { get; set; }
        public PrevailingClimate averageSunlightExposure { get; set; }
        public PrevailingClimate rainfall { get; set; }
        public PrevailingClimate windPattern { get; set; }
        public SoilComposition soil { get; set; }
        public List<string> topography { get; set; }
        public int slope { get; set; }
    }
}

