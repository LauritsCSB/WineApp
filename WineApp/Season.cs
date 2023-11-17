namespace WineApp
{
    public class Season
    {
        public DateOnly YearOfSeason { get; set; }
        public Region RegionName { get; set; }
        public DateOnly HarvestDate { get; set; }
        public bool FrostDuringBudbreak { get; set; }
        public int SpringDaysOfFrost { get; set; }
        public int AutumnDaysOfFrost { get; set; }

        public Climate GetClimate { get; set; }
    }
}