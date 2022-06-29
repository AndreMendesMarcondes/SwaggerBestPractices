using SBP.Domain;
using SBP.Domain.DTO.Student;
using SBP.Domain.Interface.Repository;

namespace SBP.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly Random _random;

        public StudentRepository()
        {
            _random = new Random();
        }

        public List<StudentDTO> GetAll()
        {
            return GenereateStudentList();
        }

        public StudentDTO GetById(int id)
        {
            return GenereateStudentList().First();
        }

        public Student Insert(StudentDTO studentDTO)
        {
            //AutoMapper aqui para converter para o domain (mas o correto é criar um projeto de serviço)
            Student student = new Student(studentDTO);
            return student;
        }

        private List<StudentDTO> GenereateStudentList()
        {
            return new List<StudentDTO>()
          {
              new StudentDTO()
              {
                  Age = _random.Next(1,120),
                  CPF = "111.111.111.11",
                  DateBirth = DateTime.Now,
                  Name = "Name 1"
              },
               new StudentDTO()
              {
                  Age = _random.Next(1,120),
                  CPF = "222.222.222.22",
                  DateBirth = DateTime.Now,
                  Name = "Name 2"
              },
                new StudentDTO()
              {
                  Age = _random.Next(1,120),
                  CPF = "333.333.333.33",
                  DateBirth = DateTime.Now,
                  Name = "Name 3"
              }
          };
        }
    }
}