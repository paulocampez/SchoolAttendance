using SchoolAttendance.Infrastructure.Data;
using SchoolAttendance.Infrastructure.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAttendance.Infrastructure.Repositories;

public class ProfessorRepository : IProfessorRepository
{
    public ProfessorRepository()
    {

    }

    public Task AddProfessor(Professor professor)
    {
        _dbContext.Add();
        _dbContext.Commit();
        return Task.CompletedTask;
    }

    public Task DeleteProfessor(int id)
    {
        throw new NotImplementedException();
    }

    public List<Professor> GetAllProfessors()
    {
        throw new NotImplementedException();
    }

    public Professor GetProfessorById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProfessor(Professor professor)
    {
        throw new NotImplementedException();
    }
}
