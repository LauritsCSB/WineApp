namespace WineApp
{
    public class Grape
    {
        public List<string> nameOfGrape { get; set; }
        public string placeOfOrigin { get; set; }
        public List<Flavor.FlavorDefaults> primaryFlavors { get; set; }
        public List<Aroma.AromaDefaults> primaryAromas { get; set; }
        public Flavor.FlavorDefaults acidityInGeneral { get; set; }
        public Body.BodyDefaults tanninsInGeneral { get; set; }
        public List<Region> growingRegions { get; set; }
        public PrevailingClimate climateSuitability { get; set; }
        public Terroir optimalGrowingConditions { get; set; }
        public List<string> typicalWineStyles { get; set; }
        public List<string> wineAgingPotential { get; set; }
        public List<string> foodPairing { get; set; }
        public Vineyard notableProducers { get; set; }
        public string historicalSignificance { get; set; }
        public string currentTrends { get; set; }
    }
}