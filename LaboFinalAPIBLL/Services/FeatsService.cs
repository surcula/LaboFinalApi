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
    public class FeatsService(IFeatsRepository featRepository) : IFeatsService
    {
        /// <summary>
        /// Return all Feats
        /// </summary>
        /// <returns> </returns>
        public IEnumerable<Feats> GetAll()
        {
            
            return featRepository.GetAll();
            
        }
    }
}
