using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<Products> GetOneProduct(int id)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.ProductId == id);
            return product;
        }

        public async Task<ProductDetails> GetOneProductDetail(int id)
        {
            var detail = await _dataContext.ProductDetails.FirstOrDefaultAsync(x => x.ProductId == id);
            return detail;
        }

        public async Task<int> AddProduct(Products product)
        {
            await _dataContext.Products.AddAsync(product);
            int changes = await _dataContext.SaveChangesAsync();
            return changes;
        }

        public async void AddProductDetails(ProductDetails details)
        {
            await _dataContext.ProductDetails.AddAsync(details);
        }

        public async Task<int> SaveChanges()
        {
            return await _dataContext.SaveChangesAsync();
        }

        public int getLastestProduct()
        {
            var order_id = _dataContext.Products.Max(o => o.ProductId);
            return order_id;
        }

        public void Delete(Products product, ProductDetails productDetails)
        {
            _dataContext.Products.Remove(product);
        }

        public void UpdateInfo(Products products, ProductDetails productDetails)
        {
            _dataContext.Products.Update(products);
            _dataContext.ProductDetails.Update(productDetails);
        }
    }
}