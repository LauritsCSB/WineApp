namespace WineApp.DefaultValues
{
    public static class AppearanceDefaults
    {
        public enum Clarity
        {
            Clear,
            SlightlyCloudy,
            Cloudy
        }

        public enum Brightness
        {
            Dull,
            Bright,
            Brilliant
        }

        public enum Concentration
        {    
            Pale,
            Medium,
            Deep,
            Translucent,
            Opaque
        }

        public enum Color
        {
            LemonGreen,
            Lemon,
            Gold,
            Amber,
            Brown,
            Pink,
            PinkOrange,
            Orange,
            Purple,
            Ruby,
            Gernet,
            Tawny
        }

        public enum Hue
        {
            Silver,
            Green,
            Orange,
            Blue,
            Ruby,
            Garnet,
            Brown
        }

        public enum RimVariation
        {
            None,
            Tight,
            Medium,
            Wide
        }

        public enum Stain
        {
            None,
            Light,
            Medium,
            Heavy
        }

        public enum Viscosity
        {
            Low,
            Medium,
            High
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