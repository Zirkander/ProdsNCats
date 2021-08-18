using System;
using System.ComponentModel.DataAnnotations;

namespace ProdsNCats.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Is required!")]
        [MinLength(3, ErrorMessage = "Must be greater than 3!")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Is required!")]
        [MinLength(3, ErrorMessage = "Must be greater than 3!")]
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Is required!")]
        [Display(Name = "Product Price")]
        public double ProductPrice { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

    }
}