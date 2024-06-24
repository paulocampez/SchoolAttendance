using SchoolAttendance.API.Model;
using SchoolAttendance.Core.Data.Entities;
using SchoolAttendance.Core.Service.Interface;
using SchoolAttendance.Infrastructure.Repositories.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAttendance.Core.Services;


public class ProfessorService : IProfessorService
{
    private readonly IProfessorRepository _professorRepository;
    public ProfessorService(IProfessorRepository professorRepository)
    {
        _professorRepository = professorRepository;
    }

    public IEnumerable<ProfessorModel> GetAllProfessors()
    {
        var professorDto = new List<ProfessorDto>();
        var professors = new List<ProfessorModel>();
        //Map ProfessorModel to ProfessorDto

        //Mapper!
        //foreach (var professor in _professorRepository.GetAllProfessors())
        //{
        //    professorDto.Add(new ProfessorDto
        //    {
        //        Id = professor.Id,
        //        Name = professor.Name,
        //        Email = professor.Email,
        //        Phone = professor.Phone
        //    });
        //}



        return professors;
    }
}
