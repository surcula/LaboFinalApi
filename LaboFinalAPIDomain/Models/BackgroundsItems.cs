using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class BackgroundsItems
    {
        public int Id { get; set; }
        public int BackgroundId { get; set; }
        public Backgrounds? Background { get; set; }
        public int ItemId { get; set; }
        public Items? item { get; set; }
    }
}
