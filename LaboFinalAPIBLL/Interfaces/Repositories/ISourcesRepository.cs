﻿using LaboFinalAPIDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIBLL.Interfaces.Repositories
{
    public interface ISourcesRepository
    {
        IEnumerable<Sources> GetAll();
    }
}
