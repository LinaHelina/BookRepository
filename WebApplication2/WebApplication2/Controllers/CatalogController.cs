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
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogRepository _repo;

        public CatalogController(ICatalogRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("Products")]
        public ActionResult GetAllProducts()
        {
            var allProducts = _repo.GetAllProducts();
            return Ok(allProducts);
        }


    }
}
