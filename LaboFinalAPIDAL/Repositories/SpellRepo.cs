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
        public IEnumerable<Spells> GetAll()
        {
            return dbContext.Set<Spells>()
                .Include( s => s.Source)
                .ToList();
        }
    }
}
