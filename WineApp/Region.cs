using System;
namespace WineApp
{
    public class Region
    {
        public string name { get; set; }
        public Country country { get; set; }
        public Appelation appelations { get; set; }
        public Grape grapeVarieties { get; set; }
        public PrevailingClimate climate { get; set; }
        public MicroClimate microClimate { get; set; }
        public SoilComposition generalSoil { get; set; }
        public List<MicroClimate> topography { get; set; }
        public WinemakingTradition tourismAndCulture { get; set; }
        public string historicalSignificance { get; set; }
        public List<Grape> wineStyles { get; set; }
        public Vineyard notableProducers { get; set; }
    }
}

