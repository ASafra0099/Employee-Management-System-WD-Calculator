using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EmployeeManagement_system.Models;

namespace EmployeeManagement_system.ViewModels
{
    public class EmployeeViewModel
    {
        [Required(ErrorMessage = "Employee ID is required.")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Job Position is required.")]
        [StringLength(50, ErrorMessage = "Job Position name cannot exceed 50 characters.")]
        public string JobPosition { get; set; }
    }
}
