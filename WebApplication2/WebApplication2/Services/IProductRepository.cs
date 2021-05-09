using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IProductRepository
    {
        public List<Products> GetAllProduct();
        public Task<Products> GetOneProduct(int id);
        public Task<ProductDetails> GetProductDetail(int id);
    }
}