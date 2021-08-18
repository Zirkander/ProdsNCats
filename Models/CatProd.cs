using System;
using System.ComponentModel.DataAnnotations;

namespace ProdsNCats.Models
{
    public class CatProd
    {
        [Key]
        public int CatProdId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }
}