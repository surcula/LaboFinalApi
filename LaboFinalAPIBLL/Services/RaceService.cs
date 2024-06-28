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
    public class RaceService(IRacesRepository racesRepository) : IRacesService
    {
        /// <summary>
        /// return all races
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Races> GetAll()
        {
            return racesRepository.GetAll();
        }
    }
}
