using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Item {  get; set; }

        public int? Price { get; set; }
        public int? Ca {  get; set; }
        public double? weight { get; set; }
        public int? Ca_Bonus { get; set; }
        public int? DiceType { get; set; }
        public int? DiceNumber { get;set; }
        public string? propreties { get; set; }
        public int? TypeId {  get; set; }
        public TypesItems? Type { get; set; }
    }
}
