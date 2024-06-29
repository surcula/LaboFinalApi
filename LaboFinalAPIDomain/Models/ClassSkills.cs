using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class ClassSkills
    {
        public int Id { get; set; }
        public Skills Skill { get; set; }
        public Classes Class { get; set; }
    }
}
