namespace WineApp
{
    public class Aroma
    {
        public OffOrFaultValues OffOrFaultAromas { get; set; }
        public DefaultValues.AromaDefaults.Intensity Intensity { get; set; }
        public DefaultValues.AromaDefaults.AgeAssessment AgeAssessment { get; set; }
        public PrimaryValues PrimaryAromas { get; set; }
        public DefaultValues.SecondaryDefaults.Microbial SecondaryAromas { get; set; }
        public TertiaryValues TertiaryAromas { get; set; }
    }
}

