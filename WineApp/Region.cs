using System;
namespace WineApp
{
    public class Region
    {
        public string nameOfRegion { get; set; }
        public Country countryOfRegion { get; set; }
        public List<Grape> grapeVarietiesInRegion { get; set; }
        public PrevailingClimate generalClimateOfRegion { get; set; }
        public List<MicroClimate> microClimatesInRegion { get; set; }
        public List<SoilComposition.SoilDefaults> generalSoilTypesInRegion { get; set; }
        public string generalTopographyOfRegion { get; set; }
        public string historicalSignificanceOfRegion { get; set; }
        public List<Grape> commonWineStylesInRegion { get; set; }
        public List<Vineyard> notableProducersOfRegion { get; set; }
        public string regionalWindPatternInRegion { get; set; }
        public string wineMakingRegulationOfRegion { get; set; }
    }
}

