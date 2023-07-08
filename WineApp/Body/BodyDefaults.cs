namespace WineApp.Body
{
    public class BodyDefaults
    {
        public static List<string> WeightVariation
        {
            get
            {
                return new List<string>()
                {
                    "Light",
                    "Medium",
                    "Heavy"
                };
            }
        }

        public static List<string> TextureVariation
        {
            get
            {
                return new List<string>()
                {
                    "Smooth",
                    "Crisp",
                    "Silky",
                    "Chewy",
                    "Lively"
                };
            }
        }

        public static List<string> MouthCoatingVariation
        {
            get
            {
                return new List<string>()
                {
                    "Thin",
                    "Medium",
                    "Rich",
                    "Creamy"
                };
            }
        }

        public static List<string> TanninsVariation
        {
            get
            {
                return new List<string>()
                {
                    "Low",
                    "Moderate",
                    "High",
                    "Ultra-High"
                };
            }
        }

        public static List<string> AlcoholFeelVariation
        {
            get
            {
                return new List<string>()
                {
                    "Light",
                    "Moderate",
                    "Warm",
                    "Hot"
                };
            }
        }

        public static List<string> IntensityVariation
        {
            get
            {
                return new List<string>()
                {
                    "Light",
                    "Moderate",
                    "Bold"
                };
            }
        }
    }
}

