using AngularTechTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularTechTest.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee { Id = 1, Name = "Jhon", Department = "IT", Salary = 100000 },
                                                   new Employee { Id = 2, Name = "Rimi", Department = "HR", Salary = 200000 },
                                                   new Employee { Id = 3, Name = "Jim", Department = "Operation", Salary = 50000 },
                                                   new Employee { Id = 4, Name = "Dev", Department = "IT", Salary = 150000 },
                                                   new Employee { Id = 5, Name = "Sarah", Department = "HR", Salary = 60000 },
                                                   new Employee { Id = 6, Name = "Steve", Department = "IT", Salary = 170000 },
                                                   new Employee { Id = 7, Name = "Henry", Department = "Operation", Salary = 60000 },
                                                   new Employee { Id = 8, Name = "Tony", Department = "IT", Salary = 80000 },
                                                   new Employee { Id = 9, Name = "Ema", Department = "IT", Salary = 85000 },
                                                   new Employee { Id = 10, Name = "Dani", Department = "Operation", Salary = 90000 }
                                                   );
        }
    }
}
