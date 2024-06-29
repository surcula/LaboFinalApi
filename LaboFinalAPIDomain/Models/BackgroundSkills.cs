using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class BackgroundSkills
    {
        public int Id { get; set; }
        public Skills Skill { get; set; }
        public Backgrounds Background { get; set; }
    }
}
