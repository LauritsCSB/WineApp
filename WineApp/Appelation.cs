using System;
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
        public Grape grapeVarieties { get; set; }
        public Grape typicalwineStyles { get; set; }
        public string historicalSignificance { get; set; }
        public List<Vineyard> notableProducers { get; set; }
        public WinemakingTradition tourismAndCulture { get; set; }
        public string reputationAndQuality { get; set; }
        public string lawAndRegulation { get; set; }
    }
}

