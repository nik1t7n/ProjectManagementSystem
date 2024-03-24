using System.ComponentModel.DataAnnotations;

namespace SibersInternshipMind.Shared.Entities
{
    public class DocumentDTO
    {

        [Required(ErrorMessage = "The name of the document is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The file path is required.")]
        public string FilePath { get; set; }

        [Required(ErrorMessage = "The file type is required.")]
        public string FileType { get; set; }

        [Required(ErrorMessage = "The project ID is required.")]
        public int ProjectId { get; set; }

    }
}
