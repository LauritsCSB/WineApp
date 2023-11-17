namespace WineApp
{
    public class Palate
    {
        public DefaultValues.PalateDefaults.Sweetness Sweetness { get; set; }
        public DefaultValues.PalateDefaults.Acidity Acidity { get; set; }
        public DefaultValues.PalateDefaults.Tannin Tannin { get; set; }
        public DefaultValues.PalateDefaults.Nature Nature { get; set; }
        public PrimaryValues PrimaryFlavors { get; set;}
        public DefaultValues.SecondaryDefaults.Microbial SecondaryFlavors { get; set; }
        public TertiaryValues TertiaryFlavors { get; set; }
        public FaultValues FaultFlavors { get; set; }
    }
}

