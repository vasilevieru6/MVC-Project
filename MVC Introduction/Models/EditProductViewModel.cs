using System.ComponentModel.DataAnnotations;

namespace MVC_Introduction.Models
{
    public class EditProductViewModel : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string SubCategory { get; set; }
        [Required]
        public string PhotoUrl { get; set; }

    }
}
