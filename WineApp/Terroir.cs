using System;
namespace WineApp
{
    public class Terroir
    {
        public Region region { get; set; }
        public List<PrevailingClimate> monthlyTemperatureMin { get; set; }
        public List<PrevailingClimate> monthlyTemperatureMax { get; set; }
        public List<PrevailingClimate> monthlyTemperatureAverage { get; set; }
        public List<PrevailingClimate> monthlyAveragerainfall { get; set; }
        public List<int> monthlyAveragesunshineHours { get; set; }
        public PrevailingClimate overallClimate { get; set; }
        public MicroClimate topography { get; set; }
        public MicroClimate slope { get; set; }
        public List<MicroClimate> cardinalDirection { get; set; }
        public SoilComposition soil { get; set; }
        public Vinification winemakingPrectices { get; set; }
    }
}

