﻿using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class FeatRepo(DDBContext dbContext) : IFeatsRepository
    {

        /// <summary>
        /// Return all feats
        /// </summary>
        /// <returns>list Feats</returns>
        public IEnumerable<Feats> GetAll()
        {
            return dbContext.Set<Feats>()
                .Include(f => f.Source)
                .ToList();
        }
    }
}
