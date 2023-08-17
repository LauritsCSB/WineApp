namespace WineApp.DefaultValues
{
    public static class FlavorDefaults
    {
        public enum Balance
        {
                        WellBalanced,
                        Balanced,
                        SlightlyOffBalance,
                        OffBalance
                    
        }

        public enum Sweetness
        {
                        Dry,
                        OffDry,
                        MediumDry,
                        MediumSweet,
                        Sweet,
                        Dessert
        }

        public enum Finish
        {
                        Short,
                        Medium,
                        Long,
                        Lingering,
                        Complex,
                        Fading
        }
    }
}