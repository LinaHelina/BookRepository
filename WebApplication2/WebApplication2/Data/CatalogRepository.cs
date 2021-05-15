using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Data
{
    public class CatalogRepository: ICatalogRepository
    {
        private readonly DataContext _dataContext;

        public CatalogRepository(DataContext context)
        {
            _dataContext = context;
        }

        public List<Products> GetAllProducts()
        {
            return _dataContext.Products.ToList();
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