namespace WineApp.DefaultValues
{
    public static class FlavorDefaults
    {
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

        public static List<string> SweetnessVariation
        {
            get
            {
                return new List<string>()
                    {
                        "Dry",
                        "Off-Dry",
                        "Medium-Dry",
                        "Medium-Sweet",
                        "Sweet",
                        "Dessert"
                    };
            }
        }

        public static List<string> FinishVariation
        {
            get
            {
                return new List<string>()
                    {
                        "Short Finish",
                        "Medium Finish",
                        "Long Finish",
                        "Lingering Finish",
                        "Complex Finish",
                        "Fading Finish"
                    };
            }
        }
    }
}