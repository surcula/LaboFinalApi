using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIBLL.Interfaces.Services;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Services
{
    public class SpellService(ISpellRepository spellRepository) : ISpellService
    {
        /// <summary>
        /// Return all spells
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Spells> GetAll()
        {
            return spellRepository.GetAll();
        }
    }
}
