
using System.ComponentModel.DataAnnotations;

namespace SibersInternshipMind.Shared.DTOs
{
    public class ProjectDTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? ClientCompany { get; set; }
        [Required]
        public string? VendorCompany { get; set; }
        [Required]
        public int ManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Priority { get; set; }
    }
}
