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
    public class FeatsService(IFeatRepository featRepository) : IFeatsService
    {
        /// <summary>
        /// Return all Feats
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<Feats> GetAll()
        {
            try
            {
                return featRepository.GetAll();
            }                
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving feats.", ex);
            }
        }
    }
}
