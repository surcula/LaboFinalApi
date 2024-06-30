using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class LanguageRepo(DDBContext dDBContext) : ILanguageRepository
    {
        /// <summary>
        /// Retrieves all languages from the database.
        /// </summary>
        /// <returns>An enumerable collection of languages.</returns>
        public IEnumerable<Languages> GetAll()
        {
            return dDBContext.Set<Languages>()
                .ToList();
        }
    }
}
