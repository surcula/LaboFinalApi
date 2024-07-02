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
    public class RaceRepo(DDBContext dDBContext) : IRacesRepository
    {
        /// <summary>
        /// Retrieves all races from the database.
        /// </summary>
        /// <returns>An enumerable collection of races.</returns>
        public IEnumerable<Races> GetAll()
        {
            return dDBContext.Set<Races>()
                .ToList();
        }
    }
}
