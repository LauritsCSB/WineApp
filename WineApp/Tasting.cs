namespace WineApp
{
    public class Tasting
    {
        public DateTime dateOfTasting { get; set; }
        public string placeOfTasting { get; set; }
        public string occasionOfTasting { get; set; }

        public Appearance.AppearanceDefaults colorHue { get; set; }
        public Appearance.AppearanceDefaults intensityOfColor { get; set; }
        public Appearance.AppearanceDefaults rimVariationOfColor { get; set; }
        public Appearance.AppearanceDefaults transparancyOfColor { get; set; }
        public Appearance.AppearanceDefaults effervescenceOfWine { get; set; }
        public Appearance.AppearanceDefaults viscosityOfWine { get; set; }
        public Appearance.AppearanceDefaults sedimentInWine { get; set; }
        public Appearance.AppearanceDefaults corkCondition { get; set; }

        public Aroma.AromaDefaults aromaIntensity { get; set; }
        public Aroma.AromaDefaults complexityOfAroma { get; set; }
        public List<Aroma.AromaDefaults> primaryAromas { get; set; }
        public List<Aroma.AromaDefaults> secondaryAromas { get; set; }
        public List<Aroma.AromaDefaults> tertiaryAromas { get; set; }
        public List<Aroma.AromaDefaults> offOrFaultAromas { get; set; }
        public Aroma.AromaDefaults aromaBalance { get; set; }
        public Aroma.AromaDefaults persistenceOfAroma { get; set; }

        public List<Flavor.FlavorDefaults> primaryFlavours { get; set; }
        public List<Flavor.FlavorDefaults> secondaryFlavours { get; set; }
        public List<Flavor.FlavorDefaults> tertiaryFlavours { get; set; }
        public List<Flavor.FlavorDefaults> offOrFaultFlavours { get; set; }
        public Flavor.FlavorDefaults flavorBalance { get; set; }
        public Flavor.FlavorDefaults levelOfSweetness { get; set; }
        public Flavor.FlavorDefaults lengthOfFinish { get; set; }
        public Flavor.FlavorDefaults flavorComplexity { get; set; }

        public Body.BodyDefaults weightSensation { get; set; }
        public Body.BodyDefaults textureSensation { get; set; }
        public Body.BodyDefaults mouthCoatingAbility { get; set; }
        public Body.BodyDefaults tanninExperience { get; set; }
        public Body.BodyDefaults alcoholFeel { get; set; }
        public Body.BodyDefaults intensityExperience { get; set; }
    }
}

