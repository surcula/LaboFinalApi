using LaboFinalAPIBLL.Interfaces.Repositories;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Interfaces.Services
{
    public interface IFeatsService 
    {
        IEnumerable<Feats> GetAll();
    }
}
