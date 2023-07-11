namespace WineApp
{
    public class Country
    {
        public string nameOfCountry { get; set; }
        public List<Region> regions { get; set; }
        public List<Appelation> appelations { get; set; }
        public List<Vineyard> vineyards { get; set; }
        public List<Vineyard> notableProducers { get; set; }
        public List<Grape> grapeVarieties { get; set; }
        public List<WinemakingTradition> tourismAndCulture { get; set; }
        public string lawAndRegulations { get; set; }
        public string generalWindPattern { get; set; }

    }
}

