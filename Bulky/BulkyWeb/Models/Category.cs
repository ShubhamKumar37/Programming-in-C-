using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWeb.Models
{
    public class Category
    {
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Category Name")]
        [MaxLength(30, ErrorMessage = "Name cannot exceed 30 characters")]
        public string Name { get; set; } = string.Empty;
        
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }
    }
}
