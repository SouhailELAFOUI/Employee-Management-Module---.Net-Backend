using Microsoft.EntityFrameworkCore;
using EmployeeManagementAPI.Models; // Ensure this matches the namespace of your Employee class

namespace EmployeeManagementSystemBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
