using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
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
        /// return all races
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Races> GetAll()
        {
            return dDBContext.Set<Races>();
        }
    }
}
