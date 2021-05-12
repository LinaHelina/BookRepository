using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class OrderDetails
    {
        [Key]
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        public string ProductUrl { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double SalePrice { get; set; }
        public int OrderId { get; set; }

    }
}