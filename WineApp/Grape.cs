namespace WineApp
{
    public class Grape
    {
        public string Name { get; set; }
        public Appearance Appearance { get; set; }
        public Aroma Aroma { get; set; }
        public Flavor Flavor { get; set; }
        public Body Body { get; set; }
        public DefaultValues.WineTypeDefaults.WineTypes WineTypes { get; set; }
        public int AgingPotential { get; set; }
    }
}