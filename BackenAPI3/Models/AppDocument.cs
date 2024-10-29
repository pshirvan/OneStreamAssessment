using System.ComponentModel.DataAnnotations;

namespace BackendAPI3.Models
{
    public class AppDocument
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
