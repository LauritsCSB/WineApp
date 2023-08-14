namespace WineApp
{
    public class Grape
    {
        public string Name { get; set; }
        public Appearance Appearance { get; set; }
        public Aroma Aroma { get; set; }
        public Flavor Flavor { get; set; }
        public Body Body { get; set; }

        public enum WineTypes //placed here or defaults?
        {
            Red,
            White,
            Rosé,
            Orange,
            Sparkling,
            Fortified,
            Ice,
            Dessert
        }

        public int AgingPotential { get; set; }
    }
}