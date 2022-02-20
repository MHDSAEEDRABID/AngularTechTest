using AngularTechTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularTechTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<EmployeeTasks> EmployeeTasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data Seeding
            modelBuilder.Seed();
        }
    }
}
