using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using WebApplication2.Entities.Helpers;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICatalogRepository _repo;
        private readonly IWebHostEnvironment _env;

        public CatalogController(ICatalogRepository repo, IWebHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }

        [HttpGet("Products")]
        public ActionResult GetAllProducts()
        {
            var allProducts = _repo.GetAllProducts();
            return Ok(allProducts);
        }

        [HttpPost("AddProduct")]
        public async Task<IActionResult> AddProduct(ProductToSave product)
        {
            var newProduct = new Products();
            newProduct.ProductAuthor = product.Author;
            newProduct.ProductName = product.Title;
            newProduct.ProductPrice = product.Price;
            newProduct.ProductImageUrl = @"http://localhost:16194/Covers/" + product.BookCover;

            var ch = await _repo.AddProduct(newProduct);

            if (ch > 0)
            {
                var details = new ProductDetails();
                details.ShortDescription = product.Description;
                details.PublicationDate = product.PublicationDate;
                details.Category = product.Category;
                details.IsbnNumber = product.ISBN;
                details.PageAmount = product.PageAmount.ToString();
                details.ProductLanguage = product.Language;
                details.ProductImage = newProduct.ProductImageUrl;
                details.Publisher = product.Publisher;
                details.ProductName = product.Title;
                details.ProductId = _repo.getLastestProduct();
                _repo.AddProductDetails(details);
                
                await _repo.SaveChanges();
                return Ok("save successful");
            }
            return BadRequest("save unsuccessfully");
        }


        [Route("SaveFile")]
        [HttpPost]
        public JsonResult SaveFile()
        {
            try
            {
                var httpRequest = Request.Form;
                var postedFile = httpRequest.Files[0];
                string filename = postedFile.FileName;
                var physicalPath = _env.ContentRootPath + "/Covers/" + filename;

                using (var stream = new FileStream(physicalPath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                return new JsonResult(filename);
            }
            catch (Exception)
            {

                return new JsonResult("anon.png");
            }
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _repo.GetOneProduct(id);
            var detail = await _repo.GetOneProductDetail(id);
            _repo.Delete(product,detail);

            await _repo.SaveChanges();
            return Ok("save successful");
        }

    }
}
