using Microsoft.EntityFrameworkCore;

namespace lab4.StudentModels
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? Password { get; set; }

    }
}
