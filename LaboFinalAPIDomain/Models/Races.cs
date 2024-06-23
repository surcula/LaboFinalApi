using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Races
    {
        public int Id { get; set; }
        public string Race { get; set; }
        public string StrenghtBonus { get; set; }
        public string DexterityBonus { get; set; }
        public string ConstitutionBonus { get; set; }
        public string WisdomBonus { get; set; }
        public string IntelligenceBonus { get; set; }
        public string CharismsBonus { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public int sourceId { get; set; }
        public Sources Source { get; set; }
    }
}
