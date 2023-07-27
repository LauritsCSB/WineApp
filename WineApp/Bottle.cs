namespace WineApp
{
    public class Bottle
    {
        public string nameOfWine { get; set; }
        public Grape Grape { get; set; }
        public Vineyard vineyardOfProduction { get; set; }
        public DateOnly vintage { get; set; }
        public int professionalScore { get; set; }
        public int amateurScore { get; set; }
        public int alcoholPercentage { get; set; }
        public string drinkOrHold { get; set; }
        public List<string> professionalNotes { get; set; }
        public List<string> amateurNotes { get; set; }
        public string winemakersNote { get; set; }
        public Vinification Vinification { get; set; }
        public List<string> awards { get; set; }
    }
}