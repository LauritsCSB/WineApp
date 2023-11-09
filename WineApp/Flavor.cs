namespace WineApp
{
    public class Flavor
    {
        public PrimaryValues PrimaryFlavors { get; set;}
        public DefaultValues.SecondaryDefaults.Microbial SecondaryFlavors { get; set; }
        public TertiaryValues TertiaryFlavors { get; set; }
        public OffOrFaultValues OffOrFaultFlavors { get; set; }
        public DefaultValues.FlavorDefaults.Balance FlavorBalance { get; set; }
        public DefaultValues.FlavorDefaults.Finish FinishLength { get; set; }
        public DefaultValues.FlavorDefaults.Complexity FlavorComplexity { get; set; }
    }
}

