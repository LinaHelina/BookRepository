namespace WebApplication2.Entities.Helpers
{
    public class ProductToSave
    {
        public string Title {get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string PublicationDate { get; set; }
        public string Language { get; set; }
        public int PageAmount { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string BookCover { get; set; }
        public int ProductId { get; set; }
    }
}