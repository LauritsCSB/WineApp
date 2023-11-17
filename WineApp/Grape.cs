namespace WineApp
{
    public class Grape
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public Climate IdealClimate { get; set; }
        public PrimaryValues CommonPrimaryNotes { get; set; }
        public List<Region> TypicalRegions { get; set; }
        public DefaultValues.WineTypeDefaults.WineTypes WineTypes { get; set; }
        public List<string> FoodPairings { get; set; }
    }
}