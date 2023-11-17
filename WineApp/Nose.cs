namespace WineApp
{
    public class Nose
    {
        public DefaultValues.NoseDefaults.Condition Condition { get; set; }
        public DefaultValues.NoseDefaults.Intensity Intensity { get; set; }
        public PrimaryValues PrimaryAromas { get; set; }
        public DefaultValues.SecondaryDefaults.Microbial SecondaryAromas { get; set; }
        public TertiaryValues TertiaryAromas { get; set; }
        public FaultValues FaultAromas { get; set; }
    }
}

