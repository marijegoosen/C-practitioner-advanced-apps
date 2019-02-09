using CarCompany.Business.interfaces;
using CarCompany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarCompany.Business
{
    public class Skill : ISkill
    {
        private readonly DbContext _context;

        public Skill(CarCompanyContext context)
        {
            _context = context;
        }

        public IEnumerable<Domain.Skill> GetSkills()
        {
            return _context.Set<Domain.Skill>();
        }

        public async Task<Domain.Skill> GetById(int id)
        {
            var project = await _context.Set<Domain.Skill>()
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            if (project == null)
            {
                throw new EntityNotFoundException();
            }

            return project;
        }

        public async Task Update(int id, Domain.Skill project)
        {
            _context.Entry(project).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectExists(id))
                {
                    throw new EntityNotFoundException();
                }
                throw;
            }
        }

        private bool ProjectExists(int id)
        {
            return _context.Set<Domain.Skill>().Any(e => e.Id == id);
        }
    }
}
