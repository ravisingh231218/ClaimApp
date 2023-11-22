using System.ComponentModel.DataAnnotations;

namespace ClaimAPI.Models
{
    public class ProgramVm
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }
}
