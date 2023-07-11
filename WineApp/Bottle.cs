using System;
namespace WineApp
{
    public class Bottle
    {
        public string name { get; set; }
        public Grape wineStyle { get; set; }
        public Region region { get; set; }
        public Appelation appelation { get; set; }
        public Vineyard vineyard { get; set; }
        public DateOnly vintage { get; set; }
        public int professionalScore { get; set; }
        public int userScore { get; set; }
        public List<Grape> grapeVarieties { get; set; }
        public int alcoholPercentage { get; set; }
        public string drinkOrHold { get; set; }
        public List<string> professionalNotes { get; set; }
        public string winemakersNote { get; set; }
        public Grape foodPairing { get; set; }
        public Vinification productionTechniques { get; set; }
        public List<string> awards { get; set; }
    }
}