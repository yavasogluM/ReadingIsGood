using ReadingIsGood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingIsGood.Services
{
    public interface IOrderService : IBaseService<Order>
    {
        Task<List<Order>> AddOrder(int count, int bookId, int orderId);
    }
}
