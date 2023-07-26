namespace WineApp.Appearances
{
    public static class AppearanceDefaults
    {
        public static List<String> HueColor
        {
            get
            {
                return new List<String>()
                {
                    "Straw",
                    "Yellow",
                    "Gold",
                    "Brown",
                    "Amber",
                    "Copper",
                    "Salmon",
                    "Pink",
                    "Ruby",
                    "Purple",
                    "Garnet",
                    "Tawny"
                };
            }
        }

        public static List<string> ColorIntensityVariation
        {
            get
            {
                return new List<string>()
                {
                    "Pale",
                    "Medium",
                    "Deep"
                };
            }
        }

        public static List<string> RimVariation
        {
            get
            {
                return new List<string>()
                {
                    "Tight",
                    "Medium",
                    "Wide"
                };
            }
        }

        public static List<string> TransparancyVariation
        {
            get
            {
                return new List<string>()
                {
                    "Clear",
                    "Hazy",
                    "Opaque"
                };
            }
        }

        public static List<string> EffervescenceVariation
        {
            get
            {
                return new List<string>()
                {
                    "Fine and Delicate",
                    "Lively and Vigorous",
                    "Robust and Bountiful"
                };
            }
        }

        public static List<string> ViscosityVariation
        {
            get
            {
                return new List<string>()
                {
                    "Low",
                    "Medium",
                    "High"
                };
            }
        }

        public static List<string> SedimentVariation
        {
            get
            {
                return new List<string>()
                {
                    "No Sediment",
                    "Light Sediment",
                    "Medium Sediment",
                    "Heavy Sediment",
                    "Tartrate Crystals"
                };
            }
        }

        public static List<string> CorkConditionVariation
        {
            get
            {
                return new List<string>()
                {
                    "Excellent Condition",
                    "Slight Cork Taint",
                    "Moderate Cork Taint",
                    "Severe Cork Taint",
                    "Dry Cork",
                    "Cork Breakage"
                };
            }
        }
    }
}