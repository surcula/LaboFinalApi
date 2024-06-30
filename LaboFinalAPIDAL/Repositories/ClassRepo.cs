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
    public class ClassRepo(DDBContext dbContext) : IClassesRepository
    {
        /// <summary>
        /// Retrieves all classes from the database.
        /// </summary>
        /// <returns>An enumerable collection of classes.</returns>
        public IEnumerable<Classes> GetAll()
        {
            return dbContext.Set<Classes>()
                .Include( c => c.Source)
                .ToList();
        }

        /// <summary>
        /// Retrieves a specific class by its ID from the database.
        /// </summary>
        /// <param name="id">The ID of the class to retrieve.</param>
        /// <returns>The class with the specified ID.</returns>
        public Classes GetById(int id)
        {
            return dbContext.Set<Classes>()
                .Where( c => c.Id == id)
                .Include(c => c.Source)
                .FirstOrDefault();
        }
    }
}
