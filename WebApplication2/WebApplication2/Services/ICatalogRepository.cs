using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface ICatalogRepository
    {
        public List<Products> GetAllProducts();
        public Task<Products> GetOneProduct(int id);

        public Task<Products> AddProduct(Products product);
        public Task<ProductDetails> AddProductDetails(ProductDetails details);
        public void SaveChanges();

        
    }
}