using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Entities.Helpers;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly IAuthentificationRepository _repo;

        public AuthentificationController(IAuthentificationRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(CustomerToRegister customerToRegister)
        {

            customerToRegister.Email.ToLower();
           
            if (await _repo.UserExists(customerToRegister.Email))
                return BadRequest(new { message = "This Email is already registered" });

            else
            {
                var newCustomer = _repo.Register(customerToRegister);
                return StatusCode(201);
            }
        }



    }
}
