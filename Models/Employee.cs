using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement_system.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string JobPosition { get; set; }
    }

}
