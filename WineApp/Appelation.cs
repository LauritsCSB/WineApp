namespace WineApp
{
    public class Appelation
    {
        public string name { get; set; }
        public Country country { get; set; }
        public Region region { get; set; }
        public PrevailingClimate generalClimate { get; set; }
        public List<MicroClimate> microClimates { get; set; }
        public List<SoilComposition> generalSoils { get; set; }
        public List<Terroir> generalTerroirs { get; set; }
        public List<Grape> grapeVarieties { get; set; }
        public List<Grape> typicalwineStyles { get; set; }
        public string cropSizeAverage { get; set; }
        public string cropYieldAverage { get; set; }
        public string historicalSignificance { get; set; }
        public List<Vineyard> notableProducers { get; set; }
        public WinemakingTradition tourismAndCulture { get; set; }
        public string reputationAndQuality { get; set; }
    }
}

