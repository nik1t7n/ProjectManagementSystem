using System.ComponentModel.DataAnnotations;

namespace SibersInternshipMind.Shared.Entities
{
    public class Document
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? FilePath { get; set; }

        [Required]
        public string? FileType { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public Project? Project { get; set; }
    }
}
