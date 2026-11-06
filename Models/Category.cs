using System.ComponentModel.DataAnnotations;

namespace AspHw4.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 30 characters")]
        public string Name { get; set; } = "";

        public List<Product> Products { get; set; } = new();
    }
} 