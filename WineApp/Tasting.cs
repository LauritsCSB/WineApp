namespace WineApp
{
    public class Tasting
    {
        public DateTime Date { get; set; }
        public string Occasion { get; set; }
        public Bottle Bottle { get; set; }
        public Appearance Appearance { get; set; }
        public Nose Nose { get; set; }
        public Palate Palate { get; set; }
    }
}

