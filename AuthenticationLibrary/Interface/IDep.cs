﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationLibrary.Model;

namespace AuthenticationLibrary.Interface
{
    public interface IDep
    {
        IEnumerable<Department> GetAllDep(int? depId);
        bool Insert(Department dep);
    }
}
