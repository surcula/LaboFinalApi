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
        public Skills Skills { get; set; }
        public Classes Classes { get; set; }
    }
}
