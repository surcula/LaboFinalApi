using LaboFinalAPIBLL.Models;
using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Interfaces.Services
{
    public interface IClassesService
    {
        IEnumerable<ClassComplete> GetAll();
        Classes GetById(int id);
    }

}
