using System;
namespace WineApp
{
    public class Tasting
    {
        public DateTime CurrentDate { get; set; }
        public string Place { get; set; }
        public string Occasion { get; set; }


        public List<Appearance> hue { get; set; }
        public Appearance colorIntensity { get; set; }
        public List<Appearance> rimVariation { get; set; }
        public List<Appearance> transparancy { get; set; }
        public List<Appearance> clarity { get; set; }
        public List<Appearance> effervescence { get; set; }
        public List<Appearance> carbonation { get; set; }
        public List<Appearance> viscosity { get; set; }
        public List<Appearance> sediment { get; set; }
        public List<Appearance> corkCondition { get; set; }

        public Aroma aromaIntensity { get; set; }
        public List<Aroma> complexity { get; set; }
        public List<Aroma> primary { get; set; }
        public List<Aroma> secondary { get; set; }
        public List<Aroma> tertiary { get; set; }
        public List<Aroma> floranAndHerbal { get; set; }
        public Aroma oak { get; set; }
        public List<Aroma> balance { get; set; }
        public List<Aroma> offOrFault { get; set; }
        public List<Aroma> persistence { get; set; }

        public List<Flavor> primaryFlavours { get; set; }
        public List<Flavor> secondaryFlavours { get; set; }
        public List<Flavor> tertiaryFlavours { get; set; }
        public List<Flavor> flavorBalance { get; set; }
        public Flavor oakInfluence { get; set; }
        public Flavor sweetness { get; set; }
        public Flavor acidity { get; set; }
        public List<Flavor> lengthAndFinish { get; set; }
        public List<Flavor> flavorComplexity { get; set; }

        public List<Body> weight { get; set; }
        public List<Body> texture { get; set; }
        public List<Body> mouthCoating { get; set; }
        public List<Body> tannins { get; set; }
        public List<Body> alcoholFeel { get; set; }
        public List<Body> intensity { get; set; }

        public Texture smoothness { get; set; }
        public Texture silkiness { get; set; }
        public Texture creaminess { get; set; }
        public Texture crispness { get; set; }
    }
}

