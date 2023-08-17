namespace WineApp.DefaultValues
{
    public static class AppearanceDefaults
    {
        public enum HueColor
        {
            Straw,
            Yellow,
            Gold,
            Brown,
            Amber,
            Copper,
            Salmon,
            Pink,
            Ruby,
            Purple,
            Garnet,
            Tawny
        }

        public enum ColorIntensity
        {    
            Pale,
            Medium,
            Deep      
        }

        public enum RimVariation
        {
            Tight,
            Medium,
            Wide       
        }

        public enum Transparancy
        {
            Clear,
            Hazy,
            Opaque      
        }

        public enum Effervescence
        {
            Fine,
            Lively,
            Robust,
        }

        public enum Viscosity
        {
            Low,
            Medium,
            High       
        }

        public enum Sediment
        {
            None,
            Light,
            Medium,
            Heavy,
            Crystals
        }

        public enum CorkCondition
        {
            Excellent,
            SlightTaint,
            ModerateTaint,
            SevereTaint,
            Dry,
            Broken
        }
    }
}