using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibersInternshipMind.Shared.DTOs
{
    public class EmployeeDTO
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? Surname { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
