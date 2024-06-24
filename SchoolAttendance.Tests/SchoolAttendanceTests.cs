using Moq;
using SchoolAttendance.Core.Service.Interface;


namespace SchoolAttendance.Tests;

public class SchoolAttendanceTests
{
    //Estrutura:
    //Controller > Service > Repository > Database

    //Mock ProfessorRepository
    private readonly Mock<IProfessorRepository> _professorRepository;
    private readonly IProfessorService _professorService;
    public SchoolAttendanceTests(IProfessorService professorService)
    {
        _professorService = professorService;
        _professorRepository = new Mock<IProfessorRepository>();
    }
    /// <summary>
    /// As admin i want to get all professors on ProfessorService.cs in SchoolAttendance.Core Service Layer
    /// </summary>
    /// 
    [Fact]
    public void GetAllProfessors_Should_Return_ProfessorList()
    {

        //Arrange
        int result = 0;
        //Act
        result = _professorService.GetAllProfessors().Count;
        //Assert
        Assert.Equal(1, foo);
    }
}

