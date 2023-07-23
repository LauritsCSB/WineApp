namespace WineApp.Aroma
{
    public class Aroma
    {
        public int aromaIntensity { get; set; }
        public string aromaComplexity { get; set; }
        public List<string> primaryAromas { get; set; }
        public List<string> secondaryAromas { get; set; }
        public List<string> tertiaryAromas { get; set; }
        public List<string> offOrFaultAromas { get; set; }
        public string aromaBalance { get; set; }
        public string aromaPersistence { get; set; }
    }


}

