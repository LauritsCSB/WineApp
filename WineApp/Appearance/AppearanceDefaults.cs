using System;
namespace WineApp.Appearance
{
    public class AppearanceDefaults
    {
        public List<String> HueColor
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

        public List<string> ColorIntensityVariation
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

        public List<string> RimVariation
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

        public List<string> TransparancyVariation
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

        public List<string> EffervescenceVariation
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

        public List<string> ViscosityVariation
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

        public List<string> SedimentVariation
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

        public List<string> CorkConditionVariation
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