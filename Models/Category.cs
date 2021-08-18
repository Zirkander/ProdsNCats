using System;
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
        public List<CatProd> Categories { get; set; }
    }
}