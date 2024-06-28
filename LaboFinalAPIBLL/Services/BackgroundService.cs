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
    public class BackgroundService(IBackgroundRepository backgroundRepository) : IBackgroundService
    {
        public IEnumerable<Backgrounds> GetAll()
        {
            return backgroundRepository.GetAll();
        }
    }
}
