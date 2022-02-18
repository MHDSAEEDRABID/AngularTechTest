using AngularTechTest.Data;
using AngularTechTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularTechTest.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Employee> employees = context.Employees.ToList();
            return View(employees);
        }
    }
}
