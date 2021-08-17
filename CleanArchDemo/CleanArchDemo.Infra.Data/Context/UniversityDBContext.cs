using CleanArchDemo.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infra.Data.Context
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Course> Courses { get; set; }
    }
}
