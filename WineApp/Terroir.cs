namespace WineApp
{
    public class Terroir
    {
        //Alwys related to a certain region or appelation, not sure if it should have a member to hold that data
        public List<PrevailingClimate> monthlyTemperatureMin { get; set; }
        public List<PrevailingClimate> monthlyTemperatureMax { get; set; }
        public List<PrevailingClimate> monthlyTemperatureAverage { get; set; }
        public List<PrevailingClimate> monthlyAveragerainfall { get; set; }
        public List<PrevailingClimate> monthlyAveragesunshineHours { get; set; }
        public PrevailingClimate overallClimate { get; set; }
        public MicroClimate topography { get; set; }
        public MicroClimate slope { get; set; }
        public MicroClimate cardinalDirection { get; set; }
        public List<SoilComposition> soilTypes { get; set; }
        public Vinification winemakingPrectices { get; set; }
    }
}

