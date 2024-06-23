using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Inventories
    {
        public int Id { get; set; }
        public Items Items { get; set; }
        public Entities Entities { get; set; }
    }
}
