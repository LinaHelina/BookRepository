using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IUserRepository
    {
        public Task<Customer> getProfile(int id);
        public Task<Customer> getAddress(int id);
        public Task<int> SaveHistory(Orders orders);
        public int getLastestOrder();
        public void updateOrderDetails(OrderDetails itemToSave);
        public Task<int> SaveAllChange();
        public Task<List<Orders>> GetOrderHistory(int id);
    }
}