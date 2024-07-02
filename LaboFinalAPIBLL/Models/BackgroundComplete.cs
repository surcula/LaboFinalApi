using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Models
{
    public class BackgroundComplete
    {
        public Backgrounds Backgrounds { get; set; }
        public IEnumerable<Skills> SkillsBackground { get; set; }
    }
}
