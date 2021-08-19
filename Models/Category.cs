using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProdsNCats.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Is required!")]
        [MinLength(3, ErrorMessage = "Must be at least 3 characters!")]
        public string CategoryName { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public List<CatProd> CatProds { get; set; }
        public List<Product> Product { get; set; }
    }
}