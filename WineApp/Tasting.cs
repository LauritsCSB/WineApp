namespace WineApp
{
    public class Tasting
    {
        public DateTime date { get; set; }
        public string place { get; set; }
        public string occasion { get; set; }

        public Appearance.AppearanceDefaults colorHue { get; set; }
        public Appearance.AppearanceDefaults colorIntensity { get; set; }
        public Appearance.AppearanceDefaults colorRimVariation { get; set; }
        public Appearance.AppearanceDefaults colorTransparancy { get; set; }
        public Appearance.AppearanceDefaults wineEffervescence { get; set; }
        public Appearance.AppearanceDefaults wineViscosity { get; set; }
        public Appearance.AppearanceDefaults sediment { get; set; }
        public Appearance.AppearanceDefaults corkCondition { get; set; }

        public Aroma.AromaDefaults aromaIntensity { get; set; }
        public Aroma.AromaDefaults aromaComplexity { get; set; }
        public List<Aroma.AromaDefaults> primaryAromas { get; set; }
        public List<Aroma.AromaDefaults> secondaryAromas { get; set; }
        public List<Aroma.AromaDefaults> tertiaryAromas { get; set; }
        public List<Aroma.AromaDefaults> offOrFaultAromas { get; set; }
        public Aroma.AromaDefaults aromaBalance { get; set; }
        public Aroma.AromaDefaults aromaPersistence { get; set; }

        public List<Flavor.FlavorDefaults> primaryFlavours { get; set; }
        public List<Flavor.FlavorDefaults> secondaryFlavours { get; set; }
        public List<Flavor.FlavorDefaults> tertiaryFlavours { get; set; }
        public List<Flavor.FlavorDefaults> offOrFaultFlavours { get; set; }
        public Flavor.FlavorDefaults flavorBalance { get; set; }
        public Flavor.FlavorDefaults flavorSweetness { get; set; }
        public Flavor.FlavorDefaults flavorLengthAndFinish { get; set; }
        public Flavor.FlavorDefaults flavorComplexity { get; set; }

        public Body.BodyDefaults weight { get; set; }
        public Body.BodyDefaults texture { get; set; }
        public Body.BodyDefaults mouthCoating { get; set; }
        public Body.BodyDefaults tannins { get; set; }
        public Body.BodyDefaults alcoholFeel { get; set; }
        public Body.BodyDefaults intensity { get; set; }
    }
}

