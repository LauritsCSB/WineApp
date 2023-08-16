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

        public enum ColorIntensityVariation
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

        public enum TransparancyVariation
        {
            Clear,
            Hazy,
            Opaque      
        }

        public enum EffervescenceVariation
        {
            Fine,
            Lively,
            Robust,
        }

        public enum ViscosityVariation
        {
            Low,
            Medium,
            High       
        }

        public enum SedimentVariation
        {
            None,
            Light,
            Medium,
            Heavy,
            Crystals
        }

        public enum CorkConditionVariation
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