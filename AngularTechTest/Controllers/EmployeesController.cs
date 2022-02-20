using AngularTechTest.Data;
using AngularTechTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
namespace AngularTechTest.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [Route("api/Get")]
        [HttpGet]
        public IActionResult GetEmployees()
        {
            List<Employee> employees = context.Employees.ToList();
            return Json(employees);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
