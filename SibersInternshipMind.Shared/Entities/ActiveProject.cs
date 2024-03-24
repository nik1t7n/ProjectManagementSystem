
using System.ComponentModel.DataAnnotations;

namespace SibersInternshipMind.Shared.Entities
{
    public class ActiveProject
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
    }
}
