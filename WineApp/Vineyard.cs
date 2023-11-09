namespace WineApp
{
    public class Vineyard
    {
        public string Name { get; set; }
        public Address Address { get; set; } 
        public Appelation Appelation { get; set; }
        public DefaultValues.SoilDefaults.SoilTypes SoilTypes { get; set; }
        public int Altitude { get; set; }
        public int Latitude { get; set; }
        public int ProximityToBodyOfWater { get; set; }
        public string Topography { get; set; }
        public double SlopeAngle { get; set; }
        public string CardinalDirectionOfSlope { get; set; }
    }
}