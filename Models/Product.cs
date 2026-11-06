using System.ComponentModel.DataAnnotations;

namespace AspHw4.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; } = "";

        [Range(0.01, 1000000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        public int? CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}