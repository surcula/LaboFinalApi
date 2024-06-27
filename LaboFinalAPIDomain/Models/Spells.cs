using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Spells
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public string? School { get; set; }
        public string Range { get; set; }
        public string Components { get; set; }
        public string CastingTime { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string HigherLevel { get; set; }
        public int SourceId { get; set; }
        public Sources Source { get; set; }
    }
}
