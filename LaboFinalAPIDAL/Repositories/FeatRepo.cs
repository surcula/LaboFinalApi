using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class FeatRepo(DDBContext dbContext) : IFeatRepository
    {
       
        /// <summary>
        /// Return all feats
        /// </summary>
        /// <returns>list Feats</returns>
        public IEnumerable<Feats> GetAll()
        {
            try
            {
                return dbContext.Set<Feats>().ToList();
            }           
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving feats.", ex);
            }
        }
    }
}
