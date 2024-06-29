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
        public int SkillId { get; set; }
        public Skills Skill { get; set; }
        public int EntityId {  get; set; }
        public Entities Entity { get; set; }
        public int Bonus { get; set; }
    }
}
