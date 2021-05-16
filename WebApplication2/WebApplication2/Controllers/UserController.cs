using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Entities.Helpers;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repo;
        private readonly DataContext _dataContext;

        public UserController(IUserRepository repo, DataContext context)
        {
            _repo = repo;
            _dataContext = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var user = await _repo.getProfile(id);
            return Ok(user);
        }

        [HttpGet("{id}/addresses")]
        public async Task<IActionResult> GetAddress(int id)
        {
            var user = await _repo.getAddress(id);
            return Ok(user);
        }

        [HttpGet("{id}/cart")]
        public async Task<IActionResult> GetCart(int id)
        {
            var cart = await _dataContext.Cart.Where(x => x.CustomerId == id).ToListAsync();
            return Ok(cart);
        }

        [HttpPost("{id}/savecart")]
        public async Task<IActionResult> SaveCart(int id, List<CartToSave> CartData)
        {

            foreach (var e in _dataContext.Cart.Where(x => x.CustomerId == id))
            {
                _dataContext.Cart.Remove(e);
            }
            await _dataContext.SaveChangesAsync();
            //var items = JsonConvert.DeserializeObject<List<Cart>>(CartData);
            foreach (var item in CartData)
            {
                var itemTosave = new Cart();
                itemTosave.CustomerId = id;
                itemTosave.ProductId = item.ProductId;
                itemTosave.ProductName = item.ProductName;
                itemTosave.ProductAuthor = item.ProductAuthor;
                itemTosave.ProductImageUrl = item.ProductImageUrl;
                itemTosave.quantity = item.quantity;
                itemTosave.ProductPrice = item.ProductPrice;
                await _dataContext.Cart.AddAsync(itemTosave);
            }
            await _dataContext.SaveChangesAsync();
            return Ok("save successful");
        }


        [HttpPost("{id}/savehistory")]
        public async Task<IActionResult> SaveHistory(int id, OrderToSave order)
        {
            int numberOfItems = 0; double total = 0;
            foreach (var item in order.detail)
            {
                numberOfItems += item.quantity;
                total += (item.ProductPrice * item.quantity);
            }
            var ordertosave = new Orders();
            ordertosave.CustomerId = id;
            ordertosave.OrderName = order.name;
            ordertosave.OrderShipAddress1 = order.address1;
            ordertosave.OrderShipCity = order.city;
            ordertosave.OrderDate = DateTime.Now;
            ordertosave.NumberOfItems = numberOfItems;
            ordertosave.OrderTotal = total;
            ordertosave.CardName = order.cardname;
            ordertosave.CardNumber = order.cardnumber;

            var changes = await _repo.SaveHistory(ordertosave);

            if (changes > 0)
            {
                foreach (var item in order.detail)
                {
                    var itemtosave = new OrderDetails();
                    itemtosave.ProductId = item.ProductId;
                    itemtosave.ProductUrl = item.ProductImageUrl;
                    itemtosave.ProductName = item.ProductName;
                    itemtosave.Quantity = item.quantity;
                    itemtosave.SalePrice = item.ProductPrice;
                    itemtosave.OrderId = _repo.getLastestOrder();
                    _repo.updateOrderDetails(itemtosave);
                }
                await _repo.SaveAllChange();
                return Ok("save successful");
            }
            return BadRequest("save unsuccessfully");
        }


        [HttpGet("{id}/ordershistory")]
        public async Task<IActionResult> GetOrdersHistory(int id)
        {
            var history = await _repo.GetOrderHistory(id);
            return Ok(history);
        }

        [HttpPost("{id}/lastlogin")]
        public async Task<IActionResult> LastLogin(int id)
        {
            var user = await _repo.getProfile(id);
            _repo.SaveAllChange();
            return Ok("last login saved");
        }

        [HttpPost("{id}/update")]
        public async Task<IActionResult> UserUpdate(int id, UserToUpdate usertoupdate)
        {

            var user = await _repo.getProfile(id);
            if (usertoupdate.newname != "") user.Fullname = usertoupdate.newname;
            if (usertoupdate.newemail != "") user.Email = usertoupdate.newemail;
            if (usertoupdate.newaddress1 != "") user.Address = usertoupdate.newaddress1;
            if (usertoupdate.newcity != "") user.City = usertoupdate.newcity;

            var v =await _repo.SaveAllChange();
            return Ok("update successful");
        }

    }
}
