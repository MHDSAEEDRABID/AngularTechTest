using System.ComponentModel.DataAnnotations;

namespace AngularTechTest.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string TaskName { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
