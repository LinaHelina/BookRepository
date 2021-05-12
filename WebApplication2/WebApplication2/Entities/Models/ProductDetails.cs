using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string ProductLanguage { get; set; }
        public string IsbnNumber { get; set; }
        public string ShortDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }

        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}