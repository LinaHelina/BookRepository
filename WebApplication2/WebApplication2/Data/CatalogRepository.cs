using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Data
{
    public class CatalogRepository: ICatalogRepository
    {
        public List<Products> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<Products> GetOneProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Products> AddProduct(Products product)
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductDetails> AddProductDetails(ProductDetails details)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}