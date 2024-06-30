using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Models
{
    public class ClassComplete 
    {
        public Classes Classes {  get; set; }
        public IEnumerable<Skills> Skills { get; set; }
    }
}
