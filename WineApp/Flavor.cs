using System;
namespace WineApp
{
    public class Flavor
    {
        public List<string> primary { get; set; }
        public List<string> secondary { get; set; }
        public List<string> tertiary { get; set; }
        public List<string> balance { get; set; }
        public bool oakInfluence { get; set; }
        public int sweetness { get; set; }
        public int acidity { get; set; }
        public List<string> lengthAndFinish { get; set; }
        public List<string> complexity { get; set; }
    }
}

