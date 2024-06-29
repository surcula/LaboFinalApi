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
    public class LanguageService(ILanguageRepository languageRepository) : ILanguageService
    {
        public IEnumerable<Languages> GetAll()
        {
            return languageRepository.GetAll();
        }
    }
}
