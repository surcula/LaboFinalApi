using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Backgrounds
    {
        public int Id { get; set; }
        public string Background { get; set; }
        public int LanguageNumber { get; set; }
        public string Feature { get; set; }
        public string FeatureDescription { get; set; }
        public int SourceId { get; set; }
        IEnumerable<Items> outils { get; set; }
        public Sources Source { get; set; }

    }
}
