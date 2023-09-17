using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,10,ErrorMessage ="Please Enter between 1 to 10")]
        public int DisplayOrder { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
