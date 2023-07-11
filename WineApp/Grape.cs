namespace WineApp
{
    public class Grape
    {
        public List<string> name { get; set; }
        public string origin { get; set; }
        public List<Flavor.FlavorDefaults> primaryFlavors { get; set; }
        public List<Aroma.AromaDefaults> primaryAromas { get; set; }
        public Flavor.FlavorDefaults acidity { get; set; }
        public Body.BodyDefaults tannins { get; set; }
        public List<Region> growingRegions { get; set; }
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