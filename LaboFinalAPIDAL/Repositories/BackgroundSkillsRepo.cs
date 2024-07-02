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
    public class BackgroundSkillsRepo(DDBContext dDBContext) : IBackgroundSkillsRepository
    {
        public IEnumerable<Skills> GetByBackgroundId(int backgroundId)
        {


            using (DDBContext context = new DDBContext())
            {
                IEnumerable<Skills> skills = context.Set<BackgroundsSkills>()
                                       .Where(bs => bs.BackgroundId == backgroundId)
                                       .Include(s => s.Skill)
                                       .Select(bs => bs.Skill)
                                       .ToList();

                return skills;
            }
            
            
            
        }
    }
}
