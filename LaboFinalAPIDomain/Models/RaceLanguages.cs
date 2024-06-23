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
        public Languages Languages { get; set; }
        public Races Races { get; set; }
    }
}
