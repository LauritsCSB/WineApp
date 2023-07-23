using System;
namespace WineApp
{
    public class Bottle
    {
        public string nameOfWine { get; set; }
        public Grape wineStyle { get; set; }
        public Region regionOfOrigin { get; set; }
        public Appelation appelationOfOrigin { get; set; }
        public Vineyard vineyardOfProduction { get; set; }
        public DateOnly vintage { get; set; }
        public int professionalScore { get; set; }
        public int amateurScore { get; set; }
        public List<Grape> grapeVarieties { get; set; }
        public int alcoholPercentage { get; set; }
        public string drinkOrHold { get; set; }
        public List<string> professionalNotes { get; set; }
        public List<string> amateurNotes { get; set; }
        public string winemakersNote { get; set; }
        public Grape foodPairing { get; set; }
        public Vinification productionTechniques { get; set; }
        public List<string> awards { get; set; }
    }
}