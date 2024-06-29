using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIBLL.Interfaces.Services;
using LaboFinalAPIBLL.Models;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Services
{
    public class RaceService(IRacesRepository racesRepository, IRaceLanguagesRepository raceLanguagesRepository) : IRacesService
    {
        /// <summary>
        /// Returns all races with their associated languages
        /// </summary>
        /// <returns>An enumerable of RaceComplete objects</returns>
        public IEnumerable<RaceComplete> GetAll()
        {
            IEnumerable<Races> races = racesRepository.GetAll();
            foreach (Races race in races)
            {
                yield return new RaceComplete
                {
                    Race = race,
                    Languages = raceLanguagesRepository.GetByRaceId(race.Id)
                };


            }
        }
    }
}
