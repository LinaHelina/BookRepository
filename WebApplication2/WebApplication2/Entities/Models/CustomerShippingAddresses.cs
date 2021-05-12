using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class CustomerShippingAddresses
    {
        [Key]
        public int ShippingId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int CustomerId { get; set; }
    }
}