using System;
namespace WineApp
{
    public class Vinification
    {
        public string harvestTime { get; set; }
        public string sorting { get; set; }
        public string crushingAndDestemming { get; set; }
        public string yeastStrain { get; set; }
        public string temperatureAndDuration { get; set; }
        public string extraction { get; set; }
        public string maceration { get; set; }
        public List<string> fermentationVessel { get; set; }
        public bool malolacticFermentation { get; set; }
        public List<string> agingMethod { get; set; }
        public List<string> clarifingMethod { get; set; }
        public int agingDuration { get; set; }
        public string blending { get; set; }
        public string timeOfBottleing { get; set; }
        public string closingMethod { get; set; }
        public string agingInBottle { get; set; }
    }
}

