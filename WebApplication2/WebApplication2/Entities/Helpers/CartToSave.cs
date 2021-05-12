namespace WebApplication2.Entities.Helpers
{
    public class CartToSave
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductAuthor { get; set; }
        public double ProductPrice { get; set; }
        public int quantity { get; set; }
        public int CustomerId { get; set; }
    }
}