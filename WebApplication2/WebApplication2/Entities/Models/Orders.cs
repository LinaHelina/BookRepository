using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string OrderShipAddress1 { get; set; }
        public string OrderShipCity { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public double OrderTotal { get; set; }
        public int NumberOfItems { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; }
        public int CustomerId { get; set; }
    }
}