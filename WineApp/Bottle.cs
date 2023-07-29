namespace WineApp
{
    public class Bottle
    {
        public string Name { get; set; }
        public List<Grape> Grapes { get; set; }
        public Vineyard Vineyard { get; set; }
        public DateOnly Vintage { get; set; }
        public int ProfessionalScore { get; set; }
        public int AmateurScore { get; set; }
        public int AlcoholPercentage { get; set; }
        public string DrinkOrHold { get; set; }
        public List<string> ProfessionalNotes { get; set; }
        public List<string> AmateurNotes { get; set; }
        public string WinemakersNote { get; set; }
        public Vinification Vinification { get; set; }
        public List<string> Awards { get; set; }
    }
}