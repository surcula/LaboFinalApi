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
    public class ClassService(IClassesRepository classesRepository) : IClassesService
    {
        /// <summary>
        /// return all classes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<Classes> GetAll()
        {
            return classesRepository.GetAll();
        }
    }
}
