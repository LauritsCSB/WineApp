using System;
namespace WineApp
{
    public class Country
    {
        public List<Region> regions { get; set; }
        public List<Appelation> appelations { get; set; }
        public List<Vineyard> vineyards { get; set; }
        public List<Vineyard> notableProducers { get; set; }
        public List<Grape> grapeVarieties { get; set; }
        public List<Appelation> lawAndRegulations { get; set; }
        public List<Terroir> terroirs { get; set; }
        public List<WinemakingTradition> tourismAndCulture { get; set; }
    }
}

