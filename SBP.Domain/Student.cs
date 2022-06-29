using SBP.Domain.DTO.Student;

namespace SBP.Domain
{
    public class Student
    {
        public Student(StudentDTO studentDTO)
        {
            StudendId = 1;
            Name = studentDTO.Name;
            Age = studentDTO.Age;
            DateBirth = studentDTO.DateBirth;
            CPF = studentDTO.CPF;
            CreationDate = DateTime.Now;
        }
        public int StudendId { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public DateTime DateBirth { get; private set; }
        public DateTime CreationDate { get; private set; }
        public string CPF { get; private set; }
    }
}