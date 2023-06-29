using System;
namespace WineApp
{
    public class Aroma
    {
        public int intensity { get; set; }
        public List<string> complexity { get; set; }
        public List<string> primary { get; set; }
        public List<string> secondary { get; set; }
        public List<string> tertiary { get; set; }
        public List<string> floranAndHerbal { get; set; }
        public bool oak { get; set; }
        public List<string> balance { get; set; }
        public List<string> offOrFault { get; set; }
        public List<string> persistence { get; set; }
    }
}

