using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SibersInternshipMind.Shared.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? Surname { get; set; }
        public string? MiddleName { get; set; }
        [Required]
        public string? Email { get; set; }
    }
}
