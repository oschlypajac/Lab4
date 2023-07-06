using Microsoft.EntityFrameworkCore;

namespace lab4.StudentModels
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; } = null!;
    }
}
