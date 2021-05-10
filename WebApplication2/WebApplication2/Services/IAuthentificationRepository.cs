using System.Threading.Tasks;
using WebApplication2.Entities.Helpers;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IAuthentificationRepository
    {
        Task<Customer> Register(CustomerToRegister customerToRegister);
        Task<Customer> GetCustomer(string email);
        Task<bool> UserExists(string email);
    }
}