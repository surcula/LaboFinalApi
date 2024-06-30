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
    public class RaceLanguageRepo(DDBContext dDBContext) : IRaceLanguagesRepository
    {
        /// <summary>
        /// Retrieves languages associated with a specific race.
        /// </summary>
        /// <param name="raceId">The ID of the race.</param>
        /// <returns>An enumerable collection of languages.</returns>
        public IEnumerable<Languages> GetByRaceId(int raceId)
        {
            using (DDBContext context = new DDBContext())
            {
                IEnumerable<Languages> languages = context.Set<RaceLanguages>()
                    .Where(rl => rl.RaceId == raceId)
                    .Include(rl => rl.Language)
                    .Select(rl => rl.Language)
                    .ToList(); 

                return languages;
            }
        }
    }
}
