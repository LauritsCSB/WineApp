namespace WineApp.DefaultValues
{ 
    public static class TertiaryDefaults
    {
        public static List<string> OakAging
        {
            get
            {
                return new List<string>()
                {
                    "Vanilla",
                    "Coconut",
                    "Baking Spices",
                    "Cigar Box",
                    "Smoke",
                    "Dill"
                };
            }
        }

        public static List<string> GeneralAging
        {
            get
            {
                return new List<string>()
                {
                    "Dried Fruit",
                    "Nutty Flavors",
                    "Tobacco",
                    "Coffee",
                    "Cocoa",
                    "Leather"
                };
            }
        }
    }
}
