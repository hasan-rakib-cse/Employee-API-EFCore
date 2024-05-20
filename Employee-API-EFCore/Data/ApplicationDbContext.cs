using Employee_API_EFCore.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee_API_EFCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
