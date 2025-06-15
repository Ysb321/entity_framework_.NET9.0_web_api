using eftrial2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eftrial2.Data
{
    public class EmployeesDbContext : IdentityDbContext
    {
        public EmployeesDbContext(DbContextOptions<EmployeesDbContext> options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
