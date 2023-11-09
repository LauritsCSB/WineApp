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

        public enum Finish
        {
            Short,
            Medium,
            Long,
            Lingering,
            Complex,
            Fading
        }

        public enum Complexity
        {
            Low,
            Moderate,
            Complex
        }
    }
}