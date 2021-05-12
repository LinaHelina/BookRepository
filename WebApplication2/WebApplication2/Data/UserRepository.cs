using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Data
{
    public class UserRepository: IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext context)
        {
            _dataContext = context;
        }
        public async Task<Customer> getAddress(int id)
        {
            var user = await _dataContext.Customers.Include(i => i.CustomerShippingAddresses).FirstOrDefaultAsync(x => x.CustomerId == id);
            return user;
        }

        public int getLastestOrder()
        {
            var order_id = _dataContext.Orders.Max(o => o.OrderId);
            return order_id;
        }

        public async Task<List<Orders>> GetOrderHistory(int id)
        {
            var history = await _dataContext.Orders.Where(x => x.CustomerId == id).Include(i => i.OrderDetails).ToListAsync();
            return history;

        }

        public async Task<Customer> getProfile(int id)
        {
            var user = await _dataContext.Customers.FirstOrDefaultAsync(x => x.CustomerId == id);
            return user;
        }

        public async void SaveAllChange()
        {
            await _dataContext.SaveChangesAsync();
        }

        public async Task<int> SaveHistory(Orders orders)
        {
            await _dataContext.Orders.AddAsync(orders);
            int changes = await _dataContext.SaveChangesAsync();
            return changes;
        }

        public async void updateOrderDetails(OrderDetails itemToSave)
        {
            await _dataContext.OrderDetails.AddAsync(itemToSave);
        }
    }
}