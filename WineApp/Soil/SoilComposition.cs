namespace WineApp.SoilComposition
{
    public class SoilComposition
    {
        public List<string> soilTypes { get; set; }
        public string Drainage(List<string> soilTypes)
        {
            //Method returning a valuation of the drainage based on the composition of soil types
        }
        public string WaterHoldingCapacity(List<string> soilTypes)
        {
            //Method returning a valuation of the water holding capacity based on the composition of soil types
        }
        public string HeatRetention(List<string> soilTypes)
        {
            //Method returning a valuation of the ability to retain and radiate heat based om the composition of soil types
        }
    }
}

//need some defaults for this