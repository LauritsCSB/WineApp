namespace WineApp
{
    public class Vineyard
    {
        public string nameOfVineyard { get; set; }
        public string locationOfVineyard { get; set; }
        public List<Grape> grapeVarietiesInProduction { get; set; }
        public DateOnly ageOfVineYard { get; set; }
        public int sizeOfVineyard { get; set; }
        public string vineAgeOnVineyard { get; set; }
        public int cropSizeAverage { get; set; }
        public int cropYieldAverage { get; set; }
        public string reputationAndQualityOfVineyard { get; set; }
        public string historicalSignificanceOfVineyard { get; set; }
        public List<string> notableWinesFromVineyard { get; set; }
    }
}

