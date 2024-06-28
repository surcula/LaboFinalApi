using LaboFinalAPIDomain.Models;
using System.ComponentModel.DataAnnotations;

namespace LaboFinalApi.Forms
{
    public class SpellCreateForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public string? School { get; set; }
        [Required]
        public string Range { get; set; }
        [Required]
        public string Components { get; set; }
        [Required]
        public string CastingTime { get; set; }
        [Required]
        public string Duration { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string HigherLevel { get; set; }
        [Required]
        public int SourceId { get; set; }
    }
}
