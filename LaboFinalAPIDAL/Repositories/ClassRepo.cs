﻿using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class ClassRepo(DDBContext dbContext) : IClassesRepository
    {
        /// <summary>
        /// Return all classes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Classes> GetAll()
        {
            return dbContext.Set<Classes>()
                .Include( c => c.Source)
                .ToList();
        }
    }
}
