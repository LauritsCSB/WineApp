namespace WineApp
{
    public class Appelation
    {
        public string nameOfAppelation { get; set; }
        public Country countryOfLocation { get; set; }
        public Region regionOfLocation { get; set; }
        public PrevailingClimate GeneralClimateOfArea { get; set; }
        public List<MicroClimate> MicroClimatesOfArea { get; set; }
        public List<SoilComposition.SoilDefaults> soilsOfAppelation { get; set; }
        public List<Terroir> terroirsOfAppelation { get; set; }
        public List<Grape> GrapeVarietiesOfAppelation { get; set; }
        public List<Grape> wineStylesOfAppelation { get; set; }
        public string cropSizeAverageOfAppelation { get; set; }
        public string cropYieldAverageOfAppelation { get; set; }
        public string historicalSignificanceOfAppelation { get; set; }
        public string reputationAndQualityOfAppelation { get; set; }
    }
}

