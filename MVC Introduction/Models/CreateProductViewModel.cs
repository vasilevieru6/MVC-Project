using MVC_Introduction.ValidationAttributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MVC_Introduction.Models
{
    public class CreateProductViewModel 
    {
        [Required]
        [StringLength(50, ErrorMessage = "max 50 characters")]
        public string Name { get; set; }
        [Required]  
        [PositivePriceValue]
        public int UnitPrice { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "max 30 characters")]
        public string Category { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "max 50 characters")]
        public string SubCategory { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "max 100 characters")]
        public string PhotoUrl { get; set; }
    }
}
