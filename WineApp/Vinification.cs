namespace WineApp
{
    public class Vinification
    {
        public Season Season { get; set; }
        public string HarvestMethod { get; set; }
        public string SortingMethod { get; set; }
        public bool MechanicalDestemming { get; set; }
        public string CrushingMethod { get; set; }
        public string MacerationMethod { get; set; }
        public TimeOnly MacerationTime { get; set; }
        public string FermentationMethod { get; set; }
        public string YeastStrain { get; set; }
        public string FermentationTemperature { get; set; }
        public TimeOnly FermentationDuration { get; set; }
        public bool MalolacticFermentation { get; set; }
        public bool BottleFermentation { get; set; }
        public bool CarbonicFermentation { get; set; }
        public List<string> ExtractionMethods { get; set; }
        public string PressingTechnique { get; set; }
        public List<string> FiltrationTechniques { get; set; }
        public List<string> StabilizationTechniques { get; set; }
        public string ClosingMethod { get; set; }
        public List<string> AgingMethods { get; set; }
        public TimeOnly AgingBeforeRelease { get; set; }
    }
}

