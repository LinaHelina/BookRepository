using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductDetailId { get; set; }
        public string PublicationDate { get; set; }
        public string PageAmount { get; set; }
        public string Publisher { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string IsbnNumber { get; set; }
        public string Description { get; set; }
    }
}