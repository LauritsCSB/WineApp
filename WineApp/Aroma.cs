namespace WineApp
{
    public class Aroma
    {
        public string Intensity { get; set; }
        public string Complexity { get; set; }
        public List<string> PrimaryAromas { get; set; }
        public List<string> SecondaryAromas { get; set; }
        public List<string> TertiaryAromas { get; set; }
        public List<string> OffOrFaultAromas { get; set; }
        public string Balance { get; set; }
        public string Persistence { get; set; }
    }
}

