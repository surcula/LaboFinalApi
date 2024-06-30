using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class ClassSkillRepo(DDBContext dDBContext) : IClassSkillsRepository
    {

        /// <summary>
        /// Retrieves skills associated with a specific class.
        /// </summary>
        /// <param name="classId">The ID of the class.</param>
        /// <returns>An enumerable collection of skills.</returns>
        public IEnumerable<Skills> GetByClassId(int classId)
        {
            using (DDBContext context = new DDBContext())
            {
                IEnumerable<Skills> skills = context.Set<ClassSkills>()
               .Where(cs => cs.ClassId == classId)
               .Include(cs => cs.Skill)
               .Select(cs => cs.Skill)
               .ToList();
                return skills;
            }
        }
    }
}
