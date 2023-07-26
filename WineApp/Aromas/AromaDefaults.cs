namespace WineApp.Aromas
{
    public static class AromaDefaults
    {

        public static List<string> IntensityVariation
        {
            get
            {
                return new List<string>()
                {
                    "Light",
                    "Medium",
                    "Strong",
                    "Intense"
                };
            }
        }

        public static List<string> ComplexityVariation
        {
            get
            {
                return new List<string>()
                {
                    "Simple",
                    "Moderate",
                    "High",
                    "Profound"
                };
            }
        }

        public static List<string> BalanceVariation
        {
            get
            {
                return new List<string>()
                {
                    "Well-Balanced",
                    "Balanced",
                    "Slightly Off-Balance",
                    "Off Balance"
                };
            }
        }

        public static List<string> PersistenceVariation
        {
            get
            {
                return new List<string>()
                {
                    "Short",
                    "Medium",
                    "Long",
                    "Very Long"
                };
            }
        }
    }
}

