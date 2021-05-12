using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductAuthor { get; set; }
        public int quantity { get; set; }
        public double ProductPrice { get; set; }
        public int CustomerId { get; set; }
    }
}