using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIBLL.Interfaces.Services;
using LaboFinalAPIBLL.Models;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Services
{
    public class ClassService(IClassesRepository classesRepository, IClassSkillsRepository classSkillsRepository) : IClassesService
    {
        /// <summary>
        /// return all classes
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<ClassComplete> GetAll()
        {

            IEnumerable<Classes> Classes = classesRepository.GetAll();
            foreach (Classes Class in Classes)
            {
                yield return new ClassComplete
                {
                    Classes = Class,
                    Skills = classSkillsRepository.GetByClassId(Class.Id)

                };
            }
        }

        public Classes GetById(int id)
        {
            return classesRepository.GetById(id);
        }
    }

       
}

