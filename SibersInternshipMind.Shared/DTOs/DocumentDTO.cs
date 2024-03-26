using System.ComponentModel.DataAnnotations;

namespace SibersInternshipMind.Shared.Entities
{
    public class DocumentDTO
    {

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? FilePath { get; set; }

        [Required]
        public string? FileType { get; set; }

        [Required]
        public int ProjectId { get; set; }

    }
}
