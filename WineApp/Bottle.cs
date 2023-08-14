namespace WineApp
{
    public class Bottle
    {
        public string Name { get; set; }
        public List<Grape> Grapes { get; set; }
        public Vineyard Vineyard { get; set; }
        public DateOnly Vintage { get; set; }
        public int AlcoholPercentage { get; set; }
        public Vinification Vinification { get; set; }
    }
}