﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Business.interfaces
{
    public interface IProject
    {
        IEnumerable<Domain.Project> GetProjects();
        Task<Domain.Project> GetById(int id);
        Task Update(int id, Domain.Project project);
        Task Add(Domain.Project project);
        Task<Domain.Project> Delete(int id);
    }
}
