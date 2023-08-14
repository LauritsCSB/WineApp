namespace WineApp
{
    public class Tasting
    {
        public DateTime Date { get; set; }
        public string Place { get; set; }
        public string Occasion { get; set; }
        public Bottle Bottle { get; set; }
        public Appearance Appearance { get; set; }
        public Aroma Aroma { get; set; }
        public Flavor Flavor { get; set; }
        public Body Body { get; set; }
    }
}

