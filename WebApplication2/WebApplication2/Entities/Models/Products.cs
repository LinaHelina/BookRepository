using System.Collections.Generic;

namespace WebApplication2.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductAuthor { get; set; }
        public ICollection<ProductDetails> productDetails { get; set; }
    }
}