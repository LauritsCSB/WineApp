namespace WineApp
{
    public class SoilComposition
    {
        public List<string> SoilTypes { get; set; }
        public string Drainage(List<string> soilTypes)
        {
            //Method returning a valuation of the drainage based on the composition of soil types
        }
        public string WaterHoldingCapacity(List<string> soilTypes)
        {
            //Method returning a valuation of the water holding capacity based on the composition of soil types
        }
        //public string HeatRetention()
        //{
        //    int retention = 0;

        //    switch(SoilTypes.First())
        //    {
        //        Soiltype.Gravel:
        //        Soiltype.Rock:
        //            rention = retention + 10;
        //    }


        //Method returning a valuation of the ability to retain and radiate heat based om the composition of soil types

        public int HeatRetention
        {
            get
            {
                //foreach soil calculate int heat retentin
                int retention = 0;

                //switch (SoilTypes.First())
                //{
                //     ; //TODO IMPLEMENT
                //}
                return retention;

            }

        }
    }
}

//need some defaults for this