using System;
namespace WineApp
{
    public class Bottle
    {
        public string name { get; set; }
        public Grape style { get; set; }
        public Region region { get; set; }
        public Appelation appelation { get; set; }
        public Vineyard vineyardInfo { get; set; }
        public DateOnly vintage { get; set; }
        public int professionalScore { get; set; }
        public int userScore { get; set; }
        public Grape grapeVariety { get; set; }
        public int alcohol { get; set; }
        public List<string> drinkOrHold { get; set; }
        public List<string> professionalNotes { get; set; }
        public string winemakersNotes { get; set; }
        public Grape foodPairing { get; set; }
        public Vinification productionTechniques { get; set; }
        public string awards { get; set; }
    }
}