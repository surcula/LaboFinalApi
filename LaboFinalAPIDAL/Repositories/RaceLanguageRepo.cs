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
