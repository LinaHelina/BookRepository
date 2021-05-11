using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext context)
        {
            _dataContext = context;
        }
        public List<Products> GetAllProduct()
        {
            return _dataContext.Products.ToList();
        }

        public async Task<Products> GetOneProduct(int id)
        {
            var product = await _dataContext.Products.FirstOrDefaultAsync(x => x.ProductId == id);
            return product;
        }

        public async Task<ProductDetails> GetProductDetail(int id)
        {
            var detail = await _dataContext.ProductDetails.FirstOrDefaultAsync(x => x.ProductDetailId == id);
            return detail;
        }
    }
}