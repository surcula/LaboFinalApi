using LaboFinalApi.Forms;
using LaboFinalAPIDomain.Models;
using System.Runtime.CompilerServices;

namespace LaboFinalApi.Mapper
{
    public static class Mapper
    {
        public static Spells ToBll(this SpellCreateForm spellCreateForm)
        {
            return new Spells
            {
                Name = spellCreateForm.Name,
                Level = spellCreateForm.Level,
                School = spellCreateForm.School,
                Range = spellCreateForm.Range,
                Components = spellCreateForm.Components,
                CastingTime = spellCreateForm.CastingTime,
                Duration = spellCreateForm.Duration,
                Description = spellCreateForm.Description,
                HigherLevel = spellCreateForm.HigherLevel,
                SourceId = spellCreateForm.SourceId
            };
        }
    }
}
