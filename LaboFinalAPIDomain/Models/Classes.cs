using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Classes
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int StrenghtBonus { get; set; }
        public int DexterityBonus { get; set; }
        public int ConstitutionBonus { get; set; }
        public int WisdomBonus { get; set; }
        public int IntelligenceBonus { get; set; }
        public int CharismaBonus { get; set; }
        public int DV {  get; set; }
        public int NbSkill {  get; set; }

        public int SourceId { get; set; }
        public Sources Source { get; set; }

    }
}
