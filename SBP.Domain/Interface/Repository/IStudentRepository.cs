using SBP.Domain.DTO.Student;

namespace SBP.Domain.Interface.Repository
{
    public interface IStudentRepository
    {
        List<StudentDTO> GetAll();
        StudentDTO GetById(int id);
        Student Insert(StudentDTO student);
    }
}
