using System;
namespace WineApp
{
    public class Region
    {
        public string name { get; set; }
        public Country country { get; set; }
        public List<Grape> grapeVarieties { get; set; }
        public PrevailingClimate generalClimate { get; set; }
        public List<MicroClimate> microClimates { get; set; }
        public List<SoilComposition> generalSoilTypes { get; set; }
        public string generalTopography { get; set; }
        public WinemakingTradition tourismAndCulture { get; set; }
        public string historicalSignificance { get; set; }
        public List<Grape> wineStyles { get; set; }
        public List<Vineyard> notableProducers { get; set; }
        public string regionalWindPattern { get; set; }
    }
}

