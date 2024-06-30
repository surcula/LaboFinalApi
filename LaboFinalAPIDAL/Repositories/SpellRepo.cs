using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class SpellRepo(DDBContext dbContext) : ISpellRepository
    {

        /// <summary>
        /// Retrieves all spells from the database.
        /// </summary>
        /// <returns>An enumerable collection of spells.</returns>
        public IEnumerable<Spells> GetAll()
        {
            return dbContext.Set<Spells>()
                .Include( s => s.Source)
                .ToList();
        }

        /// <summary>
        /// Creates a new spell in the database.
        /// </summary>
        /// <param name="spell">The spell to create.</param>
        public void Create(Spells spell)
        {
            dbContext.Add(spell);
            dbContext.SaveChanges();
        }
    }
}
