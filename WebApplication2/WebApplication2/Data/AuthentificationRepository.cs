using System;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Entities.Helpers;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Data
{
    public class AuthentificationRepository : IAuthentificationRepository
    {
        private readonly DataContext _context;
        public AuthentificationRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetCustomer(string email)
        {
            // Fetch user by email 
            var query_user = await _context.Customers.FirstOrDefaultAsync(xxx => xxx.Email == email);
            return query_user;
        }

        public async Task<Customer> Register(CustomerToRegister customerToRegister)
        {
            var newCustomer = new Customer();
            newCustomer.Email = customerToRegister.Email;
            // encrypt password
            byte[] salted = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salted);
            }
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: customerToRegister.Password,
                salt: salted,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            // store password hashed for new customer
            newCustomer.PasswordHashed = hashed;
            newCustomer.PasswordSalt = salted;
            newCustomer.CustomerId = 1;
            // add new customer to database
            _context.Customers.Add(newCustomer);
            var n= _context.SaveChanges();
            var h = 1;
            return newCustomer;
        }

        public async Task<bool> UserExists(string email)
        {
            if (await _context.Customers.AnyAsync(xxx => xxx.Email == email)) return true;
            else return false;
        }

    }
}