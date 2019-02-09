using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Business.interfaces
{
    public interface ISkill
    {
        IEnumerable<Domain.Skill> GetSkills();
        Task<Domain.Skill> GetById(int id);
        Task Update(int id, Domain.Skill skill);
    }
}
