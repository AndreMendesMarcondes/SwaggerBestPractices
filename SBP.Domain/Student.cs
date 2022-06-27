namespace SBP.Domain
{
    public class Student
    {
        public Guid StudendId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateBirth { get; set; }
        public DateTime CreationDate { get; set; }
        public string CPF { get; set; }
    }
}