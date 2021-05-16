using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface ICatalogRepository
    {
        public List<Products> GetAllProducts();
        public Task<Products> GetOneProduct(int id);

        public Task<ProductDetails> GetOneProductDetail(int id);

        public Task<int> AddProduct(Products product);
        public void AddProductDetails(ProductDetails details);
        public Task<int> SaveChanges();

        public int getLastestProduct();

        public void UpdateInfo(Products products, ProductDetails productDetails);

        public void Delete(Products product, ProductDetails productDetails);


    }
}