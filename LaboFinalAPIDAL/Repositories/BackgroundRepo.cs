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
    public class BackgroundRepo(DDBContext dDBContext) : IBackgroundRepository
    {
        /// <summary>
        /// Retrieves all backgrounds from the database.
        /// </summary>
        /// <returns>An enumerable collection of backgrounds.</returns>
        public IEnumerable<Backgrounds> GetAll()
        {
            return dDBContext.Set<Backgrounds>();
        }
    }
}
