using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using WebApplication2.Data;
using WebApplication2.Entities.Helpers;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly IAuthentificationRepository _repo;
        private ApplicationSettings _appsetting;

        public AuthentificationController(IAuthentificationRepository repo, IOptions<ApplicationSettings> appsetting)
        {
            _repo = repo;
            _appsetting = appsetting.Value;
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

        [HttpPost("login")]
        public async Task<IActionResult> Login(CustomerToRegister customerToLogin)
        {
            var lowercaseEmail = customerToLogin.Email.ToLower();

            if (await _repo.UserExists(lowercaseEmail))
            {
                var user = await _repo.GetCustomer(customerToLogin.Email);
           
                string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                      password: customerToLogin.Password,
                      salt: user.PasswordSalt,
                      prf: KeyDerivationPrf.HMACSHA1,
                      iterationCount: 10000,
                      numBytesRequested: 256 / 8));

                if (hashed != user.PasswordHashed)
                    return BadRequest(new { message = "Wrong Password!" });

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim("CustomerId", user.CustomerId.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(1),
                    SigningCredentials = new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appsetting.JWT_Secret)),
                        SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var sercurityToken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(sercurityToken);
                return Ok(new { token });
            }

            return BadRequest(new { message = "This email is not registered" });
        }

    }
}
