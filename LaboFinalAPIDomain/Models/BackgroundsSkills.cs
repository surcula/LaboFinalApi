using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class BackgroundsSkills
    {
        public int Id { get; set; }
        public int SkillId { get; set; }
        public Skills Skill { get; set; }
        public int BackgroundId { get; set; }
        public Backgrounds Background { get; set; }
    }
}
