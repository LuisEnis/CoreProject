using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebCoreProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 200, ErrorMessage ="There cannot be a display order below 1 and above 200!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
