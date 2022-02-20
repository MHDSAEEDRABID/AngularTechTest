using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AngularTechTest.Models
{
    public class EmployeeTasks
    {
        public int EmployeeId {get; set;}
        public Employee Employee { get; set; }
        public int  TaskId { get ; set;}
        public Models.Task Task {get ; set;}
    }
}
