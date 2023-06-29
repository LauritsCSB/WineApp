using System;
namespace WineApp
{
    public class Grape
    {
        public List<string> name { get; set; }
        public string origin { get; set; }
        public List<Flavor> primaryFlavors { get; set; }
        public List<Flavor> secondaryFlavors { get; set; }
        public List<Flavor> tertiaryFlavors { get; set; }
        public List<Aroma> primaryAromas { get; set; }
        public List<Aroma> secondaryAromas { get; set; }
        public List<Aroma> tertiaryAromas { get; set; }
        public Flavor acidity { get; set; }
        public Body tannins { get; set; }
        public List<string> growingRegions { get; set; }
        public PrevailingClimate climateSuitability { get; set; }
        public Terroir growingConditions { get; set; }
        public List<string> wineStyles { get; set; }
        public List<string> agingPotential { get; set; }
        public List<string> foodPairing { get; set; }
        public Vineyard notableProducers { get; set; }
        public string historicalSignificance { get; set; }
        public string currentTrends { get; set; }
    }
}

