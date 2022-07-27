using Microsoft.EntityFrameworkCore;

namespace Day3.Models
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }


        public DbSet<Employee> Employees { get; set; }

    }
}
