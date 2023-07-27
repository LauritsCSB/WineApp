namespace WineApp.DefaultValues
{
    public static class FaultDefaults
    {
        public static List<string> CorkTaint
        {
            get
            {
                return new List<string>()
                {
                    "Musty Cardboard",
                    "Wet Dog"
                };
            }
        }

        public static List<string> Cooked
        {
            get
            {
                return new List<string>()
                {
                    "Toffee",
                    "Stewed Fruit"
                };
            }
        }

        public static List<string> VolatilyAcidity
        {
            get
            {
                return new List<string>()
                {
                    "Vinegar",
                    "Nail Polish Remover"
                };
            }
        }

        public static List<string> SulfidesAndMerceptans
        {
            get
            {
                return new List<string>()
                {
                    "Cured Meat",
                    "Boiled Eggs",
                    "Burnt Rubber",
                    "Lit Match",
                    "Garlic",
                    "Onion",
                    "Cat Pee"
                };
            }
        }

        public static List<string> Brettanomyce
        {
            get
            {
                return new List<string>()
                {
                    "Black Cardamon",
                    "Band-Aid",
                    "Sweaty Leather Saddle",
                    "Horse Manure"
                };
            }
        }
    }
}
