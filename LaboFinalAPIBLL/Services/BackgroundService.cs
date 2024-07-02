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
    public class BackgroundService(IBackgroundRepository backgroundRepository, IBackgroundSkillsRepository backgroundSkillsRepository) : IBackgroundService
    {
        public IEnumerable<BackgroundComplete> GetAll()
        {
            IEnumerable<Backgrounds> backgrounds = backgroundRepository.GetAll();
            foreach (Backgrounds background in backgrounds)
            {
                yield return new BackgroundComplete
                {
                    Backgrounds = background,
                    SkillsBackground = backgroundSkillsRepository.GetByBackgroundId(background.Id)
                };
            }
        }
    }
}
