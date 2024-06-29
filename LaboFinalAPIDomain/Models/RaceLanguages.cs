using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class RaceLanguages
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public Languages Language { get; set; }
        public int RaceId { get; set; }
        public Races Race { get; set; }
    }
}
