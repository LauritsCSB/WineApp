using System;
namespace WineApp
{
    public class SoilComposition
    {
        public List<string> soilType { get; set; }
        public string Drainage(List<string> soilType)
        {
            //Method returning a valuation of the drainage based on the composition of soil types
        }
        public string WaterHoldingCapacity(List<string> soilType)
        {
            //Method returning a valuation of the water holding capacity based on the composition of soil types
        }
        public string HeatRetention(List<string> soilType)
        {
            //Method returning a valuation of the ability to retain and radiate heat based om the composition of soil types
        }
        public string SoilImpact(List<string> soilType)
        {
            //Method returning a valuation of the impact the soil composition has on crop
        }
        public int soilPH { get; set; }
        public List<string> mineralContent { get; set; }
        public List<string> soilStructure { get; set; }
        public List<string> soilErosion { get; set; }
    }
}

