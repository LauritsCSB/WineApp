namespace WineApp
{
    public class Aroma
    {
        public DefaultValues.AromaDefaults.Intensity Intensity { get; set; }
        public DefaultValues.AromaDefaults.Complexity Complexity { get; set; }
        public PrimaryValues PrimaryAromas { get; set; }
        public DefaultValues.SecondaryDefaults.Microbial SecondaryAromas { get; set; }
        public TertiaryValues TertiaryAromas { get; set; }
        public OffOrFaultValues OffOrFaultAromas { get; set; }
        public DefaultValues.AromaDefaults.Balance Balance { get; set; }
        public DefaultValues.AromaDefaults.Persistence Persistence { get; set; }
    }
}

