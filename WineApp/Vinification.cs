using System;
namespace WineApp
{
    public class Vinification
    {
        public List<Grape> grapeSelection { get; set; }
        public Season harvestDate { get; set; }
        public string harvestMethod { get; set; }
        public string sortingMethod { get; set; }
        public bool mechanicalDestemming { get; set; }
        public string crushingMethod { get; set; }
        public string macerationMethod { get; set; }
        public string macerationTime { get; set; }
        public string fermentationMethod { get; set; }
        public string yeastStrain { get; set; }
        public string fermentationTemperature { get; set; }
        public string fermentationDuration { get; set; }
        public bool malolacticFermentation { get; set; }
        public bool bottleFermentation { get; set; }
        public bool carbonicFermentation { get; set; }
        public List<string> extractionMethods { get; set; }
        public string pressingTechnique { get; set; }
        public List<string> filtrationTechniques { get; set; }
        public List<string> stabilizationTechniques { get; set; }
        public string closingMethod { get; set; }
        public List<string> agingMethods { get; set; }
        public int agingUntilRelease { get; set; }
    }
}

