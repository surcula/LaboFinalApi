using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class BackgroundRepo(DDBContext dDBContext) : IBackgroundRepository
    {
        public IEnumerable<Backgrounds> GetAll()
        {
            return dDBContext.Set<Backgrounds>();
        }
    }
}
