using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProductRepository _repo;
        public HomeController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("Products")]
        public ActionResult GetAllProduct()
        {
            var allProducts = _repo.GetAllProduct();
            return Ok(allProducts);
        }

        [HttpGet("Product/{id}")]
        public async Task<ActionResult> GetOneProduct(int id)
        {
            var product = await _repo.GetOneProduct(id);
            return Ok(product);
        }

        [HttpGet("Products/{id}")]
        public async Task<IActionResult> GetProductDetail(int id)
        {
            var detail = await _repo.GetProductDetail(id);
            return Ok(detail);
        }
    }
}
