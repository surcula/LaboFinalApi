using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDAL.Repositories
{
    public class ClassRepo : IClassesRepository
    {
        public IEnumerable<Classes> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
