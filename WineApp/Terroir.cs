namespace WineApp
{
    public class Terroir
    {
        //Alwys related to a certain region or appelation, not sure if it should have a member to hold that data
        public List<PrevailingClimate> temperatureMins { get; set; }
        public List<PrevailingClimate> temperatureMaxes { get; set; }
        public List<PrevailingClimate> temperatureAverages { get; set; }
        public PrevailingClimate rainfallAverages { get; set; }
        public List<PrevailingClimate> sunshineHoursAverage { get; set; }
        public List<PrevailingClimate> diurnalTemperatureVariations { get; set; }
        public List<PrevailingClimate> humidutyLevelAverages { get; set; }
        public List<PrevailingClimate> frostRiskAverages { get; set; }
        public PrevailingClimate overallClimate { get; set; }
        public MicroClimate topographyOfArea { get; set; }
        public MicroClimate slopeOfArea { get; set; }
        public MicroClimate cardinalDirectionOfArea { get; set; }
        public MicroClimate windPatternOfArea { get; set; }
        public MicroClimate altitudeOfArea { get; set; }
        public MicroClimate latitudeOfArea { get; set; }
        //Field holding data about the length of a season or general length of a season

        public List<SoilComposition.SoilDefaults> soilTypesInArea { get; set; }
        public SoilComposition.SoilComposition drainageOfSoil { get; set; }
        public SoilComposition.SoilComposition waterHoldingCapacity { get; set; }
        public SoilComposition.SoilComposition heatRetention { get; set; }
        public Region winemakingRegulationOfArea { get; set; }

    }
}

