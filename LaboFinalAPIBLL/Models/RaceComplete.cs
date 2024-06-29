using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Models
{
    public class RaceComplete
    {
        public Races Race { get; set; }
        public IEnumerable<Languages> Languages { get; set; }
    }
}
