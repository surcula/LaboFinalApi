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
        public string StrenghtBonus { get; set; } = "0";
        public string DexterityBonus { get; set; } = "0";
        public string ConstitutionBonus { get; set; } = "0";
        public string WisdomBonus { get; set; } = "0";
        public string IntelligenceBonus { get; set; } = "0";
        public string CharismasBonus { get; set; } = "0";
        public string Size { get; set; }
        public string Speed { get; set; }
        public int SourceId { get; set; }
        public Sources Source { get; set; }
    }
}
