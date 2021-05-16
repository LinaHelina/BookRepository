using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string PasswordHashed { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Role { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<CustomerShippingAddresses> CustomerShippingAddresses { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}