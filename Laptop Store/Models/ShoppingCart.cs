using System.ComponentModel.DataAnnotations;

namespace Laptop_Store.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        [Range(1,10, ErrorMessage ="Please enter a value between 1 and 10")]

        public int Count { get; set; }
    }
}
