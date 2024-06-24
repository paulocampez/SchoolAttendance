using SchoolAttendance.Infrastructure.Data;

namespace SchoolAttendance.Infrastructure.Repositories.Infrastructure;

public interface IProfessorRepository
{
    List<Professor> GetAllProfessors();
    Professor GetProfessorById(int id);
    Task AddProfessor(Professor professor);
    Task UpdateProfessor(Professor professor);
    Task DeleteProfessor(int id);
}
