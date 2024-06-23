using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class EntitySkills
    {
        public int Id { get; set; }
        public Skills Skills { get; set; }
        public Entities Entities { get; set; }
        public int Bonus { get; set; }
    }
}
